using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using WorldRank.Infrastructure;

namespace WorldRank.Commands.Players
{
    public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand>
    {
        private readonly ICreatePlayerPersistence _createPlayerPersistence;
    }
}
