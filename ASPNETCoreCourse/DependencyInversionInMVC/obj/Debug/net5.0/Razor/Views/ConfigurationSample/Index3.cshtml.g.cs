#pragma checksum "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\DependencyInversionInMVC\Views\ConfigurationSample\Index3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29ed1ae8618e04a57410d0f79fec059a9ee1a01d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ConfigurationSample_Index3), @"mvc.1.0.view", @"/Views/ConfigurationSample/Index3.cshtml")]
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
#line 1 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\DependencyInversionInMVC\Views\_ViewImports.cshtml"
using DependencyInversionInMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\DependencyInversionInMVC\Views\_ViewImports.cshtml"
using DependencyInversionInMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ed1ae8618e04a57410d0f79fec059a9ee1a01d", @"/Views/ConfigurationSample/Index3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a63acc70af6337706e1f8eda6647743e3146fba", @"/Views/_ViewImports.cshtml")]
    public class Views_ConfigurationSample_Index3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DependencyInversionInMVC.Models.SampleWebSettings>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\DependencyInversionInMVC\Views\ConfigurationSample\Index3.cshtml"
  
    ViewData["Title"] = "Index3";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>OptionSample</h1>\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\DependencyInversionInMVC\Views\ConfigurationSample\Index3.cshtml"
Write(Model.Update);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 11 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\DependencyInversionInMVC\Views\ConfigurationSample\Index3.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n//");
#nullable restore
#line 14 "C:\Aktueller Kurs\ASPNETCore-KW45-ppedv\ASPNETCoreCourse\DependencyInversionInMVC\Views\ConfigurationSample\Index3.cshtml"
Write(Html.Raw(Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DependencyInversionInMVC.Models.SampleWebSettings> Html { get; private set; }
    }
}
#pragma warning restore 1591
