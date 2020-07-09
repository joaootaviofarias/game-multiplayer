using GameMultiplayer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMultiplayer.Data.Context
{
    public class GameContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Fruit> Fruit { get; set; }

        public GameContext(DbContextOptions options) : base(options) { }
    }
}
