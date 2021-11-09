using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieStoreRazorPage.Pages.Formular
{
    public class PageHandlerSampleModel : PageModel
    {
        public int Ergebnis { get; set; }
        
        public void OnGet() //Standard Init-Methode, wenn Seite angezeigt werden soll
        {
            Ergebnis = 0;
        }

        public void OnGetHannes()
        {
            Ergebnis = 42;
        }
    }
}
