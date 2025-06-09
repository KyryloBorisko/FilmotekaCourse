namespace FilmotekaCourse
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Databasefilms.InitializeDatabase();  // якщо треба
            Databasefilms.EnableWALMode();       // ← Увімкнення WAL перед запуском
        }
    }
}