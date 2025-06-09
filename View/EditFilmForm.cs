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
    public partial class EditFilmForm : Form // клас
    {
        private int filmId; // поля
        private Film currentFilm; // поля
        public EditFilmForm(int id) // конструктор
        {
            InitializeComponent();
            filmId = id;

            currentFilm = Databasefilms.GetFilmById(filmId);

            textBoxTitle2.Text = currentFilm.Title;
            textBoxGenre2.Text = currentFilm.Genre;
            textBoxYear2.Text = currentFilm.Year;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // збереженя фільмів
        {
            currentFilm.Title = textBoxTitle2.Text;
            currentFilm.Year = textBoxYear2.Text;
            currentFilm.Genre = textBoxGenre2.Text;
            currentFilm.PosterPath = textBoxPosterPath2.Text;   

            Databasefilms.UpdateFilm(currentFilm);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void EditFilmForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBrowse2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxPosterPath2.Text = ofd.FileName;
                }
            }
        }
    }
}
