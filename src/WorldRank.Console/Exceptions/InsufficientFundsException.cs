using System;

namespace WorldRank.Console.Exceptions
{
    public class InsufficientFundsException : WalletException
    {
        public decimal RequestedAmount { get; }
        public decimal AvailableBalance { get; }

        public InsufficientFundsException() { }

        public InsufficientFundsException(string message)
            : base(message) { }

        public InsufficientFundsException(string message, Exception innerException)
            : base(message, innerException) { }
        public InsufficientFundsException(decimal requestedAmount, decimal availableBalance)
            : base($"Insufficient funds: requested {requestedAmount}, available {availableBalance}.")
        {
            RequestedAmount = requestedAmount;
            AvailableBalance = availableBalance;
        }
    }
}