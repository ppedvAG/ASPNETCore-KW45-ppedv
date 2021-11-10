using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazorSyntaxSample.Controllers
{
    public class StateManagementController : Controller
    {
        public IActionResult ViewDataSample()
        {
            ViewData["abc"] = "Hallo liebe Teilnehmer";
            return View();
        }

        public IActionResult TempData1()
        {
            if (!TempData.ContainsKey("Message"))
                TempData.Add("Message", "Hallo liebe Teilnehmer");

            return View();
        }

        public IActionResult TempData2()
        {
            return View();
        }
        public IActionResult TempData3()
        {
            return View();
        }

        public IActionResult ViewBagSample()
        {
            ViewBag.Haribo = 123456;
            ViewBag.RitterSport = "schmeckt gut";
            return View();
        }

        public IActionResult CacheSample()
        {
            return View();
        }
    }
}
