namespace TurntableGames.CringyCards.Events;

public sealed record PlayerJoined
{
    public Uuid PlayerId { get; set; }
}
