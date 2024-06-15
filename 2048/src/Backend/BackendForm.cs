using System;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        public void WriteIntValuesToLabels(int[][] labelValues, TableLayoutPanel tableLayoutPanel)
        {
            int rows = tableLayoutPanel.RowCount;
            int cols = tableLayoutPanel.ColumnCount;

            // Validate dimensions to prevent IndexOutOfRangeException
            if (labelValues.Length != rows)
            {
                throw new ArgumentException("The number of rows in labelValues does not match the row count of tableLayoutPanel.");
            }

            for (int row = 0; row < rows; row++)
            {
                if (labelValues[row].Length != cols)
                {
                    throw new ArgumentException($"The number of columns in row {row} of labelValues does not match the column count of tableLayoutPanel.");
                }

                for (int col = 0; col < cols; col++)
                {
                    Control control = tableLayoutPanel.GetControlFromPosition(col, row);
                    if (control is Label label)
                    {
                        label.Text = labelValues[row][col].ToString();
                    }
                    // You can add handling for other types of controls if necessary
                }
            }
        }
        public static int[][] GetLabelValuesAsIntArray(TableLayoutPanel tableLayoutPanel)
        {
            int rows = tableLayoutPanel.RowCount;
            int cols = tableLayoutPanel.ColumnCount;
            int[][] result = new int[rows][];

            // Iterate through each cell in the TableLayoutPanel
            for (int row = 0; row < rows; row++)
            {
                result[row] = new int[cols]; // Initialize inner array for each row

                for (int col = 0; col < cols; col++)
                {
                    Control control = tableLayoutPanel.GetControlFromPosition(col, row);
                    if (control is Label label)
                    {
                        // Convert label text to integer
                        if (int.TryParse(label.Text, out int value))
                        {
                            result[row][col] = value;
                        }
                        else
                        {
                            // Handle case where label text cannot be parsed as int
                            result[row][col] = 0; // or another default value
                        }
                    }
                    else
                    {
                        // Handle case where control is not a Label
                        result[row][col] = 0; // or another default value
                    }
                }
            }
            return result;
        }
    }
}
