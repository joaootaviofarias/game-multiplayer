using GameMultiplayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMultiplayer.Core.Interfaces
{
    public interface IPlayerRepository : IRepository<Player>
    {
        Player GetByConnectionId(string connId);
    }
}
