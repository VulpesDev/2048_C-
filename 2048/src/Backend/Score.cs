namespace _2048.src.Backend
{
    public class Score
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
    }
}
