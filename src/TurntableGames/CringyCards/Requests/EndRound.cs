namespace TurntableGames.CringyCards.Requests;

public sealed record EndRound : Command<Nothing>
{
    public required string WinningCard { get; init; }

    public int Round { get; init; }
}
