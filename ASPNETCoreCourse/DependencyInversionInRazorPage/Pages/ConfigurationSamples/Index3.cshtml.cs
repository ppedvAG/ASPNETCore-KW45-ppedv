using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInversionInRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace DependencyInversionInRazorPage.Pages.ConfigurationSamples
{
    public class Index3Model : PageModel
    {
        public SampleWebSettings SampleWebSettings;


        public Index3Model(IOptions<SampleWebSettings> settings)
        {
            SampleWebSettings = settings.Value;
        }


        //public ContentResult OnGet()
        //{
        //    return Content($"{SampleWebSettings.Title}\n{SampleWebSettings.Update}");
        //}

        public void OnGet()
        {
            
        }
    }
}
