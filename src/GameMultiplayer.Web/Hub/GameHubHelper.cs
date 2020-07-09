using GameMultiplayer.App.Interfaces;
using GameMultiplayer.Core.Entities;
using GameMultiplayer.Core.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMultiplayer.Web.Hubs
{
    public class GameHubHelper : IGameHubHelper
    {
        private readonly IHubContext<GameHub> _hubContext;
        private readonly IFruitAppService _fruitAppService;
        private readonly IPlayerAppService _playerAppService;

        public GameHubHelper(IPlayerAppService playerAppService, IFruitAppService fruitAppService, IHubContext<GameHub> hubContext)
        {
            _fruitAppService = fruitAppService;
            _playerAppService = playerAppService;
            _hubContext = hubContext;
        }

        public GameHubHelper(IHubContext<GameHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public void AddFruit()
        {
            _fruitAppService.Add();
            _hubContext.Clients.All.SendAsync("Render", _playerAppService.GetAll(), _fruitAppService.GetAll());
        }
    }
}
