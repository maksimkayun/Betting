using Microsoft.EntityFrameworkCore;
using Betting.Data.Models;

namespace Betting.Data
{
    public class BettingContext : DbContext
    {
        public BettingContext() { }

        public BettingContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Bet> Bets { get; set; }
        
        public virtual DbSet<Color> Colors { get; set; }
        
        public virtual DbSet<Country> Countries { get; set; }
        
        public virtual DbSet<Game> Games { get; set; }
        
        public virtual DbSet<Player> Players { get; set; }
        
        public virtual DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        
        public virtual DbSet<Position> Positions { get; set; }
        
        public virtual DbSet<Team> Teams { get; set; }
        
        public virtual DbSet<Town> Towns { get; set; }
        
        public virtual DbSet<User> Users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer(@"Server=.;Database=Betting;Integrated Security=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<PlayerStatistic>(entity => {
                entity.HasKey(sc => new {sc.PlayerId, sc.GameId});
            });

            modelBuilder.Entity<Team>().HasMany(g => g.GamesAway).WithOne(t => t.AwayTeam)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Team>().HasMany(g => g.GamesHome).WithOne(t => t.HomeTeam)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Team>().HasMany(p => p.Players).WithOne(t => t.Team)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Color>().HasMany(t => t.TeamsPrimary)
                .WithOne(c => c.ColorPrimary).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Color>().HasMany(t => t.TeamsSecondary)
                .WithOne(c => c.ColorSecondary).OnDelete(DeleteBehavior.NoAction);
        }
    }
}