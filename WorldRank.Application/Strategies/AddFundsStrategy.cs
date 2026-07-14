using WorldRank.Domain.Entities;

namespace WorldRank;

public class AddFundsStrategy : IFundsStrategy
{
    public void Execute(Wallet wallet, decimal amount) => wallet.Deposit(amount);
}
