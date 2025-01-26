using TurntableGames.CringyCards.Requests;

namespace TurntableGames.CringyCards.Handlers;

public sealed class CreateGameHandler : CommandHandler<CreateGame, Uuid>
{
    public override ValueTask<Result<Uuid>> Handle(CreateGame command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
