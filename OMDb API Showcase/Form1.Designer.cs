namespace OMDb_API_Showcase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxYear = new TextBox();
            comboBoxType = new ComboBox();
            pictureBox1 = new PictureBox();
            buttonSearch = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            mainGroupBox = new GroupBox();
            buttonClose = new Button();
            labelYear = new Label();
            labelDescription = new Label();
            labelGenres = new Label();
            labelName = new Label();
            picturePoster = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            mainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePoster).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(285, 205);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(273, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(285, 267);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(273, 23);
            textBoxYear.TabIndex = 2;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Movie", "Series", "Episode" });
            comboBoxType.Location = new Point(285, 329);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(273, 23);
            comboBoxType.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMDB;
            pictureBox1.Location = new Point(329, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // buttonSearch
            // 
            buttonSearch.Image = Properties.Resources.search_icon;
            buttonSearch.Location = new Point(353, 384);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(135, 27);
            buttonSearch.TabIndex = 5;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 187);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(406, 249);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 8;
            label1.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 311);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "Type";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.format_quote_FILL0_wght400_GRAD0_opsz24;
            pictureBox2.Location = new Point(236, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pin_FILL0_wght400_GRAD0_opsz24;
            pictureBox3.Location = new Point(236, 267);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.format_list_bulleted_FILL0_wght400_GRAD0_opsz24;
            pictureBox4.Location = new Point(236, 329);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // mainGroupBox
            // 
            mainGroupBox.Controls.Add(buttonClose);
            mainGroupBox.Controls.Add(labelYear);
            mainGroupBox.Controls.Add(labelDescription);
            mainGroupBox.Controls.Add(labelGenres);
            mainGroupBox.Controls.Add(labelName);
            mainGroupBox.Controls.Add(picturePoster);
            mainGroupBox.Enabled = false;
            mainGroupBox.Location = new Point(0, -1);
            mainGroupBox.Name = "mainGroupBox";
            mainGroupBox.Size = new Size(841, 563);
            mainGroupBox.TabIndex = 13;
            mainGroupBox.TabStop = false;
            mainGroupBox.Visible = false;
            // 
            // buttonClose
            // 
            buttonClose.ForeColor = SystemColors.ButtonHighlight;
            buttonClose.Image = Properties.Resources.close_icon;
            buttonClose.Location = new Point(783, 13);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(46, 39);
            buttonClose.TabIndex = 5;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(408, 341);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(29, 15);
            labelYear.TabIndex = 4;
            labelYear.Text = "Year";
            labelYear.SizeChanged += label_SizeChanged;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(407, 387);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(67, 15);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Description";
            labelDescription.SizeChanged += label_SizeChanged;
            // 
            // labelGenres
            // 
            labelGenres.AutoSize = true;
            labelGenres.Location = new Point(407, 363);
            labelGenres.Name = "labelGenres";
            labelGenres.Size = new Size(43, 15);
            labelGenres.TabIndex = 2;
            labelGenres.Text = "Genres";
            labelGenres.SizeChanged += label_SizeChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(407, 318);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            labelName.SizeChanged += label_SizeChanged;
            // 
            // picturePoster
            // 
            picturePoster.Image = Properties.Resources.default_image;
            picturePoster.InitialImage = Properties.Resources.default_image;
            picturePoster.Location = new Point(300, 13);
            picturePoster.Name = "picturePoster";
            picturePoster.Size = new Size(246, 290);
            picturePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePoster.TabIndex = 0;
            picturePoster.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 560);
            Controls.Add(mainGroupBox);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(buttonSearch);
            Controls.Add(pictureBox1);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Movies Searcher";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            mainGroupBox.ResumeLayout(false);
            mainGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxName;
        private TextBox textBoxYear;
        private ComboBox comboBoxType;
        private PictureBox pictureBox1;
        private Button buttonSearch;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private GroupBox mainGroupBox;
        private Button buttonClose;
        private Label labelYear;
        private Label labelDescription;
        private Label labelGenres;
        private Label labelName;
        private PictureBox picturePoster;
    }
}
