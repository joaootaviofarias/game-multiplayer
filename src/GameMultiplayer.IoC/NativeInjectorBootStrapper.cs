using GameMultiplayer.App;
using GameMultiplayer.App.Interfaces;
using GameMultiplayer.Core.Interfaces;
using GameMultiplayer.Core.Services;
using GameMultiplayer.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMultiplayer.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //appService
            services.AddScoped<IGameAppService, GameAppService>();
            services.AddScoped<IPlayerAppService, PlayerAppService>();
            services.AddScoped<IFruitAppService, FruitAppService>();

            //service
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IFruitService, FruitService>();

            //repository
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IFruitRepository, FruitRepository>();
        }
    }
}
