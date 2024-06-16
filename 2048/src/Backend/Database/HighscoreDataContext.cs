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
    }
}
