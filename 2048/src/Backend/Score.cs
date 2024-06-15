using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.src.Backend
{
    public static class Score
    {
        private static uint score = 0;

        public static long GetScore()
        {
            return score;
        }

        public static void SetScore( uint newScore )
        {
            score = newScore;
        }

        public static void AddToScore(uint addition)
        {
            score += addition;
        }
    }
}
