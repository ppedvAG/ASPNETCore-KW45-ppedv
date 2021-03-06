using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreMVC.Data;
using MovieStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieStoreMVC.Controllers
{
    public class PaymentController : Controller
    {
        private readonly MovieDbContext _context;

        public PaymentController(MovieDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IList<Movie> movieList = new List<Movie>();

            if (HttpContext.Session.IsAvailable)
            {
                if (HttpContext.Session.Keys.Contains("ShoppingCart"))
                {
                    // Private Methde aufrufen. Umd aus Warenkorb (List<int> ids) eine Movie-Liste aufzulösen. 
                    movieList = InitializeShoppingCart();
                }
            }

            return View(movieList);
        }

        private IList<Movie> InitializeShoppingCart()
        {
            if (!HttpContext.Session.Keys.Contains("ShoppingCart"))
                throw new Exception("Warenkorb ist intern noch nicht verfügbar");

            IList<Movie> movieList = new List<Movie>();

            //string shoppingCartJsonString = HttpContext.Session.GetString("ShoppingCart");
            List<int> ids = ReadShoppingPaymentFromSession();

            foreach (int currentArticleId in ids)
            {
                Movie currentMovie = _context.Movies.Find(currentArticleId);
                movieList.Add(currentMovie);
            }

            return movieList;
        }

        private List<int> ReadShoppingPaymentFromSession()
        {
            string shoppingCartJsonString = HttpContext.Session.GetString("ShoppingCart");
            List<int> ids = JsonSerializer.Deserialize<List<int>>(shoppingCartJsonString);

            return ids;
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (!id.HasValue)
                return BadRequest();

            if (!HttpContext.Session.Keys.Contains("ShoppingCart"))
                throw new Exception("Warenkorb ist intern noch nicht verfügbar");

            List<int> ids = ReadShoppingPaymentFromSession();

            if (ids.Contains(id.Value))
            {
                ids.Remove(id.Value);


                if (ids.Count == 0)
                {
                    HttpContext.Session.Remove("ShoppingCart");
                }
                else
                {
                    string jsonString = JsonSerializer.Serialize(ids);
                    HttpContext.Session.SetString("ShoppingCart", jsonString);
                }
            }


            return RedirectToAction(nameof(Index));
        }


        public IActionResult Payment()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}
