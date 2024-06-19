using _2048.src.Backend;
using _2048.src.Backend.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048.src
{
    public partial class FormMenu : Form
    {
        public static string username;
        public FormMenu()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NewGameMessageBox newGameMessageBox = new NewGameMessageBox();
            newGameMessageBox.ShowDialog();

            username = textBox1.Text;
            if (username == null || username == "" || username == " ")
            {
                username = "Anonymous";
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            panelWorldLeaderboard.Location = new Point(0, 0);
            panelWorldLeaderboard.Visible = false;
        }

        private void FormMenu_Shown(object sender, EventArgs e)
        {
            if (GameManager.LoadGameState() != null)
            {
                GameManager.StartGame();
            }
        }

        private void buttonHScore_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Hey");
        }

        private void buttonWHScore_Click(object sender, EventArgs e)
        {
            panelWorldLeaderboard.Show();
            worldLeaderboardMenu1.LoadData();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelWorldLeaderboard.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";
            if (!allowedChars.Contains(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
