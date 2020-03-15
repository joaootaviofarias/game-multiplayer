using GameMultiplayer.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMultiplayer.Core.Entities
{
    public class Fruit
    {
        public Fruit()
        {
            FruitId = Guid.NewGuid();
            FruitX = new Random().Next(0, MapConfig.SizeX);
            FruitY = new Random().Next(0, MapConfig.SizeY);
        }

        public Guid FruitId { get; protected set; }
        public int FruitX { get; protected set; }
        public int FruitY { get; protected set; }
    }
}
