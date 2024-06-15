using System;
using System.Collections.Generic;
using System.Linq;

namespace _2048
{
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
    internal class RandomGeneration
    {
        private static int GenerateRandomTileValue()
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

        public static void GenerateRandomEmptyCell(int[][] board)
        {
            Random random = new Random();
            List<Coordinate> emptyCells = new List<Coordinate>();

            // Collect all empty cell coordinates
            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    Console.WriteLine($"Cell check value: {board[row][col]}");
                    if (ArrayManips.IsCellEmpty(board, row, col))
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
    }
}
