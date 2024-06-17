using _2048.src;
using _2048.src.Backend;
using _2048.src.Backend.Database;
using dotenv.net;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Windows.Forms;

namespace _2048
{
    internal static class Program
    {
        public static HighscoreDataContext Context { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            InitializeContext();

            FormMenu formMenu = new FormMenu();
            Application.Run(formMenu);
        }

        private static void InitializeContext()
        {
            if (Context == null)
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string projectRootDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(baseDirectory, @"..\.."));
                Console.WriteLine($"Project root directory: {Path.Combine(projectRootDirectory, ".env")}");

                DotEnv.Fluent()
                    .WithExceptions()
                    .WithEnvFiles(Path.Combine(projectRootDirectory, ".env"))
                    .Load();
                string connection_string = DotEnv.Fluent()
                    .WithEnvFiles(Path.Combine(projectRootDirectory, ".env"))
                    .Read()["2048_CON_SECRET_VULPESDEV"];
                Console.WriteLine($"My secret value is: {connection_string}");
                if (Context == null)
                {
                    var optionsBuilder = new DbContextOptionsBuilder<HighscoreDataContext>();
                    optionsBuilder.UseMySql(connection_string, new MySqlServerVersion(new Version(8, 0, 28)));
                    Context = new HighscoreDataContext(optionsBuilder.Options);
                }
            }
        }
    }
}
