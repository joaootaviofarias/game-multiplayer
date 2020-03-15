using GameMultiplayer.Core.Entities;
using GameMultiplayer.Core.Interfaces;
using GameMultiplayer.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameMultiplayer.Data.Repository
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(GameContext context) : base(context) { }

        public Player GetByConnectionId(string connId)
        {
            return DbSet.FirstOrDefault(p => p.ConnectionId == connId);
        }
    }
}
