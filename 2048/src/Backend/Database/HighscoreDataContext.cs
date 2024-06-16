using Microsoft.EntityFrameworkCore;

namespace _2048.src.Backend.Database
{
    public class HighscoreDataContext : DbContext
    {
        public DbSet<Highscore> Highscores { get; set; }

        public HighscoreDataContext(DbContextOptions<HighscoreDataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Highscore>()
                .HasKey(h => h.Id);
        }
    }
}
