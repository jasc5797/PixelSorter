using System;
using System.Drawing;
using System.Windows.Forms;

namespace PixelSorter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            SortSettingsForm sortSettingsForm = new SortSettingsForm((Bitmap)pictureBox.Image);
            if (sortSettingsForm.ShowDialog() == DialogResult.OK)
            {
                PixelSorterForm pixelSorterForm = new PixelSorterForm(sortSettingsForm.Settings);
                if (pixelSorterForm.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = sortSettingsForm.Settings.ImageSorted;
                } 
            }
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openImageDialog.FileName);
                sortButton.Enabled = true;
            }
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            if (saveImageDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(saveImageDialog.FileName))
            {
                pictureBox.Image.Save(saveImageDialog.FileName);
            }
        }
    }
}
