//using Microsoft.Extensions.DependencyInjection;

//var services = new ServiceCollection();

//services.AddSingleton<GamesService>();
//services.AddTransient<GamesClient>();
//services.AddSingleton<GamesGenre>();
//var serviceProvider = services.BuildServiceProvider();

//var gamesService = serviceProvider.GetRequiredService<GamesService>();

//var games = gamesService.GetGames();
//gamesService.GamesClient.GamesGenre.GetGenres().ToList().ForEach(genre => Console.WriteLine(genre));
//Console.WriteLine();
//games.ToList().ForEach(game => Console.WriteLine(game));
//Console.WriteLine();
//var gamesGenre = serviceProvider.GetRequiredService<GamesGenre>();
//gamesGenre.Genres = [];
//gamesService.GamesClient.GamesGenre.GetGenres().ToList().ForEach(genre => Console.WriteLine(genre));
//Console.WriteLine();
//gamesGenre.Genres.ToList().ForEach(genre => Console.WriteLine(genre));