using GameMultiplayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMultiplayer.Core.Interfaces
{
    public interface IFruitService
    {
        Fruit GetByPosition(int x, int y);
        IEnumerable<Fruit> GetAll();
        void Add(Fruit fruit);
        void Remove(Guid id);
    }
}
