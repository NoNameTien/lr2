using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private int _counter = 0;
        public IActionResult TaskFirst()
        {
            return View();
        }
        public IActionResult TaskSecond()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TaskFirst(string FirstCatet, string SecondCatet)
        {
            ViewBag.H = Math.Sqrt(Math.Pow(Convert.ToInt32(FirstCatet), 2) + Math.Pow(Convert.ToInt32(SecondCatet), 2));
            return View();
        }
        [HttpPost]
        public IActionResult TaskSecond(string firstQuestion, string secondQuestion, string thirdQuestion)
        {
            if (firstQuestion == null || secondQuestion == null || thirdQuestion == null)
            {
                return RedirectToAction("Index");
            }
            if (firstQuestion == "12")
            {
                _counter++;
            }
            if (secondQuestion == "23")
            {
                _counter++;
            }
            if (thirdQuestion == "31")
            {
                _counter++;
            }
            ViewBag.Result = Convert.ToInt32(_counter);
            return View();
        }

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
