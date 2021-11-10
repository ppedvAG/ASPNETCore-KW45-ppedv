using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageSyntaxSamples.Pages.StateManagement
{
    public class ViewDataSampleModel : PageModel
    {
        public void OnGet()
        {
            ViewData["abc"] = "Hallo liebe Teilnehmer";
        }
    }
}
