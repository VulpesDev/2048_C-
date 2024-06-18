using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2048.src.Backend.Database
{
    public class Highscore
    {
        [Key]
        public int Id { get; set; }

        [Column("player_name")]
        public string PlayerName { get; set; }
        public uint Score { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
