using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreMVC.Controllers
{
    public class TagHelperSampleController : Controller
    {
        public IActionResult MyTagHelper()
        {
            return View();
        }
    }
}
