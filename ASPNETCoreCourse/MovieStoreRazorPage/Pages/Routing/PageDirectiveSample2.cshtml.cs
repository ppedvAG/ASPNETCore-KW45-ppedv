using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieStoreRazorPage.Pages.Routing
{
    //"{year}/{month}/{day}/{title}"
    public class PageDirectiveSample2Model : PageModel
    {
        public void OnGet(int year, int month, int day, string title)
        {

        }
    }
}
