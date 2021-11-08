using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInversionInRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace DependencyInversionInRazorPage.Pages.ConfigurationSamples
{
    public class Index2Model : PageModel
    {
        private readonly IConfiguration Config;

        //Property 
        public PositionOptions PositionOptions { get; set; }

        public Index2Model(IConfiguration configuration)
        {
            
            Config = configuration;
        }

        public ContentResult OnGet()
        {
            PositionOptions = new PositionOptions();
            //IConfiguration -> Position wird in die Modelstruktur PositionOptions gemappt 
            Config.GetSection(PositionOptions.StringPosition).Bind(PositionOptions);

            return Content($"Title: {PositionOptions.Title} \n" +
                           $"Name: {PositionOptions.Name}");
        }
    }
}
