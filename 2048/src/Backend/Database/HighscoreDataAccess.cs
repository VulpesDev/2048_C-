using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.src.Backend.Database
{
    internal class HighscoreDataAccess
    {
        public static void AddHighscore(string name, uint scoreVal)
        {
               HighscoreDataContext context = Program.Context;
               Highscore newHighscore = new()
               {
                   PlayerName = name,
                   Score = scoreVal
               };
               context.Highscores.Add(newHighscore);
               context.SaveChanges();
        }
    }
}