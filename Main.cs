using System;
using System.Drawing;
using System.Windows.Forms;

namespace PixelSorter
{
    public partial class Main : Form
    {
        private Settings settings;

        public Main()
        {
            InitializeComponent();
            settings = new Settings();
            sortByComboBox.SelectedIndex = 0;
            sortDirectionComboBox.SelectedIndex = 0;
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openImageDialog.FileName;
                pictureBox.ImageLocation = filePath;
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

        private void sortButton_Click(object sender, EventArgs e)
        {
            settings.OriginalImage = (Bitmap)pictureBox.Image;
            settings.SelectedSortBy = (Settings.SortBy)sortByComboBox.SelectedIndex;
            settings.SelectedSortDirection = (Settings.SortDirection)sortDirectionComboBox.SelectedIndex;
            PixelSorter pixelSorter = new PixelSorter(settings);
            if(pixelSorter.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = settings.SortedImage;
            }
        }
    }
}
