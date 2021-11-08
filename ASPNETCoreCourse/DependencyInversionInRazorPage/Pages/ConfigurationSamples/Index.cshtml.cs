using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace DependencyInversionInRazorPage.Pages.ConfigurationSamples
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration Config;

        public IndexModel(IConfiguration configuration)
        {
            Config = configuration;
        }


        public ContentResult OnGet()
        {
            string myKeyValue = Config["MyKey"];
            var title = Config["Position:Title"];
            var name = Config["Position:Name"];
            var defaultLogLevel = Config["Logging:LogLevel:Default"];

            return Content($"MyKey value: {myKeyValue} \n" +
                           $"Title: {title} \n" +
                           $"Name: {name} \n" +
                           $"Default Log Level: {defaultLogLevel}");
        }
    }
}
