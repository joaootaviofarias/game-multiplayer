using GameMultiplayer.App.Models;
using GameMultiplayer.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMultiplayer.App.Interfaces
{
    public interface IPlayerAppService
    {
        void MovePlayer(string connId, int keyNumber);
        IEnumerable<PlayerModel> GetAll();
        void Add(string connId);
        void Remove(string connId);
    }
}
