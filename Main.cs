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
    public partial class Main : Form
    {
        private Settings settings;

        public Main()
        {
            InitializeComponent();
            
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
            Settings settings = new Settings();
            settings.OriginalImage = new Bitmap(imageFilePathTextBox.Text);
            settings.sortBy = (Settings.SortBy)sortByComboBox.SelectedIndex;
            settings.sortType = (Settings.SortType)sortTypeComboBox.SelectedIndex;
            settings.fileName = Path.GetFileName(imageFilePathTextBox.Text);
            PixelSorter pixelSorter = new PixelSorter(settings);
            pixelSorter.Show();
        }
    }
}
