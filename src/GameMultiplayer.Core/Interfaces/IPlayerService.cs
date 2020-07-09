using System;
using System.Collections.Generic;
using System.Text;
using GameMultiplayer.Core.Entities;
using GameMultiplayer.Core.Enum;

namespace GameMultiplayer.Core.Interfaces
{
    public interface IPlayerService
    {
        Player ColisionCheck(Player player);
        Player MovePlayer(Keys key, Player player);
        Player GetByConnectionId(string connId);
        IEnumerable<Player> GetAll();
        void Add(Player player);
        void Remove(string connId);
        void Update(Player player);
    }
}
