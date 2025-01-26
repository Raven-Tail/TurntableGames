namespace TurntableGames.CringyCards.Events;

public sealed record RoundStarted
{
    public int Round { get; init; }
}
