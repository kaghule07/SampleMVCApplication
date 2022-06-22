using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCApplication.Controllers
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
            string[] courses = { "C#", "ASP.NET", "MVC", "Angular" };
            ViewData["Message"] = "This is my first mvc app";
            ViewBag.Courses= courses; 
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
        public IActionResult ProductList1()
        {
            string[] course = { "C#", "ASP.NET", "MVC", "Angular" };
            ViewData["Message"] = "This is my first mvc app";
            return View();
        }
    }
}
