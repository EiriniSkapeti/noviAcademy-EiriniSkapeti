namespace WorldRank;


public interface IPlayerRepository
{
    void AddPlayer(Player player);

    Player? FindPlayer(int playerId);

    void DeletePlayer(int playerId);

    IEnumerable<Player> GroupPlayersByScore();
}