using System;

namespace _2048
{
    internal class ArrayManips
    {
        public static bool IsCellEmpty(int[][] board, int row, int col)
        {
            return board[row][col] == 0;
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
