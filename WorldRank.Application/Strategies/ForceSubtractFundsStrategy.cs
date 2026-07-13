using WorldRank.Application.Stretegies;
using WorldRank.Domain.Entities;

namespace WorldRank.Application.Strategies
{
    public class ForceSubtractFundsStrategy : IFundsStrategy
    {
        // Subtracts even if the result is a negative balance.
        public void Execute(Wallet wallet, decimal amount) => wallet.ForceWithdraw(amount);
    }
}