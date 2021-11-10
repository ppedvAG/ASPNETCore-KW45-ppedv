using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieStoreMVC.Data;
using MovieStoreMVC.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages(); //für die Indentity UI

            services.AddDbContext<MovieDbContext>(options =>
            {
                //options.UseInMemoryDatabase("MovieStoreDb");

                //SQL Provider bezieht seinen Connection-String aus der appsettings.json
                options.UseSqlServer(Configuration.GetConnectionString("MovieDbContext")); 
            });
            services.AddSession();

            services.AddAuthentication();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            AppDomain.CurrentDomain.SetData("BildVerzeichnis", env.WebRootPath);


            app.MapWhen(context => context.Request.Path.ToString().Contains("imagegen"), subapp =>
            {
                subapp.UseThumbnailGen();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "moviestore",
                pattern: "moviestore/{*article}",
                defaults: new { controller = "moviestore", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
