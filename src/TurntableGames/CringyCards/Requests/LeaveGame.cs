namespace TurntableGames.CringyCards.Requests;

public sealed record LeaveGame : Command<Nothing>
{
    public Uuid PlayerId { get; set; }
}
