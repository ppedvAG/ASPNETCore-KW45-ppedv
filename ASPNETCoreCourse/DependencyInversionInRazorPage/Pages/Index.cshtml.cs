using DependencyInversionSample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversionInRazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        
        
        //private readonly ICar _car;
        public ICar Car { get; set; }

        //weitere Properties angeben

        public IndexModel(ILogger<IndexModel> logger, ICar car)
        {
            _logger = logger;
            Car = car;
        }


        //Get-Function initialisierung des Index-Formulars
        public void OnGet() 
        {
            _logger.LogInformation("Call Index-Razor Page");
        }
    }
}
