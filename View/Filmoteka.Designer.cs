namespace FilmotekaCourse
{
    partial class Filmoteka
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
            buttonBack = new Button();
            flowLayoutPanelFilms = new FlowLayoutPanel();
            textBoxTitle = new TextBox();
            labelNazva = new Label();
            labelJanr = new Label();
            textBoxGenre = new TextBox();
            label2 = new Label();
            textBoxYear = new TextBox();
            buttonAdd = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            buttonExport = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonBack.Location = new Point(12, 397);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(120, 43);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // flowLayoutPanelFilms
            // 
            flowLayoutPanelFilms.AutoSize = true;
            flowLayoutPanelFilms.Location = new Point(0, 92);
            flowLayoutPanelFilms.Name = "flowLayoutPanelFilms";
            flowLayoutPanelFilms.Size = new Size(808, 253);
            flowLayoutPanelFilms.TabIndex = 1;
            flowLayoutPanelFilms.Paint += flowLayoutPanelFilms_Paint;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(68, 16);
            textBoxTitle.Multiline = true;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(100, 25);
            textBoxTitle.TabIndex = 2;
            textBoxTitle.TextChanged += textBoxTitle_TextChanged;
            // 
            // labelNazva
            // 
            labelNazva.AutoSize = true;
            labelNazva.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelNazva.Location = new Point(12, 17);
            labelNazva.Name = "labelNazva";
            labelNazva.RightToLeft = RightToLeft.No;
            labelNazva.Size = new Size(55, 20);
            labelNazva.TabIndex = 3;
            labelNazva.Text = "Назва:";
            // 
            // labelJanr
            // 
            labelJanr.AutoSize = true;
            labelJanr.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelJanr.Location = new Point(193, 17);
            labelJanr.Name = "labelJanr";
            labelJanr.RightToLeft = RightToLeft.No;
            labelJanr.Size = new Size(53, 20);
            labelJanr.TabIndex = 4;
            labelJanr.Text = "Жанр:";
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(248, 16);
            textBoxGenre.Multiline = true;
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(100, 25);
            textBoxGenre.TabIndex = 5;
            textBoxGenre.TextChanged += textBoxGenre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(379, 17);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(35, 20);
            label2.TabIndex = 6;
            label2.Text = "Рік:";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(416, 16);
            textBoxYear.Multiline = true;
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(100, 25);
            textBoxYear.TabIndex = 7;
            textBoxYear.TextChanged += textBoxYear_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(674, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(122, 34);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Додати фільм";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // btnNext
            // 
            btnNext.Cursor = Cursors.PanEast;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(738, 397);
            btnNext.Name = "btnNext";
            btnNext.RightToLeft = RightToLeft.No;
            btnNext.Size = new Size(38, 43);
            btnNext.TabIndex = 9;
            btnNext.Text = "->";
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Cursor = Cursors.PanWest;
            btnPrevious.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevious.Location = new Point(694, 397);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.RightToLeft = RightToLeft.Yes;
            btnPrevious.Size = new Size(38, 43);
            btnPrevious.TabIndex = 10;
            btnPrevious.Text = "->";
            btnPrevious.TextAlign = ContentAlignment.MiddleLeft;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // buttonExport
            // 
            buttonExport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExport.Location = new Point(546, 12);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(122, 34);
            buttonExport.TabIndex = 11;
            buttonExport.Text = "Зберегти список";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // Filmoteka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(808, 452);
            Controls.Add(buttonExport);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxYear);
            Controls.Add(label2);
            Controls.Add(textBoxGenre);
            Controls.Add(labelJanr);
            Controls.Add(labelNazva);
            Controls.Add(textBoxTitle);
            Controls.Add(flowLayoutPanelFilms);
            Controls.Add(buttonBack);
            Name = "Filmoteka";
            Text = "Filmoteka";
            Load += Filmoteka_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private FlowLayoutPanel flowLayoutPanelFilms;
        private TextBox textBoxTitle;
        private Label labelNazva;
        private Label labelJanr;
        private TextBox textBoxGenre;
        private Label label2;
        private TextBox textBoxYear;
        private Button buttonAdd;
        private Button btnNext;
        private Button btnPrevious;
        private Button buttonExport;
    }
    }