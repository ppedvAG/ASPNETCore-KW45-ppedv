using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageSyntaxSamples.Pages.StateManagement
{
    public class TempData1Model : PageModel
    {
        public void OnGet()
        {
            if (!TempData.ContainsKey("Message"))
                TempData.Add("Message", "Hallo liebe Teilnehmer");
        }
    }
}
