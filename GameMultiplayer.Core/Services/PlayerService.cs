using GameMultiplayer.Core.Entities;
using GameMultiplayer.Core.Enum;
using GameMultiplayer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMultiplayer.Core.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _repository;
        private readonly IFruitService _fruitService;

        public PlayerService(IPlayerRepository repository, IFruitService fruitService)
        {
            _repository = repository;
            _fruitService = fruitService;
        }

        public Player ColisionCheck(Player player)
        {
            var fruit = _fruitService.GetByPosition(player.PlayerX, player.PlayerY);

            if (fruit != null)
            {
                player.AdicionaPonto();
                _fruitService.Remove(fruit.FruitId);
            }

            return player;
        }

        public Player MovePlayer(Keys key, Player player)
        {
            if (key != 0)
                _ = (Player)player.GetType().GetMethod(key.ToString()).Invoke(player, null);

            return player;
        }

        public Player GetByConnectionId(string connId)
        {
            return _repository.GetByConnectionId(connId);
        }

        public void Add(Player player)
        {
            _repository.Add(player);
        }

        public void Remove(string connId)
        {
            var player = GetByConnectionId(connId);
            _repository.Remove(player.PlayerId);
        }

        public void Update(Player player)
        {
            _repository.Update(player);
        }

        public IEnumerable<Player> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
