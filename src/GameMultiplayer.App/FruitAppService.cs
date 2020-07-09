using GameMultiplayer.App.Interfaces;
using GameMultiplayer.App.Models;
using GameMultiplayer.Core.Interfaces;
using GameMultiplayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace GameMultiplayer.App
{
    public class FruitAppService : IFruitAppService
    {
        private readonly IFruitService _fruitService;
        private readonly IMapper _mapper;
        public FruitAppService(IMapper mapper, IFruitService fruitService)
        {
            _fruitService = fruitService;
            _mapper = mapper;
        }

        public void Add()
        {
            _fruitService.Add(new Fruit());
        }

        public IEnumerable<FruitModel> GetAll()
        {
            return _mapper.Map<IEnumerable<FruitModel>>(_fruitService.GetAll());
        }
    }
}
