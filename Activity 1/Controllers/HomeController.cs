﻿using Activity_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Activity_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "Index() method";
            ViewBag.MyFavouriteColour = "Green";
            ViewData["Greeting"] = "Hello Index!";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Message = "Privacy() method";
            ViewBag.MyFavouriteColour = "Green";
            ViewData["Greeting"] = "Hello Privacy!";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}