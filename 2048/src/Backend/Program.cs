using _2048.src;
using System;
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

            FormMenu formMenu = new();
            Application.Run(formMenu);
        }

    }
}
