using _2048.src.Backend;
using System;
using System.Windows.Forms;

namespace _2048
{
    public partial class FormGame : Form
    {
        /// <summary>
        /// Updates the TableLayoutPanel and all the lables by
        ///  referencing the int 2D array(the one the algorithm uses to calculate logic)
        /// </summary>
        /// <param name="labelValues"> The 2D int array </param>
        /// <param name="tableLayoutPanel"> The Table Layout Panel </param>
        /// <exception cref="ArgumentException"></exception>
        public void WriteIntValuesToLabels(int[][] labelValues, TableLayoutPanel tableLayoutPanel)
        {
            int rows = tableLayoutPanel.RowCount;
            int cols = tableLayoutPanel.ColumnCount;

            if (labelValues.Length != rows)
                throw new ArgumentException("The number of rows in labelValues does not match the row count of tableLayoutPanel.");

            for (int row = 0; row < rows; row++)
            {
                if (labelValues[row].Length != cols)
                    throw new ArgumentException($"The number of columns in row {row} of labelValues does not match the column count of tableLayoutPanel.");

                for (int col = 0; col < cols; col++)
                {
                    Control control = tableLayoutPanel.GetControlFromPosition(col, row);
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
            int     rows   = tableLayoutPanel.RowCount;
            int     cols   = tableLayoutPanel.ColumnCount;
            int[][] result = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                result[row] = new int[cols];

                for (int col = 0; col < cols; col++)
                {
                    Control control = tableLayoutPanel.GetControlFromPosition(col, row);
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

        public void WriteScoreValue(Label scoreLabel)
        {
            scoreLabel.Text = Score.GetScore().ToString();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void FormGame_Load_1(object sender, EventArgs e)
        {

        }
    }
}
