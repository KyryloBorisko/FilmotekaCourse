using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmotekaCourse

{
    public partial class FilmDetailsForm : Form
    {
        private FilmotekaCourse.Film film;
        public FilmDetailsForm(Film selectedFilm) // конструктор, приймає фільм і ініціалізує форму, щоб показати його деталі.
        {
            InitializeComponent();
            film = selectedFilm;
            ShowFilmDetails();
        }

        private void ShowFilmDetails() // встановлює значення полів форми відповідно до властивостей об'єкта
        {
            labelTitle.Text = film.Title;
            labelGenre.Text = "Жанр: " + film.Genre;
            labelYear.Text = "Рік: " + film.Year;
            textBoxStudio.Text = film.Studio;
            textBoxDirector.Text = film.Director;
            textBoxActors.Text = film.Actors;
            textBoxDescription.Text = film.Description;
            textBoxRating.Text = film.Rating;

            if (film.Poster != null)
                pictureBoxPoster.Image = new Bitmap(film.Poster);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

            film.Studio = textBoxStudio.Text;
            film.Director = textBoxDirector.Text;
            film.Actors = textBoxActors.Text;
            film.Description = textBoxDescription.Text;
            film.Rating = textBoxRating.Text;

            Databasefilms.UpdateFilm(film);
            

            MessageBox.Show("Фільм оновлено успішно!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            FilmInfoUpdated?.Invoke(this, EventArgs.Empty);
            this.Close();

        }

        private void FilmDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxPoster_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelRating_Click(object sender, EventArgs e)
        {

        }
        public event EventHandler FilmInfoUpdated;

        private void textBoxDirector_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStudio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
