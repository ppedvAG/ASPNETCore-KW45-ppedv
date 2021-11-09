using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieStoreRazorPage.Data;
using MovieStoreRazorPage.Models;

namespace MovieStoreRazorPage.Pages.Payment
{
    public class IndexModel : PageModel
    {
        private readonly MovieDBContext _context;
        public IList<MovieStoreRazorPage.Models.Movie> Movies { get; set; }
        
        public IndexModel(MovieDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (HttpContext.Session.IsAvailable)
            {
                if (HttpContext.Session.Keys.Contains("ShoppingCart"))
                {
                    Movies = InitializeShoppingCart();
                }
            }
            else
            {
                Movies = new List<Movie>();
            }
            
        }

        private IList<MovieStoreRazorPage.Models.Movie> InitializeShoppingCart()
        {
            if (!HttpContext.Session.Keys.Contains("ShoppingCart"))
                throw new Exception("Warenkorb ist intern noch nicht verfügbar");

            //IList<RazorPageSamples.Models.Movie> movieList = new List<RazorPageSamples.Models.Movie>();
            List<int> ids = ReadProductIdFromSession();
            List<MovieStoreRazorPage.Models.Movie> tempMovieList = new List<Models.Movie>();
            foreach (int currentArticleId in ids)
            {
                MovieStoreRazorPage.Models.Movie currentMovie = _context.Movies.Find(currentArticleId);
                tempMovieList.Add(currentMovie);
            }
            return tempMovieList;
        }

        private List<int> ReadProductIdFromSession()
        {
            string shoppingCartJsonString = HttpContext.Session.GetString("ShoppingCart");
            List<int> ids = JsonSerializer.Deserialize<List<int>>(shoppingCartJsonString);

            return ids;
        }


        public async Task<IActionResult> OnPostDelete(int? id)
        {
            if (!id.HasValue)
                return BadRequest();

            if (!HttpContext.Session.Keys.Contains("ShoppingCart"))
                throw new Exception("Warenkorb ist intern nicht verfügbar");

            List<int> ids = ReadProductIdFromSession();

            if (ids.Contains(id.Value))
            {
                ids.Remove(id.Value);

                if (ids.Count == 0)
                    HttpContext.Session.Remove("ShoppingCart");
                else
                {
                    string jsonString = JsonSerializer.Serialize(ids);
                    HttpContext.Session.SetString("ShoppingCart", jsonString);
                }
            }

            return RedirectToPage("./Index");
        }
    }
}
