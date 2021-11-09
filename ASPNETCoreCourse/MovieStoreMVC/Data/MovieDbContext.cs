using Microsoft.EntityFrameworkCore;
using MovieStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreMVC.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            :base(options)
        { 
        }

        public DbSet<Movie> Movies { get; set; } //Tabelle Movies
    }
}
