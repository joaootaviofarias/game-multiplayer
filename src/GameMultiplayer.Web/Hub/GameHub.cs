using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using GameMultiplayer.App.Models;
using GameMultiplayer.App.Interfaces;

namespace GameMultiplayer.Web.Hubs
{
    public class GameHub : Hub
    {
        private readonly IPlayerAppService _playerAppService;
        private readonly IFruitAppService _fruitAppService;

        public GameHub(IFruitAppService fruitAppService, IPlayerAppService playerAppService)
        {
            _playerAppService = playerAppService;
            _fruitAppService = fruitAppService;
        }

        public override Task OnConnectedAsync()
        {
            _playerAppService.Add(Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            _playerAppService.Remove(Context.ConnectionId);
            RenderPlayers();
            return base.OnDisconnectedAsync(exception);
        }

        public async Task OnKeyPressed(int key)
        {
           _playerAppService.MovePlayer(Context.ConnectionId, key);
            await RenderPlayers();
        }

        public async Task RenderPlayers()
        {          
            await Clients.All.SendAsync("Render", _playerAppService.GetAll(), _fruitAppService.GetAll());
        }

        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }

    }
}
