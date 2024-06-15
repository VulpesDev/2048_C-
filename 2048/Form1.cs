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
        public bool MergeTiles(int[] array)
        {
            bool value = false;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != 0 && array[i] == array[i - 1])
                {
                    array[i - 1] *= 2;
                    array[i] = 0;
                    value = true;
                }
            }
            return (value);
        }
        public bool MoveTiles(int[] array)
        {
            bool value = false;

            int last0 = array.Length;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == 0)
                {
                    if (last0 > i-1)
                        last0 = i-1;
                    if (array[i] != 0)
                    {
                        array[last0] = array[i];
                        array[i] = 0;
                        i = last0 + 1;
                        last0 = i;
                        value = true;
                    }
                }
                Console.WriteLine($"printing with i: {i}");
                PrintArray(array);
            }
            return value;
        }
        public bool HorizontalManage(int[][] dArr, bool reverse)
        {
            bool value = false;
            PrintIntArray2D(dArr);
            for (int i = 0; i < dArr.Length; i++)
            {
                if (reverse)
                    ReverseArray(dArr[i]);
                bool step1 = MoveTiles(dArr[i]);
                bool step2 = MergeTiles(dArr[i]);
                bool step3 = MoveTiles(dArr[i]);
                if (step1 || step2 || step3)
                    value = true;
                if (reverse)
                    ReverseArray(dArr[i]);
            }
            Console.WriteLine("\nArray after merging:");
            PrintIntArray2D(dArr);
            return (value);
        }
        public bool VericalManage(int[][] dArr, bool reverse)
        {
            bool value = false;
            PrintIntArray2D(dArr);

            int rows = dArr.Length;
            int cols = dArr[0].Length; // Assuming all rows have the same length

            // Iterate through each column
            for (int col = 0; col < cols; col++)
            {
                // Extract column into a temporary array
                int[] column = new int[rows];
                for (int row = 0; row < rows; row++)
                {
                    column[row] = dArr[row][col];
                }

                // Apply operations to the column
                if (reverse)
                    ReverseArray(column);
                bool step1 = MoveTiles(column);
                bool step2 = MergeTiles(column);
                bool step3 = MoveTiles(column);
                if (step1 || step2 || step3)
                    value = true;
                if (reverse)
                    ReverseArray(column);

                // Update original array with modified column values
                for (int row = 0; row < rows; row++)
                {
                    dArr[row][col] = column[row];
                }
            }
            Console.WriteLine("\nArray after vertical management:");
            PrintIntArray2D(dArr);
            return (value);

        }

        public void ActionsManage(object sender, KeyEventArgs e)
        {
            bool changed = false;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (VericalManage(dArr, false))
                        changed = true;
                    break;
                case Keys.Down:
                    if (VericalManage(dArr, true))
                        changed = true;
                    break;
                case Keys.Right:
                    if (HorizontalManage(dArr, true))
                        changed = true;
                    break;
                case Keys.Left:
                    if (HorizontalManage(dArr, false))
                        changed = true;
                    break;
                default:
                    break;
            }
            if (changed)
                GenerateRandomEmptyCell(dArr);
            DrawImage();
        }

        public void PrintArray( int[] array )
        {
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        public static void PrintIntArray2D(int[][] array)
        {
            // Iterate through each row
            for (int row = 0; row < array.Length; row++)
            {
                // Iterate through each column in the current row
                for (int col = 0; col < array[row].Length; col++)
                {
                    // Print each element followed by a space
                    Console.Write(array[row][col] + " ");
                }
                // Move to the next line after each row
                Console.WriteLine();
            }
        }

        public static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
        }

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

        public static int GenerateRandomTileValue()
        {
            Random random = new Random();
            // Define probabilities (e.g., 2 tile with 90%, 4 tile with 10%)
            int[] probabilities = { 2, 4 }; // Adjust according to your needs
            int[] weights = { 90, 10 }; // Corresponding weights for probabilities (sum = 100)

            // Calculate total weight
            int totalWeight = weights.Sum();

            // Generate a random number between 0 and totalWeight
            int randomNumber = random.Next(0, totalWeight);

            // Determine the tile value based on random number and weights
            int cumulativeWeight = 0;
            for (int i = 0; i < probabilities.Length; i++)
            {
                cumulativeWeight += weights[i];
                if (randomNumber < cumulativeWeight)
                {
                    return probabilities[i];
                }
            }

            // Default return (shouldn't reach here under normal circumstances)
            return probabilities[0];
        }

        public static bool IsCellEmpty(int[][] board, int row, int col)
        {
            return board[row][col] == 0;
        }

        public void GenerateRandomEmptyCell(int[][] board)
        {
            Random random = new Random();
            List<Coordinate> emptyCells = new List<Coordinate>();

            // Collect all empty cell coordinates
            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    Console.WriteLine($"Cell check value: {board[row][col]}");
                    if (IsCellEmpty(board, row, col))
                    {
                        emptyCells.Add(new Coordinate(row, col));
                        Console.WriteLine("hey!");
                    }
                }
            }

            Console.WriteLine($"Count of empty cells: {emptyCells.Count}");
            // Randomly select an empty cell
            if (emptyCells.Count > 0)
            {
                int index = random.Next(0, emptyCells.Count);
                int x = emptyCells[index].Row;
                int y = emptyCells[index].Column;
                board[x][y] = GenerateRandomTileValue();
                return;
            }

            // No empty cells found (shouldn't happen in 2048 when spawning new tiles)
            throw new InvalidOperationException("No empty cells available on the board.");
        }

        int[][] dArr;

        public Form1()
        {
            InitializeComponent();

            //Reduces flickering
            this.DoubleBuffered = true;
            //Disables fullscreen
            this.MaximizeBox = false;
            this.KeyDown += ActionsManage;
            dArr = GetLabelValuesAsIntArray(tableLayoutPanel1);
            GenerateRandomEmptyCell(dArr);
            GenerateRandomEmptyCell(dArr);
            DrawImage();
        }

        void DrawImage()
        {
            WriteIntValuesToLabels(dArr, tableLayoutPanel1);
            UI_Management();
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
    public class Coordinate
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
