#pragma checksum "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MVCRazorSyntaxSample\Views\RazorSyntax\ViewModelSample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cff4cf466a1c217b9fa700450229b07bbc3d549"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RazorSyntax_ViewModelSample), @"mvc.1.0.view", @"/Views/RazorSyntax/ViewModelSample.cshtml")]
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
#line 1 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MVCRazorSyntaxSample\Views\_ViewImports.cshtml"
using MVCRazorSyntaxSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MVCRazorSyntaxSample\Views\_ViewImports.cshtml"
using MVCRazorSyntaxSample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cff4cf466a1c217b9fa700450229b07bbc3d549", @"/Views/RazorSyntax/ViewModelSample.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49672826878a0517c92f641baa7d0ca5a792b819", @"/Views/_ViewImports.cshtml")]
    public class Views_RazorSyntax_ViewModelSample : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCRazorSyntaxSample.ViewModels.CarViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MVCRazorSyntaxSample\Views\RazorSyntax\ViewModelSample.cshtml"
  
    ViewData["Title"] = "ViewModelSample";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewModelSample</h1>\r\n\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MVCRazorSyntaxSample\Views\RazorSyntax\ViewModelSample.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars.FirstOrDefault().Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MVCRazorSyntaxSample\Views\RazorSyntax\ViewModelSample.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars[0].Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MVCRazorSyntaxSample\Views\RazorSyntax\ViewModelSample.cshtml"
           Write(Html.DisplayNameFor(model => model.Cars[0].Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            <th>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MVCRazorSyntaxSample\Views\RazorSyntax\ViewModelSample.cshtml"
         foreach (Car currentCar in Model.Cars)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MVCRazorSyntaxSample\Views\RazorSyntax\ViewModelSample.cshtml"
               Write(Html.DisplayFor(modelItem => currentCar.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MVCRazorSyntaxSample\Views\RazorSyntax\ViewModelSample.cshtml"
               Write(Html.DisplayFor(modelItem => currentCar.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MVCRazorSyntaxSample\Views\RazorSyntax\ViewModelSample.cshtml"
               Write(Html.DisplayFor(modelItem => currentCar.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\MVCRazorSyntaxSample\Views\RazorSyntax\ViewModelSample.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCRazorSyntaxSample.ViewModels.CarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
