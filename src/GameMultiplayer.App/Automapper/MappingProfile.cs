using AutoMapper;
using GameMultiplayer.App.Models;
using GameMultiplayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMultiplayer.App.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Fruit, FruitModel>();
            CreateMap<Player, PlayerModel>();
        }
    }
}
