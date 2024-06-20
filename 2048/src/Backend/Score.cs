using System.Windows.Forms;

namespace _2048.src.Backend
{
    public static class Score
    {
        private static uint score = 0;
        private static uint scoreBest = 0;

        public static uint GetScore()
        {
            return score;
        }
        public static uint GetScoreBest()
        {
            return scoreBest;
        }

        public static void SetScore( uint newScore )
        {
            score = newScore;
            scoreBest = score > scoreBest ? score : scoreBest;
        }
        public static void SetScoreBest(uint newScore)
        {
            scoreBest = newScore;
        }

        public static void AddToScore(uint addition)
        {
            score += addition;
            scoreBest = score > scoreBest ? score : scoreBest;
        }

        public static void WriteScoreValue(Label scoreLabel)
        {
            scoreLabel.Text = GetScore().ToString();
        }
        public static void WriteScoreBestValue(Label scoreLabel)
        {
            scoreLabel.Text = GetScoreBest().ToString();
        }
    }
}
