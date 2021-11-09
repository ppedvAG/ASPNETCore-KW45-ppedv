using Microsoft.AspNetCore.Mvc;
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
    }
}
