using _2048.src.Backend;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048.src
{
    public partial class FormMenu : Form
    {
        private static string username;
        public FormMenu()
        {
            InitializeComponent();
        }

        public static string GetUsername()
        {
            return username;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            if (username == null || username == "" || username == " ")
            {
                username = "Anonymous";
                Console.WriteLine($"name :({username})");
            }
            GameState gameState = GameManager.LoadGameState();
            if (gameState != null)
            {
                NewGameMessageBox newGameMessageBox = new NewGameMessageBox();
                newGameMessageBox.ShowDialog();
            }
            else
                GameManager.StartGame();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            panelWorldLeaderboard.Location = new Point(0, 0);
            panelWorldLeaderboard.Visible  = false;
        }

        private void FormMenu_Shown(object sender, EventArgs e)
        {
            if (GameManager.LoadGameState() != null)
                GameManager.StartGame();
        }

        private void buttonWHScore_Click(object sender, EventArgs e)
        {
            panelWorldLeaderboard.Show();
            try
            {
                worldLeaderboardMenu1.LoadData();
            }
            catch (Exception ex)
            {
                InfoPopup info = new(
                    "Load data error",
                    ex.Message,
                    true);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelWorldLeaderboard.Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

            if (!allowedChars.Contains(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            worldLeaderboardMenu1.LoadTopTen();
        }

        private void buttonLatest_Click(object sender, EventArgs e)
        {
            worldLeaderboardMenu1.LoadLastTen();
        }

    }
}
