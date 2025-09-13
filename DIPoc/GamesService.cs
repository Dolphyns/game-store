public class GamesService 
{
    public GamesClient GamesClient { get; set; }

    public GamesService(GamesClient gamesClient)
    {
        ArgumentNullException.ThrowIfNull(gamesClient, nameof(gamesClient));
        GamesClient = gamesClient;
    }

    public string[] GetGames() => GamesClient.GetGames();
}