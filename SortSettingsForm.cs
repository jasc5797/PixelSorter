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
    public partial class SortSettingsForm : Form
    {
        public SortSettings Settings { get; set; }

        public SortSettingsForm(Bitmap image) : base()
        {
            InitializeComponent();
            //Initialize the form's comboboxes with their respective enum values
            sortByComboBox.DataSource = SortSettings.GetEnumAsDataSource(typeof(SortSettings.SortBy));
            sortDirectionComboBox.DataSource = SortSettings.GetEnumAsDataSource(typeof(SortSettings.SortDirection));
            intervalTypeComboBox.DataSource = SortSettings.GetEnumAsDataSource(typeof(SortSettings.IntervalType));

            previewPictureBox.Image = image;
            intervalUpDown.Maximum = Math.Max(image.Width, image.Height); // Change to hypotemus for angles
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Settings = new SortSettings
            {
                ImageOriginal = (Bitmap)previewPictureBox.Image,
                SortBySelection = (SortSettings.SortBy)sortByComboBox.SelectedIndex,
                SortDirectionSelection = (SortSettings.SortDirection)sortDirectionComboBox.SelectedIndex,
                IntervalTypeSelection = (SortSettings.IntervalType)intervalTypeComboBox.SelectedIndex,
                Angle = (int)angleUpDown.Value,
                Interval = (int)intervalUpDown.Value,
                IsRandomInterval = randomIntervalCheckBox.Checked
        };
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Enable the angle numericUpDown if the selected value of sortDirectionComboBox is "Angle"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortDirectionComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            angleUpDown.Enabled = ((ComboBox)sender).SelectedIndex == (int)SortSettings.SortDirection.Angle;
        }

        /// <summary>
        /// Enable the interval numericUpDown if the selected value of intervalTypeComboBox is not "Disabled"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void intervalTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool enabled = ((ComboBox)sender).SelectedIndex != (int)SortSettings.IntervalType.Disabled;
            intervalUpDown.Enabled = enabled;
            randomIntervalCheckBox.Enabled = enabled;
        }

    }
}
