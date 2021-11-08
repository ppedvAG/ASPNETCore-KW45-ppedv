using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversionInRazorPage.Models
{
    public class PositionOptions
    {
        public const string StringPosition = "Position";

        //Achtung bei Property-Namen -> diese müssen der in AppSettings gleich sein, sosnt funktioniert das Mapping der Values nicht
        public string Title { get; set; }
        public string Name { get; set; }
    }
}
