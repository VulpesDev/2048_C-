using System.Windows.Forms;

namespace _2048.src.Backend
{
    public static class Score
    {
        private static uint score = 0;

        public static uint GetScore()
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

        public static void WriteScoreValue(Label scoreLabel)
        {
            scoreLabel.Text = GetScore().ToString();
        }
    }
}
