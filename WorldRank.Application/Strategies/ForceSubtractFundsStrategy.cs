using WorldRank.Application.Stretegies;
using WorldRank.Domain.Entities;

namespace WorldRank.Application.Strategies
{
    public class ForceSubtractFundsStrategy : IFundsStrategy
    {
        public FundsOperations Operation => FundsOperations.ForceSubtract;

        public void Execute(Wallet wallet, decimal amount) => wallet.ForceSubtractFunds(amount);
    }
}