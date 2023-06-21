﻿namespace Games;

public class GameScorer
{
    public ScoreReport GenerateScoreReportFor(BowlingGame game)
    {
        // Pre conditions - all of the scores are in the valid ranges and there are no duplicate names.
        // Winners, Losers, Average
        // To Find the winners....
        var players = game.GetPlayers();

        int highScore = players.Max(p => p.score);
        int lowScore = players.Min(p => p.score);

        var winningPlayers = players.Where(p => p.score == highScore).ToList();
        var losingPlayers = players.Where(p => p.score == lowScore).ToList();
        var average = players.Average(p => p.score);

        return new ScoreReport
        {
            Winners = winningPlayers,
            Losers = losingPlayers,
            Average = average
        };
    }
}