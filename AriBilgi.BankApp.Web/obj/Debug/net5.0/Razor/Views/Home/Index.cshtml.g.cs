#pragma checksum "C:\Works\UgurcanOzcan\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4195965955378c686252e6d10238c95ad3487c0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Works\UgurcanOzcan\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Home\Index.cshtml"
using AriBilgi.BankApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4195965955378c686252e6d10238c95ad3487c0d", @"/Views/Home/Index.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApplicationUserDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Works\UgurcanOzcan\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<table class=""mt-4 table table-hover table-bordered table-sm"">

    <thead>
        <tr>

            <td>Name</td>
            <td>Surname</td>
            <td>Account Count</td>
            <td><a href=""/Home/CreateUser"" class=""btn-sm btn-primary"">Yeni Kullanıcı Ekle</a></td>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 23 "C:\Works\UgurcanOzcan\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Home\Index.cshtml"
          
            foreach (ApplicationUserDTO item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 28 "C:\Works\UgurcanOzcan\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Works\UgurcanOzcan\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Home\Index.cshtml"
                   Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><span class=\"badge bg-danger\">");
#nullable restore
#line 30 "C:\Works\UgurcanOzcan\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Home\Index.cshtml"
                                                 Write(item.AccountCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 767, "\"", 804, 2);
            WriteAttributeValue("", 774, "/Account/Index?UserId=", 774, 22, true);
#nullable restore
#line 31 "C:\Works\UgurcanOzcan\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 796, item.Id, 796, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-success\">Hesap Ekle</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Works\UgurcanOzcan\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApplicationUserDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
