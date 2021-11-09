using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieStoreRazorPage.Pages.Formular
{
    public class MultiplePostButtonsModel : PageModel
    {
        public int Ergebnis { get; set; }
        
        
        public void OnGet()
        {
        }

        //public void OnGetAsync()

        public void OnPost()
        {

        }
        //public void OnPostAsync


        #region asp-page-handler="plus" + asp-page-handler="minus"
        public void OnPostPlus()
        {
            int eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            int zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());
            Ergebnis = eins + zwei;
        }

        public void OnPostMinus()
        {
            int eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            int zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());
            Ergebnis = eins - zwei;
        }
        #endregion"
    }
}
