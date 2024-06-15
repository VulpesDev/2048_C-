using _2048.src.Backend;

namespace _2048
{
    internal class Algorithm
    {
        /// <summary>
        /// Merges all the adjacent numbers.
        /// </summary>
        /// <param name="array"> 1D int array </param>
        /// <returns> True if any merge occured </returns>
        private static bool MergeTiles(int[] array)
        {
            bool value = false;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != 0 && array[i] == array[i - 1])
                {
                    array[i - 1] *= 2;
                    array[i] = 0;
                    value = true;
                    Score.AddToScore((uint)array[i-1]);
                }
            }
            return (value);
        }

        /// <summary>
        /// Moves the numbers in a direction, enclosing all the
        ///  empty spaces(0s) in-between.
        /// </summary>
        /// <param name="array"> 1D int array </param>
        /// <returns> True if any movement occured </returns>
        private static bool MoveTiles(int[] array)
        {
            bool    value = false;
            int     last0 = array.Length;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == 0)
                {
                    if (last0 > i - 1)
                        last0 = i - 1;
                    if (array[i] != 0)
                    {
                        array[last0] = array[i];
                        array[i] = 0;
                        i = last0 + 1;
                        last0 = i;
                        value = true;
                    }
                }
            }
            return value;
        }

        /// <summary>
        /// Iterates through all the rows and passes them(int[]) to
        ///  the manipulation functions (MoveTiles() and MergeTiles())
        /// </summary>
        /// <param name="dArr"> Integer array representation of the board </param>
        /// <param name="reverse"> Reverses the direction, true for up->down and false - the opposite </param>
        /// <returns> True if anything on board changed </returns>
        public static bool HorizontalManage(int[][] dArr, bool reverse)
        {
            bool value = false;

            for (int i = 0; i < dArr.Length; i++)
            {
                if (reverse)
                    ArrayManips.ReverseArray(dArr[i]);
                bool step1 = MoveTiles(dArr[i]);
                bool step2 = MergeTiles(dArr[i]);
                bool step3 = MoveTiles(dArr[i]);
                if (step1 || step2 || step3)
                    value = true;
                if (reverse)
                    ArrayManips.ReverseArray(dArr[i]);
            }
            return (value);
        }

        /// <summary>
        ///  Iterates through each column and creates a temp array, storing the
        ///   values of the column and then passes them to manipulation functions
        ///   (MoveTiles() and MergeTiles())
        /// </summary>
        /// <param name="dArr"> Integer array representation of the board </param>
        /// <param name="reverse"> Reverses the direction, true for left to right and false - the opposite </param>
        /// <returns> True if anything on board changed </returns>
        public static bool VericalManage(int[][] dArr, bool reverse)
        {
            bool    value = false;
            int     rows  = dArr.Length;

            for (int col = 0; col < dArr[0].Length; col++)
            {
                int[] temp_colum = new int[rows];
                for (int row = 0; row < rows; row++)
                    temp_colum[row] = dArr[row][col];

                if (reverse)
                    ArrayManips.ReverseArray(temp_colum);
                bool step1 = MoveTiles(temp_colum);
                bool step2 = MergeTiles(temp_colum);
                bool step3 = MoveTiles(temp_colum);
                if (step1 || step2 || step3)
                    value = true;
                if (reverse)
                    ArrayManips.ReverseArray(temp_colum);

                for (int row = 0; row < rows; row++)
                    dArr[row][col] = temp_colum[row];
            }
            return (value);
        }
    }
}
