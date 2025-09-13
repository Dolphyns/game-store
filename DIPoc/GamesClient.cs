public class GamesClient 
{
    private readonly GenresClient genresClient;

    public GamesClient(GenresClient genresClient)
    {
        ArgumentNullException.ThrowIfNull(genresClient);
        this.genresClient = genresClient;
    }

    public string[] GetGames() => ["Doom II", "The Last of Us", "Mario Bros"];
    public string[] GetGenres() => genresClient.GetGenres();
}

public class GenresClient
{
    public string[] GetGenres() => ["Action", "FPS", "Fantasy"];
}
