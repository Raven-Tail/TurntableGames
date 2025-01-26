namespace TurntableGames.CringyCards.Requests;

public sealed record GetGame : Query<CringyCardsGameDto>
{
    public Uuid GameId { get; init; }
}
