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
        Size prevSize;

        public Form1()
        {
            InitializeComponent();

            //Reduces flickering
            this.DoubleBuffered = true;
        }

        private void ResizeFontElements()
        {
            float newFontSize = this.Size.Width < this.Size.Height ? this.Size.Width * 0.1f : this.Size.Height * 0.1f;
            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(col, row);
                    if (control != null && control is Label)
                    {
                        control.Font = new Font(control.Font.FontFamily, newFontSize);
                    }
                }
            }
        }

        private void EqualizeWindowSize()
        {
            if (this.Width != this.Height)
            {
                int newWindowSize = 0;
                if (this.Size.Width < prevSize.Width || this.Size.Height < prevSize.Height)
                    newWindowSize = Math.Min(this.Width, this.Height);
                else
                    newWindowSize = Math.Max(this.Width, this.Height);

                this.Size = new Size(newWindowSize, newWindowSize);
            }
        }

        private void CheckMinWindowSize( int minWinSize)
        {
            if (this.Width < minWinSize || this.Height < minWinSize)
            {
                this.Size = new Size(Math.Max(this.Width, minWinSize), Math.Max(this.Height, minWinSize));
            }
        }

        private void UI_Management()
        {
            int minWinSize = 350;

            ResizeFontElements();
            EqualizeWindowSize();
            CheckMinWindowSize(minWinSize);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            UI_Management();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            prevSize = this.Size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UI_Management();
        }
    }
}
