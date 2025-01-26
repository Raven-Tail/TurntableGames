namespace TurntableGames.CringyCards.Events;

public sealed record PlayerSubmittedCard
{
    public required Uuid PlayerId { get; set; }

    public required string Card { get; set; }
}
