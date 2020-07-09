using GameMultiplayer.Core.Entities;
using GameMultiplayer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMultiplayer.Core.Services
{
    public class FruitService : IFruitService
    {
        private readonly IFruitRepository _repository;

        public FruitService(IFruitRepository repository)
        {
            _repository = repository;
        }

        public void Add(Fruit fruit)
        {
            _repository.Add(fruit);
        }

        public IEnumerable<Fruit> GetAll()
        {
            return _repository.GetAll();
        }

        public Fruit GetByPosition(int x, int y)
        {
            return _repository.GetByPosition(x, y);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(id);
        }
    }
}
