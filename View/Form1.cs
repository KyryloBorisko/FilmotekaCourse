namespace FilmotekaCourse
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(580, 300);
        }

        private void buttonFilm_Click(object sender, EventArgs e) //  відкриває форму 
        {
            Filmoteka filmoteka = new Filmoteka();
            this.Hide();
            filmoteka.ShowDialog();
            this.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e) // закриває форму
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
