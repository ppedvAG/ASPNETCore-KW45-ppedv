using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStoreRazorPage.Models;
using MovieStoreRazorPage.Data;

namespace MovieStoreRazorPage.Data
{
    public class DataSeeder
    {
        public static void SeedMovieStoreDb(MovieDBContext context)
        {
            if (!context.Movies.Any())
            {
                context.Movies.Add(new Movie { Title = "Jurrasic Park 8", Description = "T-Rex wird Veggie", Genre = Movie.GenreTyp.Action, Price = 12.23m });
                context.Movies.Add(new Movie { Title = "ES 4", Description = "Es trifft auf den Joker", Genre = Movie.GenreTyp.Action, Price = 15.23m });
                context.Movies.Add(new Movie { Title = "Batman 7", Description = "Batman und Harley Quinn gründen eine WG", Genre = Movie.GenreTyp.Animation, Price = 17.23m });
                context.SaveChanges();
            }
        }
    }
}
