namespace TurntableGames.CringyCards.Requests;

public sealed record StartRound : Command<Nothing>
{
    public int Round { get; init; }
}
