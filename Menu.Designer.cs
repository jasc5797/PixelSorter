namespace PixelSorter
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.imageFilePathTextBox = new System.Windows.Forms.TextBox();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            this.sortTypeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg) | *png; *.jpg; *.jpeg";
            // 
            // selectImageButton
            // 
            this.selectImageButton.Location = new System.Drawing.Point(234, 10);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(80, 23);
            this.selectImageButton.TabIndex = 0;
            this.selectImageButton.Text = "Select Image";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // imageFilePathTextBox
            // 
            this.imageFilePathTextBox.Location = new System.Drawing.Point(12, 12);
            this.imageFilePathTextBox.Name = "imageFilePathTextBox";
            this.imageFilePathTextBox.ReadOnly = true;
            this.imageFilePathTextBox.Size = new System.Drawing.Size(216, 20);
            this.imageFilePathTextBox.TabIndex = 1;
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Location = new System.Drawing.Point(12, 39);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(301, 167);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewPictureBox.TabIndex = 2;
            this.previewPictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(238, 311);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.Items.AddRange(new object[] {
            "Luminance",
            "Brightness",
            "Saturation",
            "Hue"});
            this.sortByComboBox.Location = new System.Drawing.Point(193, 213);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortByComboBox.TabIndex = 6;
            this.sortByComboBox.SelectedIndexChanged += new System.EventHandler(this.sortByComboBox_SelectedIndexChanged);
            // 
            // sortTypeComboBox
            // 
            this.sortTypeComboBox.FormattingEnabled = true;
            this.sortTypeComboBox.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "Both"});
            this.sortTypeComboBox.Location = new System.Drawing.Point(193, 240);
            this.sortTypeComboBox.Name = "sortTypeComboBox";
            this.sortTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortTypeComboBox.TabIndex = 7;
            this.sortTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.sortTypeComboBox_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 346);
            this.Controls.Add(this.sortTypeComboBox);
            this.Controls.Add(this.sortByComboBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.previewPictureBox);
            this.Controls.Add(this.imageFilePathTextBox);
            this.Controls.Add(this.selectImageButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Pixel Sorter";
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.TextBox imageFilePathTextBox;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox sortByComboBox;
        private System.Windows.Forms.ComboBox sortTypeComboBox;
    }
}

