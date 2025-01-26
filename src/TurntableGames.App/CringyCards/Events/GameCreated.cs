namespace TurntableGames.CringyCards.Events;

public sealed record GameCreated
{
    public required string Name { get; init; }

    public required int MaxPlayers { get; init; }

    public required bool InviteOnly { get; init; }

    public required string? Password { get; init; }
}
