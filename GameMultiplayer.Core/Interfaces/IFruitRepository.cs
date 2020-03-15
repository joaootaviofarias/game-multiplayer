using GameMultiplayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMultiplayer.Core.Interfaces
{
    public interface IFruitRepository : IRepository<Fruit>
    {
        Fruit GetByPosition(int x, int y);
    }
}
