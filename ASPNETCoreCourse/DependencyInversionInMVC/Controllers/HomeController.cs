using DependencyInversionInMVC.Models;
using DependencyInversionSample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversionInMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICar _car;

        public HomeController(ILogger<HomeController> logger, ICar car) //Konstruktor Injection
        {
            _logger = logger;
            _car = car;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("call HomeController->Index Methode");
            return View(_car);
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

        public IActionResult About([FromServices] ICar theOtherCar) //Zugriff auf IOC-Container (weitere Variante)
        {
            return Content($"Current server time: {theOtherCar.Brand}");
        }
    }
}
