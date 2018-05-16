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
    public partial class PixelSorter : Form
    {
        public delegate void ProgressBarDelegate();

        private Bitmap finalImage;

        public PixelSorter(Settings settings)
        {
            Bitmap image = settings.OriginalImage;
            InitializeComponent();
            finalImage = (Bitmap)image.Clone();
            progressBar.Maximum = image.Width;

            ThreadPool.GetAvailableThreads(out int workerThreads, out int completionPortThreads);
            Console.WriteLine("Worker Threads: " + workerThreads + " - Completion Port Threads: " + completionPortThreads);
            int value = settings.sortType == Settings.SortType.Horizontal ? image.Width : image.Height;
            for (int index = 0; index < value; index++)
            {
                ThreadInfo threadInfo = new ThreadInfo();
                threadInfo.Image = (Bitmap)image.Clone();
                threadInfo.Index = index;
                threadInfo.settings = settings;
                ThreadPool.QueueUserWorkItem(new WaitCallback(Process), threadInfo);
            }  
        }

        private void Process(object state)
        {
            ThreadInfo threadInfo = (ThreadInfo)state;
            Bitmap image = threadInfo.Image;
            int index = threadInfo.Index;

            List<Color> colors = new List<Color>();

            switch (threadInfo.settings.sortType)
            {
                case Settings.SortType.Horizontal:
                    for (int column = 0; column < image.Height; column++)
                    {
                        colors.Add(image.GetPixel(index, column));
                    }
                    break;
                case Settings.SortType.Vertical:
                    for (int row = 0; row < image.Width; row++)
                    {
                        colors.Add(image.GetPixel(row, index));
                    }
                    break;
            }
           
            switch (threadInfo.settings.sortBy)
            {
                case Settings.SortBy.Brightness:
                    colors.Sort(delegate (Color color1, Color color2) { return color1.GetBrightness().CompareTo(color2.GetBrightness()); });
                    break;
                case Settings.SortBy.Luminance:
                    colors.Sort(delegate (Color color1, Color color2) { return GetRelativeLuminance(color1).CompareTo(GetRelativeLuminance(color2)); });
                    break;
                case Settings.SortBy.Hue:
                    colors.Sort(delegate (Color color1, Color color2) { return color1.GetHue().CompareTo(color2.GetHue()); });
                    break;
                case Settings.SortBy.Saturation:
                    colors.Sort(delegate (Color color1, Color color2) { return color1.GetSaturation().CompareTo(color2.GetSaturation()); });
                    break;
            }
            lock (this)
            {

                for (int i = 0; i < colors.Count; i++)
                {
                    switch (threadInfo.settings.sortType)
                    {
                        case Settings.SortType.Vertical:
                            finalImage.SetPixel(i, index, colors[i]);
                            break;
                        case Settings.SortType.Horizontal:
                            finalImage.SetPixel(index, i, colors[i]);
                            break;
                    }
                }

            }

            try
            {
                Invoke(new ProgressBarDelegate(UpdateProgressBar));
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }  
        }

        private int Sort(double value1, double value2)
        {
            return value1.CompareTo(value2);
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
                ImageDisplay imageDisplay = new ImageDisplay(finalImage);
                imageDisplay.Show();
                Hide();
            }
        }
    }

    class ThreadInfo
    {
        public Bitmap Image { get; set; }
        public int Index { get; set; }
        public Settings settings { get; set; }
    }
}
