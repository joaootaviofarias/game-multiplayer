using GameMultiplayer.Core.Entities;
using GameMultiplayer.Core.Interfaces;
using GameMultiplayer.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameMultiplayer.Data.Repository
{
    public class FruitRepository : Repository<Fruit>, IFruitRepository
    {
        public FruitRepository(GameContext context) : base(context) { }

        public Fruit GetByPosition(int x, int y)
        {
            return DbSet.FirstOrDefault(f => f.FruitX == x && f.FruitY == y);
        }
    }
}
