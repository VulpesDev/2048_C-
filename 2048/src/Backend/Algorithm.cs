namespace _2048
{
    internal class Algorithm
    {
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
                }
            }
            return (value);
        }
        private static bool MoveTiles(int[] array)
        {
            bool value = false;

            int last0 = array.Length;

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
        public static bool VericalManage(int[][] dArr, bool reverse)
        {
            bool value = false;

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
                    ArrayManips.ReverseArray(column);
                bool step1 = MoveTiles(column);
                bool step2 = MergeTiles(column);
                bool step3 = MoveTiles(column);
                if (step1 || step2 || step3)
                    value = true;
                if (reverse)
                    ArrayManips.ReverseArray(column);

                // Update original array with modified column values
                for (int row = 0; row < rows; row++)
                {
                    dArr[row][col] = column[row];
                }
            }
            return (value);

        }
    }
}
