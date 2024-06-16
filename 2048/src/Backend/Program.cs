using _2048.src;
using _2048.src.Backend;
using _2048.src.Backend.Database;
using Microsoft.EntityFrameworkCore;
using System;
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
                var optionsBuilder = new DbContextOptionsBuilder<HighscoreDataContext>();
                optionsBuilder.UseMySql("server=localhost;port=3306;database=2048_VulpesDev;user=root;password=123321",
                                        new MySqlServerVersion(new Version(8, 0, 28)));

                Context = new HighscoreDataContext(optionsBuilder.Options);
            }
        }
    }
}
