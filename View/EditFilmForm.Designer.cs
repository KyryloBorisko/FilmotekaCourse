namespace FilmotekaCourse
{
    partial class EditFilmForm
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
            textBoxTitle2 = new TextBox();
            textBoxPosterPath2 = new TextBox();
            textBoxYear2 = new TextBox();
            textBoxGenre2 = new TextBox();
            buttonSave2 = new Button();
            buttonBrowse2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxTitle2
            // 
            textBoxTitle2.Location = new Point(73, 80);
            textBoxTitle2.Name = "textBoxTitle2";
            textBoxTitle2.Size = new Size(154, 23);
            textBoxTitle2.TabIndex = 0;
            textBoxTitle2.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPosterPath2
            // 
            textBoxPosterPath2.Location = new Point(290, 137);
            textBoxPosterPath2.Name = "textBoxPosterPath2";
            textBoxPosterPath2.ReadOnly = true;
            textBoxPosterPath2.Size = new Size(138, 23);
            textBoxPosterPath2.TabIndex = 1;
            // 
            // textBoxYear2
            // 
            textBoxYear2.Location = new Point(73, 195);
            textBoxYear2.Name = "textBoxYear2";
            textBoxYear2.Size = new Size(71, 23);
            textBoxYear2.TabIndex = 2;
            // 
            // textBoxGenre2
            // 
            textBoxGenre2.Location = new Point(79, 137);
            textBoxGenre2.Name = "textBoxGenre2";
            textBoxGenre2.Size = new Size(154, 23);
            textBoxGenre2.TabIndex = 3;
            // 
            // buttonSave2
            // 
            buttonSave2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave2.Location = new Point(319, 259);
            buttonSave2.Name = "buttonSave2";
            buttonSave2.Size = new Size(129, 44);
            buttonSave2.TabIndex = 4;
            buttonSave2.Text = "Зберегти";
            buttonSave2.UseVisualStyleBackColor = true;
            buttonSave2.Click += button1_Click;
            // 
            // buttonBrowse2
            // 
            buttonBrowse2.Location = new Point(321, 167);
            buttonBrowse2.Name = "buttonBrowse2";
            buttonBrowse2.Size = new Size(75, 23);
            buttonBrowse2.TabIndex = 5;
            buttonBrowse2.Text = "Огляд...";
            buttonBrowse2.UseVisualStyleBackColor = true;
            buttonBrowse2.Click += buttonBrowse2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(25, 83);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 6;
            label1.Text = "Назва:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(25, 140);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 7;
            label2.Text = "Жанри:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(41, 198);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 8;
            label3.Text = "Рік:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(309, 107);
            label4.Name = "label4";
            label4.Size = new Size(103, 17);
            label4.TabIndex = 9;
            label4.Text = "Постер фільму:";
            // 
            // EditFilmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(472, 326);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBrowse2);
            Controls.Add(buttonSave2);
            Controls.Add(textBoxGenre2);
            Controls.Add(textBoxYear2);
            Controls.Add(textBoxPosterPath2);
            Controls.Add(textBoxTitle2);
            Name = "EditFilmForm";
            Text = "EditFilmForm";
            Load += EditFilmForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle2;
        private TextBox textBoxPosterPath2;
        private TextBox textBoxYear2;
        private TextBox textBoxGenre2;
        private Button buttonSave2;
        private Button buttonBrowse2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}