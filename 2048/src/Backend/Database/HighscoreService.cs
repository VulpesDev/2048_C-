using System;


namespace _2048.src.Backend.Database
{
    public class HighscoreService
    {
        private readonly HighscoreDataContext _context;

        public HighscoreService(HighscoreDataContext context)
        {
            _context = context;
        }

        public void AddHighscore(string playerName, uint score)
        {
            var highscore = new Highscore
            {
                PlayerName = playerName,
                Score = (int)score
            };

            _context.Highscores.Add(highscore);

            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
