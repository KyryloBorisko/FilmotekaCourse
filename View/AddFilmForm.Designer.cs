namespace FilmotekaCourse
{
    partial class AddFilmForm
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
            textBoxTitle = new TextBox();
            textBoxGenre = new TextBox();
            textBoxYear = new TextBox();
            textBoxPosterPath = new TextBox();
            button1 = new Button();
            button2 = new Button();
            labeladdName = new Label();
            labeladdGenre = new Label();
            labeladdRIk = new Label();
            labeladdPoster = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(52, 47);
            textBoxTitle.Multiline = true;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(160, 28);
            textBoxTitle.TabIndex = 0;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(57, 101);
            textBoxGenre.Multiline = true;
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(167, 27);
            textBoxGenre.TabIndex = 1;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(39, 147);
            textBoxYear.Multiline = true;
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(61, 23);
            textBoxYear.TabIndex = 2;
            // 
            // textBoxPosterPath
            // 
            textBoxPosterPath.Location = new Point(330, 142);
            textBoxPosterPath.Name = "textBoxPosterPath";
            textBoxPosterPath.Size = new Size(100, 23);
            textBoxPosterPath.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(59, 255);
            button1.Name = "button1";
            button1.Size = new Size(100, 34);
            button1.TabIndex = 4;
            button1.Text = "Зберегти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(330, 176);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Огляд...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labeladdName
            // 
            labeladdName.AutoSize = true;
            labeladdName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labeladdName.Location = new Point(7, 53);
            labeladdName.Name = "labeladdName";
            labeladdName.Size = new Size(44, 15);
            labeladdName.TabIndex = 6;
            labeladdName.Text = "Назва:";
            // 
            // labeladdGenre
            // 
            labeladdGenre.AutoSize = true;
            labeladdGenre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labeladdGenre.Location = new Point(7, 106);
            labeladdGenre.Name = "labeladdGenre";
            labeladdGenre.Size = new Size(48, 15);
            labeladdGenre.TabIndex = 7;
            labeladdGenre.Text = "Жанри:";
            // 
            // labeladdRIk
            // 
            labeladdRIk.AutoSize = true;
            labeladdRIk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labeladdRIk.Location = new Point(7, 151);
            labeladdRIk.Name = "labeladdRIk";
            labeladdRIk.Size = new Size(26, 15);
            labeladdRIk.TabIndex = 8;
            labeladdRIk.Text = "Рік:";
            // 
            // labeladdPoster
            // 
            labeladdPoster.AutoSize = true;
            labeladdPoster.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labeladdPoster.Location = new Point(334, 113);
            labeladdPoster.Name = "labeladdPoster";
            labeladdPoster.Size = new Size(93, 15);
            labeladdPoster.TabIndex = 9;
            labeladdPoster.Text = "Постер фільму:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.free_icon_insert_picture_icon_16410;
            pictureBox1.Location = new Point(408, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // AddFilmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(478, 357);
            Controls.Add(pictureBox1);
            Controls.Add(labeladdPoster);
            Controls.Add(labeladdRIk);
            Controls.Add(labeladdGenre);
            Controls.Add(labeladdName);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxPosterPath);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxTitle);
            Name = "AddFilmForm";
            Text = "AddFilmForm";
            Load += AddFilmForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private TextBox textBoxGenre;
        private TextBox textBoxYear;
        private TextBox textBoxPosterPath;
        private Button button1;
        private Button button2;
        private Label labeladdName;
        private Label labeladdGenre;
        private Label labeladdRIk;
        private Label labeladdPoster;
        private PictureBox pictureBox1;
    }
}