namespace WorldRank;

public class Wallet
{
    public decimal Balance { get; private set; }

    public Currency Currency { get; }

    public bool IsBlocked { get; private set; }


    public Wallet(Currency currency)
    {
        Currency = currency;
        Balance = 0;
        IsBlocked = false;
    }


    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be positive.");

        Balance += amount;
    }


    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be positive.");

        if (Balance - amount < 0)
            throw new InvalidOperationException(
                "Balance cannot go negative.");

        Balance -= amount;
    }


    public void Block()
    {
        IsBlocked = true;
    }


    public override string ToString()
    {
        return $"{Currency}: {Balance} Blocked:{IsBlocked}";
    }
}