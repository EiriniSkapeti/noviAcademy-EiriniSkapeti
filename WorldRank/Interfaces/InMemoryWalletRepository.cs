namespace WorldRank;


public class InMemoryWalletRepository : IWalletRepository
{
    private readonly Dictionary<int, Dictionary<Currency, Wallet>> wallets = new();


    public void Add(Wallet wallet, int playerId)
    {
        if (!wallets.ContainsKey(playerId))
        {
            wallets[playerId] = new Dictionary<Currency, Wallet>();
        }


        if (wallets[playerId].ContainsKey(wallet.Currency))
            throw new Exception(
                "Player already has this currency wallet");


        wallets[playerId].Add(wallet.Currency, wallet);
    }


    public IEnumerable<Wallet> GetByPlayer(int playerId)
    {
        if (wallets.ContainsKey(playerId))
            return wallets[playerId].Values;


        return Enumerable.Empty<Wallet>();
    }
}