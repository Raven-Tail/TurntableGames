namespace TurntableGames.CringyCards.Events;

public sealed record RoundCreated
{
    public Uuid JudgeId { get; init; }

    public Uuid[] PlayerIds { get; init; }

    public int Round { get; init; }
}
