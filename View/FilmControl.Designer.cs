namespace FilmotekaCourse
{
    partial class FilmControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmControl));
            lblTitle = new Label();
            pictureBoxPoster = new PictureBox();
            lblYear = new Label();
            lblGenre = new Label();
            pictureBoxDelete = new PictureBox();
            pictureBoxEdit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ControlText;
            lblTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(2, 166);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Назва фільму";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPoster
            // 
            pictureBoxPoster.Cursor = Cursors.Hand;
            pictureBoxPoster.Dock = DockStyle.Top;
            pictureBoxPoster.Location = new Point(0, 0);
            pictureBoxPoster.Name = "pictureBoxPoster";
            pictureBoxPoster.Size = new Size(128, 161);
            pictureBoxPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPoster.TabIndex = 1;
            pictureBoxPoster.TabStop = false;
            pictureBoxPoster.Click += pictureBoxPoster_Click;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblYear.ForeColor = SystemColors.Control;
            lblYear.Location = new Point(2, 183);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(23, 15);
            lblYear.TabIndex = 2;
            lblYear.Text = "Рік";
            lblYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblGenre.ForeColor = SystemColors.Control;
            lblGenre.Location = new Point(2, 199);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(38, 15);
            lblGenre.TabIndex = 3;
            lblGenre.Text = "Жанр";
            lblGenre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxDelete
            // 
            pictureBoxDelete.Cursor = Cursors.Hand;
            pictureBoxDelete.Image = Properties.Resources.free_icon_delete_6861362;
            pictureBoxDelete.Location = new Point(107, 220);
            pictureBoxDelete.Name = "pictureBoxDelete";
            pictureBoxDelete.Size = new Size(18, 19);
            pictureBoxDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDelete.TabIndex = 4;
            pictureBoxDelete.TabStop = false;
            pictureBoxDelete.Click += pictureBoxDelete_Click;
            // 
            // pictureBoxEdit
            // 
            pictureBoxEdit.Cursor = Cursors.Hand;
            pictureBoxEdit.Image = (Image)resources.GetObject("pictureBoxEdit.Image");
            pictureBoxEdit.Location = new Point(83, 220);
            pictureBoxEdit.Name = "pictureBoxEdit";
            pictureBoxEdit.Size = new Size(18, 19);
            pictureBoxEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEdit.TabIndex = 5;
            pictureBoxEdit.TabStop = false;
            pictureBoxEdit.Click += pictureBoxEdit_Click;
            // 
            // FilmControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pictureBoxEdit);
            Controls.Add(pictureBoxDelete);
            Controls.Add(lblGenre);
            Controls.Add(lblYear);
            Controls.Add(pictureBoxPoster);
            Controls.Add(lblTitle);
            Name = "FilmControl";
            Size = new Size(128, 243);
            Load += FilmControl_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pictureBoxPoster;
        private Label lblYear;
        private Label lblGenre;
        private PictureBox pictureBoxDelete;
        private PictureBox pictureBoxEdit;
    }
}
