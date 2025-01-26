namespace TurntableGames.CringyCards.Events;

public sealed record RoundEnded
{
    public required string WinningCard { get; init; }

    public int Round { get; init; }
}
