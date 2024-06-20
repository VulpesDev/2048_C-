using _2048.src.Backend;
using System;
using System.Windows.Forms;

namespace _2048.src
{
    public partial class NewGameMessageBox : Form
    {
        public NewGameMessageBox()
        {
            InitializeComponent();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            GameManager.DeleteSave();
            GameManager.StartGame();
            this.Close();
        }

        private void buttonLoadGame_Click(object sender, EventArgs e)
        {
            GameManager.StartGame();
            this.Close();
        }
    }
}
