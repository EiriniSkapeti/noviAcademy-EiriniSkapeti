namespace WorldRank;


public class InMemoryPlayerRepository : IPlayerRepository
{

    private readonly List<Player> players = new();

    public IEnumerable<Player> Players => players;


    public void AddPlayer(Player player)
    {
        players.Add(player);
    }


    public Player? FindPlayer(int playerId)
    {
        return players
            .FirstOrDefault(p => p.Id == playerId);
    }


    public void DeletePlayer(int playerId)
    {
        var player = FindPlayer(playerId);

        if (player != null)
            players.Remove(player);
    }


    public IEnumerable<Player> GroupPlayersByScore()
    {
        return players
            .OrderByDescending(p => p.Score);
    }
}