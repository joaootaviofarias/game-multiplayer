using GameMultiplayer.App.Interfaces;
using GameMultiplayer.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMultiplayer.App
{
    public class GameAppService : IGameAppService
    {
        public Tuple<int, int> GetMapSize()
        {
            return new Tuple<int, int>(MapConfig.Width, MapConfig.Height);
        }
    }
}
