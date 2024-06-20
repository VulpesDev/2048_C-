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
            Row    = row;
            Column = column;
        }
    }
    internal class RandomGeneration
    {
        /// <summary>
        /// Random number picker generator based on weights(in this case I imagine them as percentages,
        /// since the sum is 100). Customisable, however currenlty(by default) it's 90/10,
        /// 90% for a 2 and 10% for a 4
        /// </summary>
        /// <returns> The picked number </returns>
        private static int GenerateRandomTileValue()
        {
            int[]   probabilities = { 2, 4 };
            int[]   weights       = { 90, 10 };
            Random  random        = new Random();

            int     cumulativeWeight = 0;
            int     totalWeight      = weights.Sum();
            int     randomNumber     = random.Next(0, totalWeight);

            for (int i = 0; i < probabilities.Length; i++)
            {
                cumulativeWeight += weights[i];
                if (randomNumber < cumulativeWeight)
                    return probabilities[i];
            }
            return probabilities[0];
        }

        /// <summary>
        /// Generates a randomly picked tile value in randomly picked cooridnates
        /// </summary>
        /// <param name="board"> Array to modify </param>
        public static void GenerateRandomEmptyCell(int[][] board)
        {
            Random              random     = new Random();
            List<Coordinate>    emptyCells = new List<Coordinate>();

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (ArrayManips.IsCellEmpty(board, row, col))
                        emptyCells.Add(new Coordinate(row, col));
                }
            }

            if (emptyCells.Count > 0)
            {
                int index = random.Next(0, emptyCells.Count);
                int x     = emptyCells[index].Row;
                int y     = emptyCells[index].Column;

                board[x][y] = GenerateRandomTileValue();
                return;
            }
            throw new InvalidOperationException("No empty cells available on the board.");
        }
    }
}
