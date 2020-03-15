using GameMultiplayer.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMultiplayer.App.Interfaces
{
    public interface IFruitAppService
    {
        void Add();
        IEnumerable<FruitModel> GetAll();
    }
}
