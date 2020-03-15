using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMultiplayer.App.Models
{
    public class PlayerModel
    {
        public Guid PlayerId { get; set; }
        public string ConnectionId { get; set; }
        public int Pontos { get; set; }
        public int PlayerX { get; set; }
        public int PlayerY { get; set; }
    }
}
