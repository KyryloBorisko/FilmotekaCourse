using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmotekaCourse
{
    public class Film
    {
        // структура для зберігання інформації про фільм.
        public int Id { get; set; } // ID фільму
        public string Title { get; set; } // назва
        public string Genre { get; set; } // жанр
        public string Year { get; set; }     // рік
        public Image Poster { get; set; }        // постер
        public string PosterPath { get; set; }    // шлях до постера
        public string Studio { get; set; }        // студія
        public string Director { get; set; }      // режисер
        public string Actors { get; set; }        // актори
        public string Description { get; set; }   // короткий зміст
        public string Rating { get; set; } // рейтинг

    }
}
