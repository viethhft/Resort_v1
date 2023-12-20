﻿using Microsoft.AspNetCore.Mvc;
using Resort.Models;
using System.Diagnostics;

namespace Resort.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("Home/Login")]
        public IActionResult LoginAccount()
        {
            return View();
        }

        [Route("Home/Sign")]
        public IActionResult SignAccount()
        {
            return View();
        }

        [Route("Home/ForgotPassword")]
        public IActionResult ForGotPassword()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
