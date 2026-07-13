using WorldRank.Domain.Entities;

namespace WorldRank.Application.Stretegies
{
    public interface IFundsStrategy
    {
        void Execute(Wallet wallet, decimal amount);
    }
}
