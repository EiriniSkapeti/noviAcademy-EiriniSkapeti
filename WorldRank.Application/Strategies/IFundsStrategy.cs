using WorldRank.Domain.Entities;

namespace WorldRank.Application.Stretegies
{
    public interface IFundsStrategy
    {
        FundsOperations Operation { get; }

        void Execute(Wallet wallet, decimal amount);
    }
}
