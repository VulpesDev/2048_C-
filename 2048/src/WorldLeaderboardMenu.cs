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
    public partial class WorldLeaderboardMenu : UserControl
    {
        public WorldLeaderboardMenu()
        {
            InitializeComponent();
        }

        public async void LoadData()
        {
                API_connect connect = new();
                List<Highscore> data = await connect.GetLastTenScores();
                InsertDataInTable(data);
        }

        private void InsertDataInTable(List<Highscore> data)
        {
            int rows = tableLayoutPanel1.RowCount;
            int cols = tableLayoutPanel1.ColumnCount;

            for (int row = 1; row < rows; row++)
            {
                for (int col = 1; col < cols; col++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(col, row);
                    if (control is Label label && row - 1 < data.Count())
                    {
                        if (col == 1)
                            label.Text = data[row - 1].PlayerName;
                        else if (col == 2)
                            label.Text = data[row - 1].Score.ToString();
                    }
                    else
                    {
                    }
                }
            }
        }
    }
}
