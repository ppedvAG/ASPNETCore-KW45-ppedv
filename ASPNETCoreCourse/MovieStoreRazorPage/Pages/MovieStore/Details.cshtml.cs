using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieStoreRazorPage.Data;
using MovieStoreRazorPage.Models;

namespace MovieStoreRazorPage.Pages.MovieStore
{
    public class DetailsModel : PageModel
    {
        //Datenkontext für RazorPage Details
        private readonly MovieStoreRazorPage.Data.MovieDBContext _context;

        //Konsturktor mit Zugriff auf IOC Container 
        public DetailsModel(MovieStoreRazorPage.Data.MovieDBContext context)
        {
            _context = context;
        }

        //Mein Ausgelesener Film, der in Details angezeigt wird
        public Movie Movie { get; set; }

        //Get-Methode mit int? od
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            //Validierung, ob Id übergeben wurde
            if (id == null)
            {
                return NotFound(); //HttpStatus Code 404 wird zurückgegeben
            }

            //Ermittlung des gesuchten Film nach Id 
            Movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

            //Ergebnis der Suche validieren 
            if (Movie == null)
            {
                return NotFound();
            }

            //Anzeigen der Details Page
            return Page();
        }
    }
}
