#pragma checksum "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\MovieStore\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b0d88a22abd44949418b60e45ee8fb3e36b69c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieStore_Index), @"mvc.1.0.view", @"/Views/MovieStore/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b0d88a22abd44949418b60e45ee8fb3e36b69c2", @"/Views/MovieStore/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dfe7f2ba5deeb3392f3f0dcafcf530cd0fa3159", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieStore_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieStoreMVC.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\MovieStore\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\MovieStore\Index.cshtml"
           Write(Html.DisplayNameFor(model=>model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\MovieStore\Index.cshtml"
           Write(Html.DisplayNameFor(model=>model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\MovieStore\Index.cshtml"
           Write(Html.DisplayNameFor(model=>model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MovieStoreMVC\Views\MovieStore\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <!-- Diese Column repräsentiert die Button für Bearbeiten, Löschen und Details -->\r\n            <th>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n</table>\r\n\r\n");
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
