#pragma checksum "C:\Users\ASUS\source\repos\AgencyCore\Views\Agency\GetAgency.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd51d12aaa8b6f768531da171d4fadd22443cca7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agency_GetAgency), @"mvc.1.0.view", @"/Views/Agency/GetAgency.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\AgencyCore\Views\_ViewImports.cshtml"
using AgencyCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\AgencyCore\Views\_ViewImports.cshtml"
using AgencyCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd51d12aaa8b6f768531da171d4fadd22443cca7", @"/Views/Agency/GetAgency.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484d0e96152a67397bb270e33cd57d72924dfa3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Agency_GetAgency : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AgencyCore.Models.Agency>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\AgencyCore\Views\Agency\GetAgency.cshtml"
  
    ViewData["Title"] = "GetAgency";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\AgencyCore\Views\Agency\GetAgency.cshtml"
 using (Html.BeginForm("UpdateAgency", "Agency", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Agency Id</b>\r\n");
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\AgencyCore\Views\Agency\GetAgency.cshtml"
Write(Html.TextBoxFor(x => x.AgencyId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Agency Name</b>\r\n");
#nullable restore
#line 14 "C:\Users\ASUS\source\repos\AgencyCore\Views\Agency\GetAgency.cshtml"
Write(Html.TextBoxFor(x => x.AgencyName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\" style=\"background-color:#ebdede; color:black\">Update</button>\r\n");
#nullable restore
#line 17 "C:\Users\ASUS\source\repos\AgencyCore\Views\Agency\GetAgency.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgencyCore.Models.Agency> Html { get; private set; }
    }
}
#pragma warning restore 1591
