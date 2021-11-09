using Microsoft.AspNetCore.Mvc;
using MovieStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreMVC.Controllers
{
    public class FormularController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(Movie movie)
        {

            //Mach etwas mit Movie
           return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Movie movie)
        {

            //Mach etwas mit Movie
            return RedirectToAction("Privacy", "Home");
        }


    }
}
