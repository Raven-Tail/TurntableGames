namespace TurntableGames.CringyCards.Requests;

public sealed record JoinGame : Command<Nothing>
{
    public Uuid PlayerId { get; set; }
}
