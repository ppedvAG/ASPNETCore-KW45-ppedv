using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieStoreRazorPage.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreRazorPage.Data
{
    public class MovieDBContext : DbContext
    {
        //private readonly ILoggerFactory _loggerFactory;

        public MovieDBContext(DbContextOptions<MovieDBContext> options, ILoggerFactory loggerFactory)
           : base(options)
        {
            //_loggerFactory = loggerFactory;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // Allow null if you are using an IDesignTimeDbContextFactory
        //    if (_loggerFactory != null)
        //    {
        //        if (Debugger.IsAttached)
        //        {
        //            // Probably shouldn't log sql statements in production
        //            optionsBuilder.UseLoggerFactory(this._loggerFactory);
        //        }
        //    }
        //}

        public DbSet<Movie> Movies { get; set; }
    }
}
