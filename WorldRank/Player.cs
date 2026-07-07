namespace WorldRank;

public class Player : IPlayer
{
    public int Id { get; }
    public string Name { get; }
    public int Score { get; private set; }

    public Player(int id, string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.");

        Id = id;
        Name = name;
    }


    public void UpdateScore(int score)
    {
        if (score < 0)
            throw new ArgumentOutOfRangeException(nameof(score));

        Score = score;
    }


    public override string ToString()
    {
        return $"{Id}: {Name} - Score {Score}";
    }
}