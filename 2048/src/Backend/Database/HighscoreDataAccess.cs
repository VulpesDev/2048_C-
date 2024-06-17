using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.src.Backend.Database
{
    internal class HighscoreDataAccess
    {
        static HighscoreDataContext context = Program.Context;

        public static void AddHighscore(string name, uint scoreVal)
        {
               Highscore newHighscore = new()
               {
                   PlayerName = name,
                   Score = scoreVal
               };
               context.Highscores.Add(newHighscore);
               context.SaveChanges();
        }

        public static List<Highscore> topTenScores()
        {
            return context.Highscores
                .OrderByDescending(h => h.Score)
                .Take(10)
                .ToList();

        }
    }
}