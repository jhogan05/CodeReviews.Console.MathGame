using CodeReviews.Console.MathGame.Models;
using CodeReviews.Console.MathGame.Enums;

namespace CodeReviews.Console.MathGame.Respository;

public class GamesDatabase
{
    public List<GamesHistoryItem> _gamesHistory = new ();

    public List<GamesHistoryItem> GamesHistory { get => _gamesHistory; set => _gamesHistory = value; }

    public GamesDatabase()
    {
    
        _gamesHistory = new()
        {
            #if DEBUG
                new GamesHistoryItem
                {
                    Id = 1,
                    PlayerName = "Test Player",
                    GameType = GameOptions.AdditionGame,
                    GameDate = DateTime.Now,
                    GamePlay = "1 + 1 = 2",
                    GameResult = GameResult.Correct
                },
                new GamesHistoryItem
                {
                    Id = 2,
                    PlayerName = "Test Player",
                    GameType = GameOptions.SubtractionGame,
                    GameDate = DateTime.Now,
                    GamePlay = "1 - 1 = 0",
                    GameResult = GameResult.Correct
                },
                new GamesHistoryItem
                {
                    Id = 3,
                    PlayerName = "Test Player",
                    GameType = GameOptions.MultiplicationGame,
                    GameDate = DateTime.Now,
                    GamePlay = "1 * 1 = 1",
                    GameResult = GameResult.Correct
                },
                new GamesHistoryItem
                {
                    Id = 4,
                    PlayerName = "Test Player",
                    GameType = GameOptions.DivisionGame,
                    GameDate = DateTime.Now,
                    GamePlay = "1 / 1 = 1",
                    GameResult = GameResult.Correct
                }
            #endif
        };

    }
}