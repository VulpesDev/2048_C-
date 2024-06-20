using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_2048.Models
{
    public class Highscore
    {
        [Key]
        public int Id { get; set; }

        [Column("player_name")]
        public string PlayerName { get; set; }
        public uint Score { get; set; }

        [Timestamp]
        public DateTime Timestamp { get; set; }
    }
}
