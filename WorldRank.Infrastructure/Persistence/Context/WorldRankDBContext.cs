using Microsoft.EntityFrameworkCore;
using WorldRank.Domain.Entities;

namespace WorldRank.Infrastructure.Persistence.Context
{
    internal class WorldRankDBContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Wallet> Wallet { get; set; }

        public WorldRankDBContext(DbContextOptions<WorldRankDBContext> options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            x.ToTable("Players");

        }

    }
        

}
