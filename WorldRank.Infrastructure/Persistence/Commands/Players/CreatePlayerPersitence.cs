using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Identity.Client;
using WorldRank.Infrastructure;

namespace WorldRank.Persistence.Commands.Players
{
    public class CreatePlayerPersitence : ICreatePlayerPersistence
    {
        private readonly AppDbContext _appDbContext; //Maybe i should change this ?
        public Task Persist(Player player) 
    }
}
