using System.Data.SQLite;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using FilmotekaCourse;
//поля + методи
public static class Databasefilms
{    //  для підключення до бази
    private static string dbPath = "films.db";
    private static string connectionString = "Data Source=films.db;Version=3;BusyTimeout=5000;";
    private static readonly object dbLock = new object(); 

    public static void EnableWALMode() // режим WAL для покращення продуктивності
    {
        lock (dbLock)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("PRAGMA journal_mode=WAL;", conn))
                {
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }

    public static Film GetFilmById(int id) // завантаження фільмів з бази за ID, sqlite зчитування даних з таблиці Films
    {
        lock (dbLock)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Films WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string path = reader["PosterPath"].ToString();
                    return new Film
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Title = reader["Title"].ToString(),
                        Genre = reader["Genre"].ToString(),
                        Year = reader["Year"].ToString(),
                        PosterPath = path,
                        Poster = null,

                        // 🧠 додано:
                        Studio = reader["Studio"].ToString(),
                        Director = reader["Director"].ToString(),
                        Actors = reader["Actors"].ToString(),
                        Description = reader["Description"].ToString(),
                        Rating = reader["Rating"].ToString()
                    };
                }
            }
        }
        return null;
    }

    public static void UpdateFilm(Film film) // онвлює дані фільму в базі
    {
        lock (dbLock)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sql = @"UPDATE Films SET 
                Title = @title, 
                Genre = @genre, 
                Year = @year, 
                PosterPath = @poster, 
                Studio = @studio, 
                Director = @director, 
                Actors = @actors, 
                Description = @description, 
                Rating = @rating 
                WHERE Id = @id";

                using (var cmd = new SQLiteCommand(sql, conn)) 
                {
                    cmd.Parameters.AddWithValue("@title", film.Title);
                    cmd.Parameters.AddWithValue("@genre", film.Genre);
                    cmd.Parameters.AddWithValue("@year", film.Year);
                    cmd.Parameters.AddWithValue("@poster", film.PosterPath);
                    cmd.Parameters.AddWithValue("@studio", film.Studio);
                    cmd.Parameters.AddWithValue("@director", film.Director);
                    cmd.Parameters.AddWithValue("@actors", film.Actors);
                    cmd.Parameters.AddWithValue("@description", film.Description);
                    cmd.Parameters.AddWithValue("@rating", film.Rating);
                    cmd.Parameters.AddWithValue("@id", film.Id);

                    int affected = cmd.ExecuteNonQuery();
                 
                }
            }
        }
    }




    public static void InitializeDatabase() // 	cтворення бази та таблиці, якщо їх ще не існує
    {
        lock (dbLock)
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"
                    CREATE TABLE Films (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Title TEXT NOT NULL,
                        Genre TEXT NOT NULL,
                        Year TEXT NOT NULL,
                        PosterPath TEXT NOT NULL
                    );";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
    public static void AddFilmToDatabase(Film film) // додає новий фільм у базу
    {
        lock (dbLock)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sql = @"INSERT INTO Films 
            (Title, Genre, Year, PosterPath, Studio, Director, Actors, Description, Rating)
            VALUES 
            (@title, @genre, @year, @poster, @studio, @director, @actors, @description, @rating)";

                var cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@title", film.Title);
                cmd.Parameters.AddWithValue("@genre", film.Genre);
                cmd.Parameters.AddWithValue("@year", film.Year);
                cmd.Parameters.AddWithValue("@poster", film.PosterPath);
                cmd.Parameters.AddWithValue("@studio", film.Studio);
                cmd.Parameters.AddWithValue("@director", film.Director);
                cmd.Parameters.AddWithValue("@actors", film.Actors);
                cmd.Parameters.AddWithValue("@description", film.Description);
                cmd.Parameters.AddWithValue("@rating", film.Rating);

                cmd.ExecuteNonQuery();
            }
        }
    }

    public static void DeleteFilmById(int id) // видаляє фільм з бази за ID
    {
        lock (dbLock)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Films WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }


    public static List<Film> LoadAllFilms() // завантажує всі фільми з бази у список
    {
        var films = new List<Film>();

        lock (dbLock)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Films", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    films.Add(new Film
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Title = reader["Title"].ToString(),
                        Genre = reader["Genre"].ToString(),
                        Year = reader["Year"].ToString(),
                        PosterPath = reader["PosterPath"].ToString(),
                        Poster = null, 
                        Studio = reader["Studio"].ToString(),
                        Director = reader["Director"].ToString(),
                        Actors = reader["Actors"].ToString(),
                        Description = reader["Description"].ToString(),
                        Rating = reader["Rating"].ToString()
                    });
                }
            }

            
            foreach (var film in films) // завантажує постер для кожного фільму з його збереженого шляху PosterPath у властивість Poster
            {
                if (File.Exists(film.PosterPath))
                {
                    try
                    {
                        using (var stream = new FileStream(film.PosterPath, FileMode.Open, FileAccess.Read))
                        {
                            film.Poster = new Bitmap(stream);
                        }
                    }
                    catch
                    {
                        film.Poster = null;
                    }
                }
            }
        }

        return films;
    }
}

