#pragma checksum "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\Shared\_ProductWithLowestPrice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e57acb56fdc0656726e7100fb11d77dbe472c5e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductWithLowestPrice), @"mvc.1.0.view", @"/Views/Shared/_ProductWithLowestPrice.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\_ViewImports.cshtml"
using MovieStoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\_ViewImports.cshtml"
using MovieStoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e57acb56fdc0656726e7100fb11d77dbe472c5e5", @"/Views/Shared/_ProductWithLowestPrice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eafbfe2dd4a5aa2112c1aaee6334475c33fc176b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductWithLowestPrice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieStoreMVC.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\Shared\_ProductWithLowestPrice.cshtml"
  
    Movie movieWithTheLowestPrice = null;

    // Wir ermitteln hier den günstigen Film, der in der gefilterten Liste angezeigt wird
    if (Model.Any())
    {
        movieWithTheLowestPrice = Model.OrderBy(o => o.Price).First();
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\Shared\_ProductWithLowestPrice.cshtml"
 if (movieWithTheLowestPrice != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Sonderangebot</p>\r\n");
            WriteLiteral("    <div class=\"card\" style=\"background-color:darkorange\">\r\n        <div class=\"card-body\">\r\n            <p>");
#nullable restore
#line 21 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\Shared\_ProductWithLowestPrice.cshtml"
          Write(movieWithTheLowestPrice.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 22 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\Shared\_ProductWithLowestPrice.cshtml"
          Write(movieWithTheLowestPrice.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\Shared\_ProductWithLowestPrice.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieStoreMVC.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
