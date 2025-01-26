namespace TurntableGames.CringyCards.Requests;

public sealed record SubmitPlayerCard : Command<Nothing>
{
    public required Uuid PlayerId { get; set; }

    public required string Card { get; set; }
}
