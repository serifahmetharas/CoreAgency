#pragma checksum "C:\Users\ASUS\source\repos\GunkomProject\CoreAgency\CoreAgency\Views\Agency\AgencyDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef0b1218c75f0b68911cb3313ad8879924aa258e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agency_AgencyDetail), @"mvc.1.0.view", @"/Views/Agency/AgencyDetail.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\GunkomProject\CoreAgency\CoreAgency\Views\_ViewImports.cshtml"
using AgencyCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\GunkomProject\CoreAgency\CoreAgency\Views\Agency\AgencyDetail.cshtml"
using AgencyCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef0b1218c75f0b68911cb3313ad8879924aa258e", @"/Views/Agency/AgencyDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484d0e96152a67397bb270e33cd57d72924dfa3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Agency_AgencyDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\GunkomProject\CoreAgency\CoreAgency\Views\Agency\AgencyDetail.cshtml"
  
    ViewData["Title"] = "AgencyDetail";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2>");
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\GunkomProject\CoreAgency\CoreAgency\Views\Agency\AgencyDetail.cshtml"
Write(ViewBag.nameag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<br/>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Name</th>\r\n        <th>LastName</th>\r\n        <th>City</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\ASUS\source\repos\GunkomProject\CoreAgency\CoreAgency\Views\Agency\AgencyDetail.cshtml"
     foreach (var customer in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\GunkomProject\CoreAgency\CoreAgency\Views\Agency\AgencyDetail.cshtml"
           Write(customer.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\ASUS\source\repos\GunkomProject\CoreAgency\CoreAgency\Views\Agency\AgencyDetail.cshtml"
           Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\ASUS\source\repos\GunkomProject\CoreAgency\CoreAgency\Views\Agency\AgencyDetail.cshtml"
           Write(customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\GunkomProject\CoreAgency\CoreAgency\Views\Agency\AgencyDetail.cshtml"
           Write(customer.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\ASUS\source\repos\GunkomProject\CoreAgency\CoreAgency\Views\Agency\AgencyDetail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
