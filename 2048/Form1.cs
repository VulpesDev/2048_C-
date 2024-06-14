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
        Dictionary<int, LabelStyle> numberStyles = new Dictionary<int, LabelStyle>()
        {
            { 0, new LabelStyle(Color.FromArgb(0, 0, 0), Color.FromArgb(205, 193, 180), new Font("Arial", 55, FontStyle.Bold)) },
            { 2, new LabelStyle(Color.FromArgb(119, 110, 101), Color.FromArgb(238, 228, 218), new Font("Arial", 55, FontStyle.Bold)) },
            { 4, new LabelStyle(Color.FromArgb(119, 110, 101), Color.FromArgb(237, 224, 200), new Font("Arial", 55, FontStyle.Bold)) },
            { 8, new LabelStyle(Color.FromArgb(249, 246, 242), Color.FromArgb(242, 177, 121), new Font("Arial", 55, FontStyle.Bold)) },
            { 16, new LabelStyle(Color.FromArgb(249, 246, 242), Color.FromArgb(245, 149, 99), new Font("Arial", 50, FontStyle.Bold)) },
            { 32, new LabelStyle(Color.FromArgb(249, 246, 242), Color.FromArgb(246, 124, 95), new Font("Arial", 50, FontStyle.Bold)) },
            { 64, new LabelStyle(Color.FromArgb(249, 246, 242), Color.FromArgb(246, 94, 59), new Font("Arial", 50, FontStyle.Bold)) },
            { 128, new LabelStyle(Color.FromArgb(249, 246, 242), Color.FromArgb(237, 207, 114), new Font("Arial", 40, FontStyle.Bold)) },
            { 256, new LabelStyle(Color.FromArgb(249, 246, 242), Color.FromArgb(237, 204, 97), new Font("Arial", 40, FontStyle.Bold)) },
            { 512, new LabelStyle(Color.FromArgb(249, 246, 242), Color.FromArgb(237, 200, 80), new Font("Arial", 40, FontStyle.Bold)) },
            { 1024, new LabelStyle(Color.FromArgb(249, 246, 242), Color.FromArgb(237, 197, 63), new Font("Arial", 30, FontStyle.Bold)) },
            { 2048, new LabelStyle(Color.FromArgb(249, 246, 242), Color.FromArgb(237, 194, 46), new Font("Arial", 30, FontStyle.Bold)) },
        };

        public Form1()
        {
            InitializeComponent();

            //Reduces flickering
            this.DoubleBuffered = true;
            //Disables fullscreen
            this.MaximizeBox = false;

        }

        private void ResizeFontElements()
        {
            float newFontSize = this.Size.Width < this.Size.Height ? this.Size.Width * 0.08f : this.Size.Height * 0.08f;
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

        private void CheckMinWindowSize( int minWinSize )
        {
            if (this.Width < minWinSize || this.Height < minWinSize)
            {
                this.Size = new Size(Math.Max(this.Width, minWinSize), Math.Max(this.Height, minWinSize));
            }
        }

        private void PaintColorElements()
        {
            Label label;
            int number;

            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(col, row);
                    if (control != null && control is Label)
                    {
                        label = control as Label;
                        number = Convert.ToInt16(label.Text);

                        if (numberStyles.ContainsKey(number))
                        {
                            LabelStyle style = numberStyles[number];
                            label.ForeColor = style.ForegroundColor;
                            label.BackColor = style.BackgroundColor;
                            label.Font = style.Font;
                            label.Text = number.ToString(); // Update label text to the number
                        }
                        else
                        {
                            // Default style if number not found
                            label.ForeColor = Color.Black;
                            label.BackColor = SystemColors.Control;
                            label.Font = new Font("Arial", 16, FontStyle.Regular);
                            label.Text = number.ToString(); // Update label text to the number
                        }
                    }
                }
            }
        }

        private void UI_Management()
        {
            int minWinSize = 350;

            PaintColorElements();
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
            //UI_Management();
             prevSize = this.Size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UI_Management();
        }
    }
}
