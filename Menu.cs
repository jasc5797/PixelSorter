using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelSorter
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            //sortByComboBox.DataSource = Settings.SortBy;

        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openImageDialog.FileName;
                imageFilePathTextBox.Text = filePath;
                previewPictureBox.ImageLocation = filePath;
            }
            TryEnableStartButton();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.OriginalImage = new Bitmap(imageFilePathTextBox.Text);
            settings.sortBy = (Settings.SortBy)sortByComboBox.SelectedIndex;
            settings.sortType = (Settings.SortType)sortTypeComboBox.SelectedIndex;
            PixelSorter pixelSorter = new PixelSorter(settings);
            pixelSorter.Show();
            Hide();
        }

        private void sortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TryEnableStartButton();
        }

        private void sortTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TryEnableStartButton();
        }

        private void TryEnableStartButton()
        {
            string filePath = imageFilePathTextBox.Text;
            startButton.Enabled = !string.IsNullOrWhiteSpace(filePath) && File.Exists(filePath)
                && sortByComboBox.SelectedIndex > -1 && sortTypeComboBox.SelectedIndex > -1;
        }
    }
}
