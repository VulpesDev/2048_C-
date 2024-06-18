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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //InitializeContext();

            FormMenu formMenu = new FormMenu();
            Application.Run(formMenu);
        }

    }
}
