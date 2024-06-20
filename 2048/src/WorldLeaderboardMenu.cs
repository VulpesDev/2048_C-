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

        public void LoadData()
        {
            LoadTopTen();
        }

        public async void LoadTopTen()
        {
            List<Highscore> data = await API_connect.GetTopTenScores();

            InsertDataInTable(data);
        }

        public async void LoadLastTen()
        {
            List<Highscore> data = await API_connect.GetLastTenScores();

            InsertDataInTable(data);
        }

        private void InsertDataInTable(List<Highscore> data)
        {
            Control control = null;
            int     rows    = tableLayoutPanel1.RowCount;
            int     cols    = tableLayoutPanel1.ColumnCount;
            
            if (data == null)
                return;

            for (int row = 1; row < rows; row++)
            {
                for (int col = 1; col < cols; col++)
                {
                    control = tableLayoutPanel1.GetControlFromPosition(col, row);
                    if (control is Label label && row - 1 < data.Count())
                    {
                        if (col == 1)
                            label.Text = data[row - 1].PlayerName;
                        else if (col == 2)
                            label.Text = data[row - 1].Score.ToString();
                    }
                    else
                    {
                        //just don't display anything
                    }
                }
            }
        }
    }
}
