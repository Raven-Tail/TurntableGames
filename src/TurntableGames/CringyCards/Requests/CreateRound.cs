namespace TurntableGames.CringyCards.Requests;

public sealed record CreateRound : Command<int>
{
    public Uuid JudgeId { get; init; }

    public Uuid[] PlayerIds { get; init; }

    public int Round { get; init; }
}
