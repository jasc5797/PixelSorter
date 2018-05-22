using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelSorter
{
    public class Settings
    {
        public enum SortBy { Luminance, Brightness, Saturation, Hue }
        public enum SortDirection { Horizontal, Vertical }

        public Bitmap OriginalImage { get; set; }
        public Bitmap SortedImage { get; set; }

        public SortBy SelectedSortBy { get; set; }
        public SortDirection SelectedSortDirection { get; set; }
    }
}
