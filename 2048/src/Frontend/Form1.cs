using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        int[][] dArr;

        public void DrawImage()
        {
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
        public Form1()
        {
            InitializeComponent();

            //Reduces flickering
            this.DoubleBuffered = true;
            //Disables fullscreen
            this.MaximizeBox = false;
            this.KeyDown += ActionsManage;
            dArr = GetLabelValuesAsIntArray(tableLayoutPanel1);
            RandomGeneration.GenerateRandomEmptyCell(dArr);
            RandomGeneration.GenerateRandomEmptyCell(dArr);
            DrawImage();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            UI_Management();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            //UI_Management();
             prevSize = this.Size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
