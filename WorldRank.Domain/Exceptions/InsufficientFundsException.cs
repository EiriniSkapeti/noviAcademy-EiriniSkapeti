using System;

namespace WorldRank.Domain.Exceptions
{
    public class InsufficientFundsException : WalletException
    {
        public decimal Attempted { get; }
        public decimal Balance { get; }

        public InsufficientFundsException(decimal attempted, decimal balance)
            : base($"Insufficient funds: attempted {attempted}, balance {balance}.")
        {
            Attempted = attempted;
            Balance = balance;
        }
    }
}