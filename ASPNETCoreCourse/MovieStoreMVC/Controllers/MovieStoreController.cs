using Microsoft.AspNetCore.Mvc;
using MovieStoreMVC.Models;
using Microsoft.EntityFrameworkCore;
using MovieStoreMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreMVC.Controllers
{
    public class MovieStoreController : Controller
    {
        private readonly MovieDbContext _context;

        public MovieStoreController(MovieDbContext context)
        {
            _context = context; 
        }


        //Get-Methode: Expliziete HttpGet-Angabe -> [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.ToListAsync());
        }

        //Get-Methode: Details - Zeige einen Datensatz explizit an -> // GET: Movie/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound(); //NotFound -> 404 Http ErrorCode

            Movie movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            
            if (movie == null)
                return NotFound();
          
            return View(movie);
        }


       //Get-Methode -> Wir geben ein leeres Formular an den Browser
       public IActionResult Create()
       {
            return View();
       }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movie movie) //Parameter-Binding wird hier in MVC relevant (Aus Formular wird ein Object)
        {
            _context.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
