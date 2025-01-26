namespace TurntableGames.CringyCards.Events;

public sealed record PlayerLeft
{
    public Uuid PlayerId { get; set; }
}
