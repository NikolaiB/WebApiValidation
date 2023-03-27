﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;



        private ICancellationTokenSourceProvider _cancellationTokenSourceProvider;
        public HomeController(ILogger<HomeController> logger, ICancellationTokenSourceProvider cancellationTokenSourceProvider)
        {
            _logger = logger;
            _cancellationTokenSourceProvider = cancellationTokenSourceProvider;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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