using _2048.src.Backend;
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
            Form1 form1 = new Form1();
            Application.Run(form1);
            GameState game = new GameState();
            game.Board = Form1.dArr;
            game.Score = Score.GetScore();
            GameManager.SaveGameState(game);
        }
    }
}
