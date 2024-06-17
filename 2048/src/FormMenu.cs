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
        public FormMenu()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GameManager.LoadGameState() != null)
            {
                NewGameMessageBox newGameMessageBox = new NewGameMessageBox();
                newGameMessageBox.ShowDialog();
            }
            else
            {
                GameManager.StartGame();
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
            Console.WriteLine("Hey");
        }

        private void buttonWHScore_Click(object sender, EventArgs e)
        {
            panelWorldLeaderboard.Visible = true;
        }
    }
}
