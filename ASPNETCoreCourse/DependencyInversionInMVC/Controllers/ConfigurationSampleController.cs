using DependencyInversionInMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversionInMVC.Controllers
{
    public class ConfigurationSampleController : Controller
    {
        private readonly IConfiguration _Configuration;
        private readonly SampleWebSettings _sampleWebSettings; 


        //ctor + tab + tabl -> Konstruktor

        public ConfigurationSampleController(IConfiguration configuration, IOptions<SampleWebSettings> settings)
        {
            _Configuration = configuration;
            _sampleWebSettings = settings.Value;
        }
        public ContentResult Index()
        {
            var myKeyValue = _Configuration["MyKey"];
            var title = _Configuration["Position:Title"];
            var name = _Configuration["Position:Name"];
            var defaultLogLevel = _Configuration["Logging:LogLevel:Default"];


            return Content($"MyKey value: {myKeyValue} \n" +
                           $"Title: {title} \n" +
                           $"Name: {name} \n" +
                           $"Default Log Level: {defaultLogLevel}");
        }


        public ContentResult Index2()
        {
            PositionOptions positionOptions = new();
            _Configuration.GetSection(PositionOptions.StringPosition).Bind(positionOptions);

            return Content($"Title: {positionOptions.Title} \n" +
                           $"Name: {positionOptions.Name}");
        }

        public ActionResult<PositionOptions> Index2Variante2()
        {
            PositionOptions positionOptions = new();
            _Configuration.GetSection(PositionOptions.StringPosition).Bind(positionOptions);

            return positionOptions;
        }


        public IActionResult Index3()
        {
            return View(_sampleWebSettings);
        }
    }
}
