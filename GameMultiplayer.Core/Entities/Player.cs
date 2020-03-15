using GameMultiplayer.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMultiplayer.Core.Entities
{
    public class Player
    {
        public Player(string connId)
        {
            PlayerId = Guid.NewGuid();
            ConnectionId = connId;
            PlayerX = new Random().Next(0, MapConfig.SizeX);
            PlayerY = new Random().Next(0, MapConfig.SizeY);
        }

        // Ef
        protected Player() { }

        public Guid PlayerId { get; protected set; }
        public string ConnectionId { get; protected set; }
        public int Pontos { get; set; }
        public int PlayerX { get; protected set; }
        public int PlayerY { get; protected set; }

        public void AdicionaPonto()
        {
            Pontos += 1;
        }

        public void Up()
        {           
            if (PlayerY > 0)
                PlayerY -= 1;
        }

        public void Down()
        {
            if (PlayerY < MapConfig.SizeY - PlayerConfig.PlayerSizeX)
                PlayerY += 1;
        }

        public void Left()
        {
            if (PlayerX > 0)
                PlayerX -= 1;
        }

        public void Right()
        {
            if (PlayerX < MapConfig.SizeX - PlayerConfig.PlayerSizeY)
                PlayerX += 1;
        }
    }
}
