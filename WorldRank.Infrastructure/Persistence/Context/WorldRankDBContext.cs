using Microsoft.EntityFrameworkCore;
using WorldRank.Domain.Entities;

namespace WorldRank.Infrastructure.Persistence.Context
{
    internal class WorldRankDBContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

        public WorldRankDBContext(DbContextOptions<WorldRankDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("Players");
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(200);
                entity.Property(p => p.Score);
            });

            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.ToTable("Wallets");
                entity.HasKey(w => w.Id);
                entity.Property(w => w.PlayerId);
                entity.Property(w => w.Currency).HasConversion<string>().HasMaxLength(3);
                entity.Property(w => w.Balance).HasPrecision(18, 2);
                entity.Property(w => w.IsBlocked);
            });
        }
    }
}
