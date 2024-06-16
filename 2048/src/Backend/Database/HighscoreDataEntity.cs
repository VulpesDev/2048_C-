using System.ComponentModel.DataAnnotations;

namespace _2048.src.Backend.Database
{
    public class Highscore
    {
        [Key]
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int Score { get; set; }
    }
}
