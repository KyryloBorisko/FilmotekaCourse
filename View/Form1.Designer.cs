namespace FilmotekaCourse
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
            buttonFilm = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonFilm
            // 
            buttonFilm.BackColor = SystemColors.MenuBar;
            buttonFilm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFilm.Location = new Point(235, 142);
            buttonFilm.Name = "buttonFilm";
            buttonFilm.Size = new Size(184, 62);
            buttonFilm.TabIndex = 0;
            buttonFilm.Text = "ФІЛЬМОТЕКА";
            buttonFilm.UseVisualStyleBackColor = false;
            buttonFilm.Click += buttonFilm_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.Menu;
            buttonExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExit.Location = new Point(235, 243);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(184, 62);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "ВИХІД";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(686, 402);
            Controls.Add(buttonExit);
            Controls.Add(buttonFilm);
            Name = "Form1";
            Text = "Фільмотека";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button buttonExit;
        private Button buttonFilm;
    }
}
