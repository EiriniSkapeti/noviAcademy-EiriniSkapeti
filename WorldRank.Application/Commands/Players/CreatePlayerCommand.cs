
using MediatR;
using WorldRank.Infrastructure;

namespace WorldRank.Commands.Players
{
    internal record CreatePlayerCommand(string name, int score) : IRequest<Guid>;
    {
    }
}
