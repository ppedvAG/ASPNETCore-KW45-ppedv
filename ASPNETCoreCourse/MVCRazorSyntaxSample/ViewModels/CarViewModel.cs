using MVCRazorSyntaxSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazorSyntaxSample.ViewModels
{
    public class CarViewModel
    {
        public List<Car> Cars { get; set; }

        public CarViewModel()
        {
            Cars = new List<Car>();

            Cars.Add(new Car { Id = 1, Brand = "VW", Model = "Polo" });
            Cars.Add(new Car { Id = 2, Brand = "Porsche", Model = "GT3" });
            Cars.Add(new Car { Id = 3, Brand = "Citrön", Model = "Ente" });
        }
    }
}
