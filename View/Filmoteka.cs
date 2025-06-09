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
using FilmotekaCourse; 


namespace FilmotekaCourse
{
    public partial class Filmoteka : Form // клас 
    {
        private int currentPage = 0;
        private int filmsPerPage = 6;

        public Filmoteka() // конструктор
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(580, 300);
            this.Load += Filmoteka_Load; // обробник події завантаження форми (викликається метод Filmoteka_Load при завантаженні форми)
        }




        private void buttonBack_Click(object sender, EventArgs e) // обробник подій
        {
            this.Close();
        }

        private List<Film> allFilms = new List<Film>();


        private void flowLayoutPanelFilms_Paint(object sender, PaintEventArgs e) // панель виводу фільмів
        {

        }
        private void Filmoteka_Load(object sender, EventArgs e) // завантажує фільми з бази при відкритті форми
        {
            Databasefilms.InitializeDatabase();
            allFilms = Databasefilms.LoadAllFilms();
            DisplayFilms(allFilms);
        }

        private List<Film> GetFilteredFilms() // повертає фільми, які відповідають пошуковим фільтрам
        {
            string title = textBoxTitle.Text.ToLower().Trim();
            string genreInput = textBoxGenre.Text.ToLower().Trim().Replace(",", "");
            string year = textBoxYear.Text.Trim();

            var inputGenres = genreInput
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // жанри, які ввів користувач

            return allFilms.Where(f =>
                f.Title.ToLower().Contains(title) &&
                f.Year.Contains(year) &&
                inputGenres.All(inputGenre =>
                    f.Genre.ToLower()
                        .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Any(filmGenre => filmGenre.Contains(inputGenre))
                )
            ).ToList();
        }

        private void FilterFilms() //  показує тільки відфільтровані фільми
        {
            var filtered = GetFilteredFilms();
            DisplayFilms(filtered);
        }

        private void DisplayCurrentPage() // показує фільми лише на поточній сторінці
        {
            flowLayoutPanelFilms.Controls.Clear();

            int startIndex = currentPage * filmsPerPage;
            var filmsToDisplay = allFilms.Skip(startIndex).Take(filmsPerPage);

            foreach (var film in filmsToDisplay)
            {
                var filmControl = new FilmControl();
                filmControl.SetFilm(film);
                filmControl.FilmId = film.Id;

                filmControl.OnDeleteRequested += Card_OnDeleteRequested;

                filmControl.OnFilmUpdated += (s, e) =>
                {
                    allFilms = Databasefilms.LoadAllFilms();
                    DisplayCurrentPage();
                };

                flowLayoutPanelFilms.Controls.Add(filmControl);
            }
        }
        private void Card_OnFilmUpdated(object sender, EventArgs e) // 	Оновлює список фільмів після редагування
        {
            var films = Databasefilms.LoadAllFilms();
            DisplayFilms(films); 
        }

        private void DisplayFilms(List<Film> films) // 	Показує всі фільми у формі
        {
            flowLayoutPanelFilms.Controls.Clear();

            foreach (var film in films)
            {
                var card = new FilmControl();
                card.MovieTitle = film.Title;
                card.Genre = film.Genre;
                card.Year = film.Year;
                card.Poster = film.Poster;
                card.FilmId = film.Id;

                card.OnDeleteRequested += Card_OnDeleteRequested;
                card.OnFilmUpdated += (s, e) =>
                {
                    allFilms = Databasefilms.LoadAllFilms();
                    DisplayFilms(allFilms);
                };

                flowLayoutPanelFilms.Controls.Add(card);

            }
        }
        private void Card_OnDeleteRequested(object sender, int filmId) // Обробляє видалення фільму
        {
            Databasefilms.DeleteFilmById(filmId);

            // Перезавантажує фільми після видалення
            allFilms = Databasefilms.LoadAllFilms();
            DisplayFilms(allFilms);
        }


        private void Filmoteka_Load_1(object sender, EventArgs e)
        {

        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            FilterFilms();
        }

        private void textBoxGenre_TextChanged(object sender, EventArgs e)
        {
            FilterFilms();
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            FilterFilms();
        }

        private void buttonAdd_Click(object sender, EventArgs e) //  відкриває форму для додавання нового фільму
        {

            {
                var addForm = new AddFilmForm();
                addForm.ShowDialog();

                allFilms = Databasefilms.LoadAllFilms();
                DisplayFilms(allFilms);
            }

        }

        private void btnNext_Click(object sender, EventArgs e) // 	перемикає на наступну сторінку
        {
            int totalPages = (int)Math.Ceiling((double)allFilms.Count / filmsPerPage);
            if (currentPage < totalPages - 1)
            {
                currentPage++;
                DisplayCurrentPage();
            }
        }


        private void btnPrevious_Click(object sender, EventArgs e) //   перемикає на попередню сторінку
        {
            if (currentPage > 0)
            {
                currentPage--;
                DisplayCurrentPage();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e) // зберігає список фільмів у файл
        {
            var filteredFilms = GetFilteredFilms();

            if (filteredFilms.Count == 0)
            {
                MessageBox.Show("Немає фільмів для збереження.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt";
            saveFileDialog.Title = "Зберегти список фільмів";
            saveFileDialog.FileName = "films.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var film in filteredFilms)
                    {
                        writer.WriteLine($"{film.Title} ({film.Year}) - {film.Genre}");
                    }
                }

                MessageBox.Show("Список збережено!", "Успіх");
            }
        }


    }
}

