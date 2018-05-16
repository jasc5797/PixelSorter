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
        public enum SortType { Horizontal, Vertical, Both }

        public Bitmap OriginalImage { get; set; }
        public Bitmap SortedImage { get; set; }

        public SortBy sortBy { get; set; }
        public SortType sortType { get; set; }
    }
}
