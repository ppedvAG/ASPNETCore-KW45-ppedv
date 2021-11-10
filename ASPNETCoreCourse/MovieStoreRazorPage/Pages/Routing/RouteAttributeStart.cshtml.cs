using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieStoreRazorPage.Pages.Routing
{
    public class RouteAttributeStartModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("RouteAttributeDestination", "ABC" ,new { year = 2021, month = 6, day = 23, title = "Jurassic Park" });
            //return RedirectToPage("RouteAttributeDestination", new { year = 2021, month = 6, day = 23, title = "Jurassic Park" });
        }
    }
}
