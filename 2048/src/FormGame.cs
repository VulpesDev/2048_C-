using _2048.src;
using _2048.src.Backend;
using _2048.src.Backend.Database;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _2048
{
    public partial class FormGame : Form
    {
        public static int[][] dArr;
        public static string username;

        public void DrawImage()
        {
            WriteScoreValue(scoreValueLabel);
            WriteIntValuesToLabels(dArr, tableLayoutPanel1);
            UI_Management();
        }

        public void ActionsManage(object sender, KeyEventArgs e)
        {
            bool changed = false;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (Algorithm.VericalManage(dArr, false))
                        changed = true;
                    break;
                case Keys.Down:
                    if (Algorithm.VericalManage(dArr, true))
                        changed = true;
                    break;
                case Keys.Right:
                    if (Algorithm.HorizontalManage(dArr, true))
                        changed = true;
                    break;
                case Keys.Left:
                    if (Algorithm.HorizontalManage(dArr, false))
                        changed = true;
                    break;
                default:
                    break;
            }
            if (changed)
                RandomGeneration.GenerateRandomEmptyCell(dArr);
            DrawImage();
        }
        public FormGame()
        {
            InitializeComponent();

            //Reduces flickering
            this.DoubleBuffered = true;
            //Disables fullscreen
            this.MaximizeBox = false;

            this.KeyDown += ActionsManage;

            //Initialization
            
            GameState gameState = GameManager.LoadGameState();
            if (gameState == null)
            {
                Score.SetScore(0);
                dArr = GetLabelValuesAsIntArray(tableLayoutPanel1);
                RandomGeneration.GenerateRandomEmptyCell(dArr);
                RandomGeneration.GenerateRandomEmptyCell(dArr);
            }
            else
            {
                dArr = gameState.Board;
                Score.SetScore(gameState.Score);
            }
            DrawImage();
        }

        private void FormGame_Resize(object sender, EventArgs e)
        {
            UI_Management();
        }

        private void FormGame_ResizeEnd(object sender, EventArgs e)
        {
             prevSize = this.Size;
        }

        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            GameState game = new GameState();
            game.Board = dArr;
            game.Score = Score.GetScore();
            //HighscoreDataAccess.AddHighscore(FormMenu.username, game.Score);
            Highscore newHighscore = new();
            newHighscore.PlayerName = FormMenu.username;
            newHighscore.Score = game.Score;
            API_connect.AddHighscore(FormMenu.username, game.Score.ToString());

            GameManager.SaveGameState(game);
            Form formMenu = Application.OpenForms.OfType<FormMenu>().FirstOrDefault();

            if (formMenu != null)
            {
                formMenu.Visible = true;
            }
            else
            {
                MessageBox.Show("Error occured! Could not find a running application.");
            }
        }
    }
}
