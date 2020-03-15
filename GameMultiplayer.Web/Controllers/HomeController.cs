using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GameMultiplayer.App.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GameMultiplayer.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameAppService _gameAppService;
        public HomeController(IGameAppService gameAppService)
        {
            _gameAppService = gameAppService;
        }

        public IActionResult Index()
        {
            var mapSize = _gameAppService.GetMapSize();

            ViewBag.Width = mapSize.Item1;
            ViewBag.Height = mapSize.Item2;
            return View();
        } 
    }
}
