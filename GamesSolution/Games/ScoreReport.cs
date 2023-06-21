namespace Games;

public record ScoreReport
{
    public required List<Player> Winners { get; init; } = new();
    public required List<Player> Losers { get; init; } = new();
    public required double Average { get; init; }
}