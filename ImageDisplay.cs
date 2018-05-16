using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelSorter
{
    public partial class ImageDisplay : Form
    {
        public ImageDisplay(Settings settings)
        {
            InitializeComponent();
            pictureBox1.Image = settings.SortedImage;
        }

        private void ImageDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveImageDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(saveImageDialog.FileName))
            {
                /*string extension = Path.GetExtension(saveImageDialog.FileName);
                ImageFormat imageFormat;
                switch (extension)
                {
                    case ".jpg":
                    case ".jpeg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                    default:
                        imageFormat = ImageFormat.Png;
                        break;
                }*/
                pictureBox1.Image.Save(saveImageDialog.FileName);
            }
        }
    }
}
