using API_2048.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

namespace API_2048.Contexts
{
    public class HighscoreDataContext : DbContext
    {
        public HighscoreDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Highscore> Highscores { get; set; }
    }
}
