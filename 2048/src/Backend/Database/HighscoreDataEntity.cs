namespace _2048.src.Backend.Database
{
    public class Highscore
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public uint Score { get; set; }

        public Highscore() { ; }
        public Highscore(string playername, uint score)
        {
            PlayerName = playername;
            Score = score;
        }
    }
}
