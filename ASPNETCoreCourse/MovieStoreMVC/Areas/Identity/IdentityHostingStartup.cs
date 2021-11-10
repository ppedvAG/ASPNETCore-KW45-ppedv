using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieStoreMVC.Data;

[assembly: HostingStartup(typeof(MovieStoreMVC.Areas.Identity.IdentityHostingStartup))]
namespace MovieStoreMVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MovieStoreMVCContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MovieStoreMVCContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MovieStoreMVCContext>();
            });
        }
    }
}