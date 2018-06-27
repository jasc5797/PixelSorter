using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelSorter
{
    public partial class PixelSorterForm : Form
    {
        public delegate void ProgressBarDelegate();

        private SortSettings settings;

        private bool stop;

        public PixelSorterForm(SortSettings settings)
        {
            InitializeComponent();

            this.settings = settings;
            stop = false;
            Bitmap image = settings.ImageOriginal;
            settings.ImageSorted = (Bitmap)image.Clone();

            int value = settings.SortDirectionSelection == SortSettings.SortDirection.Horizontal ? image.Height : image.Width;
            progressBar.Maximum = value;
            for (int index = 0; index < value; index++)
            {
                ThreadInfo threadInfo = new ThreadInfo();
                threadInfo.Image = (Bitmap)image.Clone();
                threadInfo.Index = index;
                threadInfo.Settings = (SortSettings)settings.Clone();
                ThreadPool.QueueUserWorkItem(new WaitCallback(Process), threadInfo);
            }  
        }

        private void Process(object state)
        {
            ThreadInfo threadInfo = (ThreadInfo)state;
            Bitmap image = threadInfo.Image;
            int index = threadInfo.Index;

            List<Color> colors = new List<Color>();

            switch (threadInfo.Settings.SortDirectionSelection)
            {
                case SortSettings.SortDirection.Horizontal:
                    for (int column = 0; column < image.Width; column++)
                    {
                        colors.Add(image.GetPixel(column, index));
                    }
                    break;
                case SortSettings.SortDirection.Vertical:
                    for (int row = 0; row < image.Height; row++)
                    {
                        colors.Add(image.GetPixel(index, row));
                    }
                    break;
            }

            PixelSort(threadInfo.Settings, colors);
            lock (this)
            {
                for (int i = 0; i < colors.Count && !stop; i++)
                {
                    switch (threadInfo.Settings.SortDirectionSelection)
                    {
                        case SortSettings.SortDirection.Vertical:
                            settings.ImageSorted.SetPixel(index, i, colors[i]);
                            break;
                        case SortSettings.SortDirection.Horizontal:
                            settings.ImageSorted.SetPixel(i, index, colors[i]);
                            break;
                    }
                }
            }

            try
            {
                while (!IsHandleCreated);
                Invoke(new ProgressBarDelegate(UpdateProgressBar));
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }  
        }

        private List<Color> PixelSort(SortSettings settings, List<Color> colors)
        {
            switch (settings.IntervalTypeSelection)
            {
                case SortSettings.IntervalType.Disabled:
                    Sort(settings, colors);
                    break;
                case SortSettings.IntervalType.FromPixel:
                case SortSettings.IntervalType.WholeImage:
                    SortInterval(settings, colors);
                    break;
            }
            return colors;
        }

        private List<Color> SortInterval(SortSettings settings, List<Color> colors)
        {
            switch (settings.IntervalTypeSelection)
            {
                case SortSettings.IntervalType.FromPixel:
                    break;
                case SortSettings.IntervalType.WholeImage:
                    double subArrayLength = settings.ImageOriginal.Width / settings.Interval;
                    for (int i = 0; i < settings.ImageOriginal.Width; i += settings.Interval)
                    {
                        int length = i + settings.Interval > settings.ImageOriginal.Width ? settings.ImageOriginal.Width - i : settings.Interval;
                        Sort(settings, colors.GetRange(i, length));
                       
                    }
                    break;
            }
            return colors;
        }

        private List<Color> Sort(SortSettings settings, List<Color > colors)
        {
            switch (settings.SortBySelection)
            {
                case SortSettings.SortBy.Brightness:
                    colors.Sort(delegate (Color color1, Color color2) { return color1.GetBrightness().CompareTo(color2.GetBrightness()); });
                    break;
                case SortSettings.SortBy.Luminance:
                    colors.Sort(delegate (Color color1, Color color2) { return GetRelativeLuminance(color1).CompareTo(GetRelativeLuminance(color2)); });
                    break;
                case SortSettings.SortBy.Hue:
                    colors.Sort(delegate (Color color1, Color color2) { return color1.GetHue().CompareTo(color2.GetHue()); });
                    break;
                case SortSettings.SortBy.Saturation:
                    colors.Sort(delegate (Color color1, Color color2) { return color1.GetSaturation().CompareTo(color2.GetSaturation()); });
                    break;
            }
            return colors;
        }

        private double GetRelativeLuminance(Color color)
        {
            return 0.2126 * color.R + 0.7152 * color.G + 0.0722 * color.B;
        }

        private void UpdateProgressBar()
        {
            progressBar.Value++;
            if(progressBar.Value == progressBar.Maximum)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void PixelSorter_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop = true;
        }
    }

    class ThreadInfo
    {
        public Bitmap Image { get; set; }
        public int Index { get; set; }
        public SortSettings Settings { get; set; }
    }
}
