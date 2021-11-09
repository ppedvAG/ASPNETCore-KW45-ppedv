using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieStoreRazorPage.Data;
using MovieStoreRazorPage.Models;

namespace MovieStoreRazorPage.Pages.MovieStore
{
    public class IndexModel : PageModel
    {
        private readonly MovieStoreRazorPage.Data.MovieDBContext _context;

        public IndexModel(MovieStoreRazorPage.Data.MovieDBContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies.ToListAsync();
        }

        public async Task<IActionResult> OnPostBuy(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest(); //Fehlercode 400
            }

            //Ist Session Verfügbar
            if (HttpContext.Session.IsAvailable)
            {
                IList<int> idList = new List<int>();

                if (HttpContext.Session.Keys.Contains("ShoppingCart"))
                {
                    string jsonIdList = HttpContext.Session.GetString("ShoppingCart");

                    //bestehende Id (Einkäufe) sind schon im Warenkorb vorhanden und werden geladen
                    idList = JsonSerializer.Deserialize<List<int>>(jsonIdList);
                }

                //bestehender Einkauf wird der Liste hinzugefügt
                idList.Add(id.Value);

                string jsonString = JsonSerializer.Serialize(idList);
                HttpContext.Session.SetString("ShoppingCart", jsonString);

            }

            return RedirectToPage("./Index");
        }
    }
}
