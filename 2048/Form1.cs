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
        public static void MergeTiles(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != 0 && array[i] == array[i - 1])
                {
                    array[i - 1] *= 2;
                    array[i] = 0;
                }
            }
        }
        public static void MoveTiles(int[] array)
        {
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
                    }
                }
                Console.WriteLine($"printing with i: {i}");
                PrintArray(array);
            }
        }
        public static void HorizontalManage(int[][] dArr, bool reverse)
        {
            PrintIntArray2D(dArr);
            for (int i = 0; i < dArr.Length; i++)
            {
                if (reverse)
                    ReverseArray(dArr[i]);
                MoveTiles(dArr[i]);
                MergeTiles(dArr[i]);
                MoveTiles(dArr[i]);
                if (reverse)
                    ReverseArray(dArr[i]);
            }
            Console.WriteLine("\nArray after merging:");
            PrintIntArray2D(dArr);

        }
        public static void VericalManage()
        {

        }

        public void ActionsManage(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    break;
                case Keys.Down:
                    break;
                case Keys.Right:
                    HorizontalManage(dArr, true);
                    break;
                case Keys.Left:
                    HorizontalManage(dArr, false);
                    break;
                default:
                    break;
            }
            WriteIntValuesToLabels(dArr, tableLayoutPanel1);
        }



        public static void PrintArray(int[] array)
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
            UI_Management();
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

        int[][] dArr;

        public Form1()
        {
            InitializeComponent();

            //Reduces flickering
            this.DoubleBuffered = true;
            //Disables fullscreen
            this.MaximizeBox = false;
            this.KeyDown += ActionsManage;
            UI_Management();
            dArr = GetLabelValuesAsIntArray(tableLayoutPanel1);
            
            //int[] array = new int[] { 0, 2, 2, 4 };

            //Console.WriteLine("Original array:");
            //PrintArray(array);

            //MergeTiles(array);
            //MoveTiles(array);

            //Console.WriteLine("\nArray after merging:");
            //PrintArray(array);
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
