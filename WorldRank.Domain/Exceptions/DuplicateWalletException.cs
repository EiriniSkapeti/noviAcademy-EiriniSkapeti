using WorldRank.Domain.Enums;

namespace WorldRank.Domain.Exceptions;

public class DuplicateWalletException : WalletException
{
	public Guid PlayerId { get; }
	public Currency Currency { get; }

	public DuplicateWalletException(Guid playerId, Currency currency)
		: base($"Player {playerId} already has a wallet in {currency}.")
	{
		PlayerId = playerId;
		Currency = currency;
	}
}
