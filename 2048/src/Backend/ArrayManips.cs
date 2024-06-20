using System;

namespace _2048
{
    internal class ArrayManips
    {
        public static bool IsCellEmpty(int[][] board, int row, int col)
        {
            return board[row][col] == 0;
        }

        static bool HasEmptyCell(int[][] board)
        {
            int size = board.GetLength(0);
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (board[row][col] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static bool CanMerge(int[][] board)
        {
            int size = board.GetLength(0);
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (col < size - 1 && board[row][col] == board[row][col + 1])
                        return true;
                    if (row < size - 1 && board[row][col] == board[row + 1][col])
                        return true;
                }
            }
            return false;
        }

        public static bool NoMovesLeft(int[][] board)
        {
            return !HasEmptyCell(board) && !CanMerge(board);
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
            for (int row = 0; row < array.Length; row++)
            {
                for (int col = 0; col < array[row].Length; col++)
                {
                    Console.Write(array[row][col] + " ");
                }
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
    }
}
