namespace FilmotekaCourse
{
    public partial class FilmControl : UserControl
    {

        public FilmControl() // 	Конструктор	Ініціалізує компонент
        {
            InitializeComponent();
        }
        public void SetFilm(Film film) // Метод Присвоює дані картці
        {
            lblTitle.Text = film.Title;
            lblGenre.Text = film.Genre;
            lblYear.Text = film.Year;
            if (film.Poster != null)
                pictureBoxPoster.Image = new Bitmap(film.Poster);
        }
        public string MovieTitle // властивість 
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }
        public string Genre // властивість
        {
            get => lblGenre.Text;
            set => lblGenre.Text = value;
        }
        public string Year // властивість
        {
            get => lblYear.Text;
            set => lblYear.Text = value;
        }
        public Image Poster
        {
            get => pictureBoxPoster.Image;
            set
            {
                if (pictureBoxPoster.Image != null)
                    pictureBoxPoster.Image.Dispose();

                pictureBoxPoster.Image = value != null ? new Bitmap(value) : null;
            }
        }

        public int FilmId { get; set; }

        public event EventHandler<int> OnDeleteRequested; // Подія	Сповіщає інші компоненти

        private void FilmControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxDelete_Click(object sender, EventArgs e) // Обробник події
        {
            var result = MessageBox.Show("Ви точно хочете видалити фільм?", "Підтвердження", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                OnDeleteRequested?.Invoke(this, FilmId);
            }
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            var editForm = new EditFilmForm(FilmId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {

                OnFilmUpdated?.Invoke(this, EventArgs.Empty);
            }
        }


        private void pictureBoxPoster_Click(object sender, EventArgs e)
        {
            var film = Databasefilms.GetFilmById(FilmId);
            film.Poster = this.Poster;

            var detailsForm = new FilmDetailsForm(film);

            // 🔔 Обробка події оновлення
            detailsForm.FilmInfoUpdated += (s, e) =>
            {
                OnFilmUpdated?.Invoke(this, EventArgs.Empty); // 
            };

            detailsForm.ShowDialog();
        }

        private void FilmControl_Load_1(object sender, EventArgs e)
        {

        }

        public event EventHandler OnFilmUpdated;
    }
}
