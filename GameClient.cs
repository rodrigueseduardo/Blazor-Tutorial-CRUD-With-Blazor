using GameStore.client.Models;

namespace GameStore.client;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
        new Game()
        {
            Id = 1,
            Name = "The Legend Of Zelda: Ocarina Of Time",
            Genre = "RPG",
            Price = 149.90M,
            ReleaseDate = new DateTime(1998, 12, 21)
        },
        new Game()
        {
            Id = 2,
            Name = "Super Metroid",
            Genre = "Platform",
            Price = 549.90M,
            ReleaseDate = new DateTime(1994, 03, 19)
        },
        new Game()
        {
            Id = 3,
            Name = "Super Mario 64",
            Genre = "Adventure",
            Price = 89.90M,
            ReleaseDate = new DateTime(1996, 06, 23)
        }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);
    }

    public static Game GetGame(int id)
    {
        return games.Find(game => game.Id == id) ?? throw new Exception("Could not find Game!");
    }

    public static void UpdateGame(Game updatedGame)
    {
        Game existingGame = GetGame(updatedGame.Id);
        existingGame.Name = updatedGame.Name;
        existingGame.Genre = updatedGame.Genre;
        existingGame.Price = updatedGame.Price;
        existingGame.ReleaseDate = updatedGame.ReleaseDate;
    }

    public static void DeleteGame(int id)
    {
        Game game = GetGame(id);
        games.Remove(game);
    }
}