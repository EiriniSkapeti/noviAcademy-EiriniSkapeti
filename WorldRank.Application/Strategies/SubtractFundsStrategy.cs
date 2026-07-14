using WorldRank.Application.Stretegies;
using WorldRank.Domain.Entities;

namespace WorldRank.Application.Strategies
{
    public class SubtractFundsStrategy : IFundsStrategy
    {
        // Throws InsufficientFundsException if the balance is too low.
        public void Execute(Wallet wallet, decimal amount) => wallet.Withdraw(amount);
    }

}