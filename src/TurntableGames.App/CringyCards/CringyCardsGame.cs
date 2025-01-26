namespace TurntableGames.CringyCards;

public class CringyCardsGame
{
    public required string Name { get; init; }

    public required int MaxPlayers { get; init; }

    public required bool InviteOnly { get; init; }

    public required string? Password { get; init; }

    public Uuid[] PlayerIds { get; init; }

    public Round[] Rounds { get; init; }
}

public class Round
{
    public Uuid JudgeId { get; set; }

    public string WinningCard { get; set; }

    public Uuid[] Players { get; set; }
}
