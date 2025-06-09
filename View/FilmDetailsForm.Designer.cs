namespace FilmotekaCourse
{
    partial class FilmDetailsForm
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
            components = new System.ComponentModel.Container();
            pictureBoxPoster = new PictureBox();
            labelTitle = new Label();
            labelGenre = new Label();
            labelYear = new Label();
            labelStudioo = new Label();
            labelDirectorr = new Label();
            labelActorss = new Label();
            textBoxDescription = new TextBox();
            filmBindingSource = new BindingSource(components);
            labelRatingg = new Label();
            buttonClose = new Button();
            labelOpis = new Label();
            buttonSave = new Button();
            textBoxStudio = new TextBox();
            textBoxRating = new TextBox();
            textBoxActors = new TextBox();
            textBoxDirector = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPoster
            // 
            pictureBoxPoster.Location = new Point(12, 12);
            pictureBoxPoster.Name = "pictureBoxPoster";
            pictureBoxPoster.Size = new Size(154, 209);
            pictureBoxPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPoster.TabIndex = 0;
            pictureBoxPoster.TabStop = false;
            pictureBoxPoster.Click += pictureBoxPoster_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(9, 225);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(57, 21);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "label1";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(12, 248);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(38, 15);
            labelGenre.TabIndex = 2;
            labelGenre.Text = "label1";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(12, 266);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(38, 15);
            labelYear.TabIndex = 3;
            labelYear.Text = "label1";
            // 
            // labelStudioo
            // 
            labelStudioo.AutoSize = true;
            labelStudioo.Location = new Point(12, 306);
            labelStudioo.Name = "labelStudioo";
            labelStudioo.Size = new Size(44, 15);
            labelStudioo.TabIndex = 4;
            labelStudioo.Text = "Студія:";
            // 
            // labelDirectorr
            // 
            labelDirectorr.AutoSize = true;
            labelDirectorr.Location = new Point(12, 347);
            labelDirectorr.Name = "labelDirectorr";
            labelDirectorr.Size = new Size(58, 15);
            labelDirectorr.TabIndex = 5;
            labelDirectorr.Text = "Режисер:";
            // 
            // labelActorss
            // 
            labelActorss.AutoSize = true;
            labelActorss.Location = new Point(12, 384);
            labelActorss.Name = "labelActorss";
            labelActorss.Size = new Size(50, 15);
            labelActorss.TabIndex = 6;
            labelActorss.Text = "Актори:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(187, 43);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(353, 178);
            textBoxDescription.TabIndex = 7;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            // 
            // filmBindingSource
            // 
            filmBindingSource.DataSource = typeof(Film);
            // 
            // labelRatingg
            // 
            labelRatingg.AutoSize = true;
            labelRatingg.Location = new Point(12, 422);
            labelRatingg.Name = "labelRatingg";
            labelRatingg.Size = new Size(48, 15);
            labelRatingg.TabIndex = 8;
            labelRatingg.Text = "Оцінка:";
            labelRatingg.Click += labelRating_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(465, 480);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(95, 33);
            buttonClose.TabIndex = 9;
            buttonClose.Text = "Назад";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelOpis
            // 
            labelOpis.AutoSize = true;
            labelOpis.Location = new Point(187, 25);
            labelOpis.Name = "labelOpis";
            labelOpis.Size = new Size(39, 15);
            labelOpis.TabIndex = 10;
            labelOpis.Text = "Опис:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(341, 471);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(118, 42);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxStudio
            // 
            textBoxStudio.Location = new Point(56, 303);
            textBoxStudio.Multiline = true;
            textBoxStudio.Name = "textBoxStudio";
            textBoxStudio.ScrollBars = ScrollBars.Horizontal;
            textBoxStudio.Size = new Size(287, 23);
            textBoxStudio.TabIndex = 12;
            textBoxStudio.TextChanged += textBoxStudio_TextChanged;
            // 
            // textBoxRating
            // 
            textBoxRating.Location = new Point(62, 419);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(50, 23);
            textBoxRating.TabIndex = 13;
            // 
            // textBoxActors
            // 
            textBoxActors.Location = new Point(64, 381);
            textBoxActors.Name = "textBoxActors";
            textBoxActors.Size = new Size(340, 23);
            textBoxActors.TabIndex = 14;
            // 
            // textBoxDirector
            // 
            textBoxDirector.Location = new Point(73, 344);
            textBoxDirector.Name = "textBoxDirector";
            textBoxDirector.Size = new Size(191, 23);
            textBoxDirector.TabIndex = 15;
            textBoxDirector.TextChanged += textBoxDirector_TextChanged;
            // 
            // FilmDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(572, 525);
            Controls.Add(textBoxDirector);
            Controls.Add(textBoxActors);
            Controls.Add(textBoxRating);
            Controls.Add(textBoxStudio);
            Controls.Add(buttonSave);
            Controls.Add(labelOpis);
            Controls.Add(buttonClose);
            Controls.Add(labelRatingg);
            Controls.Add(textBoxDescription);
            Controls.Add(labelActorss);
            Controls.Add(labelDirectorr);
            Controls.Add(labelStudioo);
            Controls.Add(labelYear);
            Controls.Add(labelGenre);
            Controls.Add(labelTitle);
            Controls.Add(pictureBoxPoster);
            Name = "FilmDetailsForm";
            Text = "FilmDetailsForm";
            Load += FilmDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPoster;
        private Label labelTitle;
        private Label labelGenre;
        private Label labelYear;
        private Label labelStudioo;
        private Label labelDirectorr;
        private Label labelActorss;
        private TextBox textBoxDescription;
        private Label labelRatingg;
        private Button buttonClose;
        private Label labelOpis;
        private Button buttonSave;
        private TextBox textBoxStudio;
        private TextBox textBoxRating;
        private TextBox textBoxActors;
        private TextBox textBoxDirector;
        private BindingSource filmBindingSource;
    }
}