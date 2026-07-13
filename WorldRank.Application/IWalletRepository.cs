using WorldRank.Domain.Entities;

namespace WorldRank.Application
{
	public interface IWalletRepository
	{
		Task AddAsync(Wallet wallet, CancellationToken cancellationToken = default);

		Task<Wallet?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

		Task<IReadOnlyList<Wallet>> GetByPlayerAsync(Guid playerId, CancellationToken cancellationToken = default);

		Task<IReadOnlyList<Wallet>> GetAllAsync(CancellationToken cancellationToken = default);

		Task SaveChangesAsync(CancellationToken cancellationToken = default);
	}
}
