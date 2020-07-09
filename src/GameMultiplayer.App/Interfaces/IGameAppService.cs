using GameMultiplayer.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMultiplayer.App.Interfaces
{
    public interface IGameAppService
    {
        Tuple<int, int> GetMapSize();
    }
}
