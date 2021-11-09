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
    public class JavaScriptFormularTriggerModel : PageModel
    {
        private readonly MovieDBContext _context;

        public JavaScriptFormularTriggerModel(MovieDBContext context)
        {
            _context = context;
        }

        public List<MovieItem> MovieItems { get; set; }
        
        [BindProperty]
        public int SelectedId { get; set; }

        public async Task OnGet()
        {
            MovieItems = await _context.Movies.Select(
               x => new MovieItem()
               {
                   Id = x.Id,
                   Title = x.Title
               }
           ).ToListAsync();
        }


       
        public IActionResult OnPostSelectMovieTitle(int selectedId)
        {
            return RedirectToPage("Details", new { Id = selectedId });
        }
    }
}
