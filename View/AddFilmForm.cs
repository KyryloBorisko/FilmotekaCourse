using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmotekaCourse
{
    public partial class AddFilmForm : Form
    {
        public AddFilmForm() // конструктор
        {
            InitializeComponent();
        }
        // обробники подій:
        private void button2_Click(object sender, EventArgs e)
        {

            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxPosterPath.Text = ofd.FileName;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                var film = new Film
                {
                    Title = textBoxTitle.Text,
                    Genre = textBoxGenre.Text,
                    Year = textBoxYear.Text,
                    PosterPath = textBoxPosterPath.Text
                };

                Databasefilms.AddFilmToDatabase(film);
                MessageBox.Show("Фільм додано!");
                this.Close();
            }

        }

        private void AddFilmForm_Load(object sender, EventArgs e)
        {

        }
    }
}
