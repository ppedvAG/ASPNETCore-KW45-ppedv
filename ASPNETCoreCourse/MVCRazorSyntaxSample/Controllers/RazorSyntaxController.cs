using Microsoft.AspNetCore.Mvc;
using MVCRazorSyntaxSample.Models;
using MVCRazorSyntaxSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazorSyntaxSample.Controllers
{
    public class RazorSyntaxController : Controller
    {
        public IActionResult Index()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car { Id = 1, Brand = "VW", Model = "Polo" });
            cars.Add(new Car { Id = 2, Brand = "Porsche", Model = "GT3" });
            cars.Add(new Car { Id = 3, Brand = "Ford", Model = "SMax" });
            cars.Add(new Car { Id = 4, Brand = "Ferrari", Model = "Enzo" });

            return View(cars); //Liste ist bereit für die UI 
        }

        public IActionResult ViewModelSample()
        {
            CarViewModel carViewModel = new CarViewModel();

            return View(carViewModel);
        }


        public IActionResult RazorSyntaxOverview()
        {
            return View();
        }
    }
}
