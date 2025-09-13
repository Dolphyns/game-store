public class GamesGenre 
{
    public string[] Genres { get; set; } = ["Action", "FPS", "Fantasy"];

    public string[] GetGenres() => Genres;
}
