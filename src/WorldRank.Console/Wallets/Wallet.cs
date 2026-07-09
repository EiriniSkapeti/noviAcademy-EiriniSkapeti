using WorldRank.Console.Enums;
using WorldRank.Console.Exceptions;

namespace WorldRank.Console
{
	public class Wallet
	{
		public decimal Balance { get; private set; }
		public Currency Currency;
		public bool IsBlocked;

		public Wallet(decimal balance, Currency currency, bool isBlocked)
		{
			Balance = balance;
			Currency = currency;
			IsBlocked = false;
		}

		public void SetBalance(decimal balance)
		{
			if (balance < 0)
			{
                throw new WalletException("Balance cannot be negative.");
            }
			Balance = balance;
		}

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new WalletException("Deposit amount must be positive.");
            if (IsBlocked)
                throw new WalletException("Wallet is blocked.");

            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new WalletException("Withdrawal amount must be positive.");
            if (IsBlocked)
                throw new WalletException("Wallet is blocked.");
            if (amount > Balance)
                throw new InsufficientFundsException(amount, Balance);  // the negative-balance case

            Balance -= amount;
        }

        public override string ToString()
		{
			return "Balance -> " + Balance + " Currency ->" + Currency + " IsBlocked -> " + IsBlocked;
		}
	}
}