using AutoMapper;
using GameMultiplayer.App.Interfaces;
using GameMultiplayer.App.Models;
using GameMultiplayer.Core.Entities;
using GameMultiplayer.Core.Helpers;
using GameMultiplayer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMultiplayer.App
{
    public class PlayerAppService : IPlayerAppService
    {
        private readonly IPlayerService _playerService;
        private readonly IMapper _mapper;

        public PlayerAppService(IMapper mapper, IPlayerService playerService)
        {
            _playerService = playerService;
            _mapper = mapper;
        }

        public void Add(string connId)
        {
            _playerService.Add(new Player(connId));
        }

        public IEnumerable<PlayerModel> GetAll()
        {
            return _mapper.Map<IEnumerable<PlayerModel>>(_playerService.GetAll());
        }

        public void MovePlayer(string connId, int keyNumber)
        {
            var key = new Key(keyNumber);
            var keyPressed = key.GetKeyPressed();

            var player = _playerService.GetByConnectionId(connId);
            _playerService.MovePlayer(keyPressed, player);
            _playerService.ColisionCheck(player);
            _playerService.Update(player);
        }

        public void Remove(string connId)
        {
            _playerService.Remove(connId);
        }
    }
}
