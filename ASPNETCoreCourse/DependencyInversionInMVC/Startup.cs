using DependencyInversionInMVC.Models;
using DependencyInversionSample;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Westwind.AspNetCore.LiveReload;

namespace DependencyInversionInMVC
{
    public class Startup
    {
        //Information IConfiguration liegt in der ServiceCollection und ist verf�gbar
        public Startup(IConfiguration configuration) //IConfiguration beinhalten die komplett eingelesene AppSetting.json - Konfiguraitonsdatei
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; } //Konfigurationen 

        
        
        
        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //MVC wird benutzt  -> AddControllersWithViews
            services.AddControllersWithViews()  //AddSingleton / AddTransient / AddScoped -> AddControllerWithView ist eine Erweiterung
                .AddRazorRuntimeCompilation(); //nuget-package -> Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation


            services.AddLiveReload();

            //F�r RazorPages UI-Framework 
            //services.AddRazorPages();

            //services.AddMvc(); //intern wird AddRazorPage + AddControllersWithViews aufgerufen 

            ////webapi 
            //services.AddControllers();

            
            //services.AddSingleton<ICar, MockCar>();
            //services.AddTransient<ICar, MockCar>();
            services.AddScoped<ICar, MockCar>(); 

            services.Configure<SampleWebSettings>(Configuration); //bereiten die Benutzung f�r IOptions vor
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

            app.UseLiveReload();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
