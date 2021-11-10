using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieStoreRazorPage.Pages.Routing
{
    public class RouteAttributeDestinationModel : PageModel
    {
        //Ohne PageHandler
        public void OnGet(int year, int month, int day, string title)
        {

        }

        //Mit Page-Hanlder
        public void OnGetABC(int year, int month, int day, string title)
        {

        }
    }
}
