using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        const int    minWinSize = Constants.MinWinSize;
        Size            prevSize   = new Size(0, 0);

        public int CountDigits(int number)
        {
            number = Math.Abs(number);
            if (number == 0)
            {
                return 1;
            }

            return (int)Math.Floor(Math.Log10(number)) + 1;
        }

        private void ResizeFontElements()
        {
            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(col, row);
                    if (control != null && control is Label label)
                    {
                        float newFontSize = this.Size.Width * Constants.BaseFontSizeMultiplier;
                        if (int.TryParse(label.Text, out int num))
                        {
                            int digitCount = CountDigits(num);
                            if (control.Text != " " && digitCount > 1)
                                newFontSize /= digitCount * Constants.DigitSizeReductionFactor;
                        }

                        control.Font = new Font(control.Font.FontFamily, newFontSize);
                    }
                }
            }
        }

        private void EqualizeWindowSize()
        {
            int newWindowSize = 0;

            if (this.Width != this.Height)
            {
                if (this.Size.Width < prevSize.Width || this.Size.Height < prevSize.Height)
                    newWindowSize = Math.Min(this.Width, this.Height);
                else
                    newWindowSize = Math.Max(this.Width, this.Height);

                this.Size = new Size(newWindowSize, newWindowSize);
            }
        }

        private void CheckMinWindowSize()
        {
            if (this.Width < minWinSize || this.Height < minWinSize)
                this.Size = new Size(Math.Max(this.Width, minWinSize), Math.Max(this.Height, minWinSize));
        }

        public static readonly Dictionary<int, LabelStyle> numberStyles = Constants.NumberStyles;

        private void PaintColorElements()
        {
            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(col, row);
                    if (control != null && control is Label label)
                    {
                        int number = 0;

                        if (label.Text != " " && int.TryParse(label.Text, out number))
                        {
                            if (label.Text != " ")
                                number = Convert.ToInt32(label.Text);
                        }

                        if (numberStyles.ContainsKey(number))
                        {
                            LabelStyle style = numberStyles[number];
                            label.ForeColor = style.ForegroundColor;
                            label.BackColor = style.BackgroundColor;
                            label.Font = style.Font;
                            if (label.Text == "0")
                                label.Text = " ";
                        }
                        else
                        {
                            label.ForeColor = Color.Black;
                            label.BackColor = SystemColors.Control;
                            label.Font = new Font("Arial", 16, FontStyle.Regular);
                        }
                    }
                }
            }
        }

        private void UI_Management()
        {
            PaintColorElements();
            ResizeFontElements();
            EqualizeWindowSize();
            CheckMinWindowSize();
        }
    }
}
