using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

namespace _2048.src.Backend.Database
{
    public class HighscoreDataContext : DbContext
    {
        public HighscoreDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Highscore> Highscores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "server=localhost;port=3306;database=2048_VulpesDev;user=root;password=123321";

                optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 28)));
            }
        }
    }
}
