namespace PixelSorter
{
    partial class SortSettingsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sortDirectionComboBox = new System.Windows.Forms.ComboBox();
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.angleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.intervalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.intervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Selected Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sort Direction:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sort By:";
            // 
            // sortDirectionComboBox
            // 
            this.sortDirectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortDirectionComboBox.FormattingEnabled = true;
            this.sortDirectionComboBox.Location = new System.Drawing.Point(196, 225);
            this.sortDirectionComboBox.Name = "sortDirectionComboBox";
            this.sortDirectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortDirectionComboBox.TabIndex = 16;
            this.sortDirectionComboBox.SelectionChangeCommitted += new System.EventHandler(this.sortDirectionComboBox_SelectionChangeCommitted);
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.Location = new System.Drawing.Point(196, 198);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortByComboBox.TabIndex = 15;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(237, 331);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 23);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Location = new System.Drawing.Point(15, 25);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(302, 167);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewPictureBox.TabIndex = 13;
            this.previewPictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Angle:";
            // 
            // angleUpDown
            // 
            this.angleUpDown.Enabled = false;
            this.angleUpDown.Location = new System.Drawing.Point(196, 252);
            this.angleUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleUpDown.Name = "angleUpDown";
            this.angleUpDown.Size = new System.Drawing.Size(121, 20);
            this.angleUpDown.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Interval Type:";
            // 
            // intervalTypeComboBox
            // 
            this.intervalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalTypeComboBox.FormattingEnabled = true;
            this.intervalTypeComboBox.Location = new System.Drawing.Point(196, 278);
            this.intervalTypeComboBox.Name = "intervalTypeComboBox";
            this.intervalTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.intervalTypeComboBox.TabIndex = 23;
            this.intervalTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.intervalTypeComboBox_SelectionChangeCommitted);
            // 
            // intervalUpDown
            // 
            this.intervalUpDown.Enabled = false;
            this.intervalUpDown.Location = new System.Drawing.Point(196, 305);
            this.intervalUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.intervalUpDown.Name = "intervalUpDown";
            this.intervalUpDown.Size = new System.Drawing.Size(121, 20);
            this.intervalUpDown.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Interval Length:";
            // 
            // SortingOptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 363);
            this.Controls.Add(this.intervalUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.intervalTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.angleUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortDirectionComboBox);
            this.Controls.Add(this.sortByComboBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.previewPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SortingOptionsMenu";
            this.Text = "SortingOptionsMenu";
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sortDirectionComboBox;
        private System.Windows.Forms.ComboBox sortByComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown angleUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox intervalTypeComboBox;
        private System.Windows.Forms.NumericUpDown intervalUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
    }
}