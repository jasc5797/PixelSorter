using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelSorter
{
    public partial class ImageDisplay : Form
    {
        public ImageDisplay(Bitmap image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }

        private void ImageDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
