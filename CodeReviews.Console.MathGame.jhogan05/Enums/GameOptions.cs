using System.ComponentModel;

namespace CodeReviews.Console.MathGame.Enums
{
    public enum GameOptions
    {
        [Description("+")]       AdditionGame,
        [Description("-")]       SubtractionGame,
        [Description("*")]       MultiplicationGame,
        [Description("/")]       DivisionGame,

        IncreaseDifficulty,
        DecreaseDifficulty,
        ShowGameHistory,
        ExitProgram
    }

    public enum DifficultyLevel
    {
        Easy = 1,
        Medium = 2,
        Hard = 3
    }

    public enum GameResult
    {
        [Description("Correct")]    Correct,
        [Description("Incorrect")]  Incorrect,
        [Description("Time-out")]   TimeOut

    }
}