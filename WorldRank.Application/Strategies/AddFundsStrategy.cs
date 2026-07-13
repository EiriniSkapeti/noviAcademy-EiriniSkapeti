using WorldRank.Application.Stretegies;
using WorldRank.Domain.Entities;

namespace WorldRank.Application.Strategies
{
    public class AddFundsStrategy : IFundsStrategy
    {
        public FundsOperations Operation => FundsOperations.Add;

        public void Execute(Wallet wallet, decimal amount) => wallet.Deposit(amount);
    }
}
