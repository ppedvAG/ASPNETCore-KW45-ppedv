using Microsoft.AspNetCore.Mvc;
using MovieStoreMVC.Models;
using Microsoft.EntityFrameworkCore;
using MovieStoreMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using MovieStoreMVC.ViewModels;

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

        [HttpGet("Details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound(); //NotFound -> 404 Http ErrorCode

            Movie movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            
            if (movie == null)
                return NotFound();
          
            return View(movie);
        }

        //[HttpGet("Create")]
        [HttpGet("/moviestore/create")]
        //Get-Methode -> Wir geben ein leeres Formular an den Browser
        public IActionResult Create()
       {
            return View(); //Formular ohne Daten wird gerendet und dem Browser zugesendet
       }

        //[HttpPost("Create")]
        [HttpPost("/moviestore/create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movie movie) //Parameter-Binding wird hier in MVC relevant (Aus Formular wird ein Object)
        {
            if (movie.Title == "Hostel 2")
            {
                //AddModelError lässt ModelState.IsValid auf false setzten 
                ModelState.AddModelError("Title", "Ihr Film stand auf dem Index");
            }

            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(movie);
            #region andere variante
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Add(movie);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {

            //    }
            //    return RedirectToAction(nameof(Index));
            //}




            //return RedirectToAction(nameof(Index));
            #endregion
        }


        // GET: Movie/Edit/5

        [HttpGet("Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        [ValidateAntiForgeryToken]
        [HttpPost("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Price,Genre")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        [HttpPost("Buy/{id}")]
        public IActionResult Buy(int? id) //Id des zu kaufenden Artikels
        {
            if (!id.HasValue)
            {
                return BadRequest(); //Fehlercode 400
            }

            //Ist Session verfügbar
            if (HttpContext.Session.IsAvailable)
            {
                IList<int> idList = new List<int>();


                //Ist schon ein Einkaufwagen (ShoppingCart) verfügbar 
                if (HttpContext.Session.Keys.Contains("ShoppingCart"))
                {

                    //Wollen bishere einkaufe auslesen
                    string jsonIdList = HttpContext.Session.GetString("ShoppingCart");

                    //bekommen eine Id-Liste mit allen vorhandenen Artikel im Warenkorb
                    idList = JsonSerializer.Deserialize<List<int>>(jsonIdList);
                }

                //Artikel wird dem Warenkorb hinzugefügt
                idList.Add(id.Value);

                string jsonString = JsonSerializer.Serialize(idList);

                HttpContext.Session.SetString("ShoppingCart", jsonString);
            }

            return RedirectToAction(nameof(Index));
        }




        [HttpGet("JavaScriptFormularTrigger")]
        public async Task<IActionResult> JavaScriptFormularTrigger()
        {
            List<MovieItem> items = await _context.Movies.Select(
                x => new MovieItem()
                {
                    Id = x.Id,
                    Title = x.Title
                }).ToListAsync();

            MovieTitleListViewModel vm = new MovieTitleListViewModel();
            vm.TitleList = items;

            return View(vm);
        }

        
        [HttpPost("SelectMovieTitle")]
        public IActionResult SelectMovieTitle(MovieTitleListViewModel vm)
        {
            //vm.SelectedId ist belegt und muss ausgewertet 

            return RedirectToAction(nameof(Details), new { Id = vm.SelectedId });
        }
    }
}
