using _2048.src.Backend;
using _2048.src.Backend.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _2048.src
{
    public partial class FormGame : Form
    {
        private static int[][] dArr;


        #region ---------------- BACKEND FUNCTIONS ----------------

        /// <summary>
        /// Updates the TableLayoutPanel and all the lables by
        ///  referencing the int 2D array(the one the algorithm uses to calculate logic)
        /// </summary>
        /// <param name="labelValues"> The 2D int array </param>
        /// <param name="tableLayoutPanel"> The Table Layout Panel </param>
        public void WriteIntValuesToLabels(int[][] labelValues, TableLayoutPanel tableLayoutPanel)
        {
            Control control = null;
            int     rows    = tableLayoutPanel.RowCount;
            int     cols    = tableLayoutPanel.ColumnCount;

            if (labelValues.Length != rows)
                throw new ArgumentException("The number of rows in labelValues does not match the row count of tableLayoutPanel.");

            for (int row = 0; row < rows; row++)
            {
                if (labelValues[row].Length != cols)
                    throw new ArgumentException($"The number of columns in row {row} of labelValues does not match the column count of tableLayoutPanel.");

                for (int col = 0; col < cols; col++)
                {
                    control = tableLayoutPanel.GetControlFromPosition(col, row);
                    if (control is Label label)
                        label.Text = labelValues[row][col].ToString();
                }
            }
        }

        /// <summary>
        /// Reads from the TableLayoutPanel and out of it,
        ///  creates a replica as a 2D int array
        /// </summary>
        /// <param name="tableLayoutPanel"> The Table Layout Panel </param>
        /// <returns> 2D int array </returns>
        public static int[][] GetLabelValuesAsIntArray(TableLayoutPanel tableLayoutPanel)
        {
            Control control = null;
            int     rows    = tableLayoutPanel.RowCount;
            int     cols    = tableLayoutPanel.ColumnCount;
            int[][] result  = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                result[row] = new int[cols];

                for (int col = 0; col < cols; col++)
                {
                    control = tableLayoutPanel.GetControlFromPosition(col, row);
                    if (control is Label label)
                    {
                        if (int.TryParse(label.Text, out int value))
                            result[row][col] = value;
                        else
                            result[row][col] = 0;
                    }
                    else
                    {
                        result[row][col] = 0;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Handle input for the game and
        /// generate new values if the board has changed
        /// </summary>
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

            DrawFrontend();
        }
        #endregion


        #region ---------------- FRONTEND FUNCTIONS ----------------

        Size        prevSize   = new(0, 0);
        const int   minWinSize = Constants.MinWinSize;

        /// <summary>
        /// Count the digits of a number (ex. 202 = 3)
        /// </summary>
        public int CountDigits(int number)
        {
            number = Math.Abs(number);

            if (number == 0)
                return 1;
            return (int)Math.Floor(Math.Log10(number)) + 1;
        }

        /// <summary>
        /// Resizes the font of all the tiles so the user can see them at all times
        /// </summary>
        private void ResizeFontElements()
        {
            Control control     = null;
            int     digitCount  = 0;
            float   newFontSize = 0.0f;

            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    control = tableLayoutPanel1.GetControlFromPosition(col, row);

                    if (control != null && control is Label label)
                    {
                        newFontSize = control.Size.Width * Constants.BaseFontSizeMultiplier;

                        if (int.TryParse(label.Text, out int num))
                        {
                            digitCount = CountDigits(num);
                            if (control.Text != " " && digitCount > 1)
                                newFontSize /= digitCount * Constants.DigitSizeReductionFactor;
                        }
                        control.Font = new Font(control.Font.FontFamily, newFontSize);
                    }
                }
            }
        }

        /// <summary>
        /// Keeps the window in a square shape, design decision 
        /// </summary>
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

        /// <summary>
        /// Limits the minimum size of the window
        /// </summary>
        private void CheckMinWindowSize()
        {
            if (this.Width < minWinSize || this.Height < minWinSize)
                this.Size = new Size(Math.Max(this.Width, minWinSize), Math.Max(this.Height, minWinSize));
        }

        public static readonly Dictionary<int, LabelStyle> numberStyles = Constants.NumberStyles;

        /// <summary>
        /// Paint's foreground and background at the lables corresponding to
        ///  the constant dictionary in Constants.cs
        /// </summary>
        private void PaintColorElements()
        {
            Control     control = null;
            LabelStyle  style   = null;
            int         number  = 0;

            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    control = tableLayoutPanel1.GetControlFromPosition(col, row);
                    if (control != null && control is Label label)
                    {
                        if (label.Text != " " && int.TryParse(label.Text, out number))
                                number = Convert.ToInt32(label.Text);

                        if (numberStyles.ContainsKey(number))
                        {
                            style = numberStyles[number];
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
        public void DrawFrontend()
        {
            try
            {
                Score.WriteScoreValue(scoreValueLabel);
                WriteIntValuesToLabels(dArr, tableLayoutPanel1);
                UI_Management();
            }
            catch (Exception ex)
            {
                InfoPopup info = new InfoPopup(
                    "Draw Frontend Error",
                    ex.Message,
                    true);
            }
        }
        #endregion


        #region ---------------- FORM UTILITY ----------------

        public FormGame()
        {
            InitializeComponent();

            //Reduces flickering
            this.DoubleBuffered = true;
            //Disables fullscreen
            this.MaximizeBox = false;

            this.KeyDown += ActionsManage;

            //Initialization
            GameState gameState = GameManager.LoadGameState();
            if (gameState == null)
            {
                Score.SetScore(0);
                dArr = GetLabelValuesAsIntArray(tableLayoutPanel1);
                RandomGeneration.GenerateRandomEmptyCell(dArr);
                RandomGeneration.GenerateRandomEmptyCell(dArr);
            }
            else
            {
                dArr = gameState.Board;
                Score.SetScore(gameState.Score);
            }
            DrawFrontend();
        }

        private void FormGame_Resize(object sender, EventArgs e)
        {
            UI_Management();
        }

        private void FormGame_ResizeEnd(object sender, EventArgs e)
        {
             prevSize = this.Size;
        }

        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            GameState   game     = new(dArr, Score.GetScore());
            Form        formMenu = Application.OpenForms.OfType<FormMenu>().FirstOrDefault();

            GameManager.SaveGameState(game);
            API_connect.AddHighscore(FormMenu.GetUsername(), game.Score.ToString());

            if (formMenu != null)
                formMenu.Visible = true;
            else
                MessageBox.Show("Error occured! Could not find a running application.");
        }
        #endregion
    }
}
