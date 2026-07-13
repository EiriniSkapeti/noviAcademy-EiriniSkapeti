using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WorldRank.Application;
using WorldRank.Domain.Entities;

namespace WorldRank.Infrastructure
{
    public class EfPlayerRepository : IPlayerRepository
    {
        private readonly AppDbContext _db;

        public EfPlayerRepository(AppDbContext db) => _db = db;

        public async Task AddAsync(Player player, CancellationToken cancellationToken = default)
        {
            await _db.Players.AddAsync(player, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
        }

        // Players are read-only lookups here — AsNoTracking avoids change-tracker overhead.
        public Task<Player?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) =>
            _db.Players.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id, cancellationToken);

        public Task<Player?> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
            _db.Players.AsNoTracking().FirstOrDefaultAsync(p => p.Name == name, cancellationToken);

        public async Task<IReadOnlyList<Player>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _db.Players.AsNoTracking().ToListAsync(cancellationToken);

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var existing = await _db.Players.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
            if (existing is not null)
            {
                _db.Players.Remove(existing);
                await _db.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
