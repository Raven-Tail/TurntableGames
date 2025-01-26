namespace TurntableGames.CringyCards.Requests;

public sealed record CreateGame : Command<Uuid>
{
    public required string Name { get; init; }

    public required int MaxPlayers { get; init; }

    public bool InviteOnly { get; init; }

    public string? Password { get; init; }
}
