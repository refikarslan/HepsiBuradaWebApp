#pragma checksum "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\Home\Urun.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e28cb1391796986d2b23d20e33211b4c170c78b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Urun), @"mvc.1.0.view", @"/Views/Home/Urun.cshtml")]
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
#line 1 "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\_ViewImports.cshtml"
using Heepsiburada;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\_ViewImports.cshtml"
using Heepsiburada.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e28cb1391796986d2b23d20e33211b4c170c78b7", @"/Views/Home/Urun.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5c9e88abda696613ed22ac7769b52324f59b740", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Urun : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Urun>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Ad</th>\r\n        <th>Id</th>\r\n        <th>Fiyat</th>\r\n        <th>Ürün</th>\r\n        <th>SİL</th>\r\n        <th>GÜNCELLE</th>\r\n\r\n    </tr>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\Home\Urun.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\Home\Urun.cshtml"
           Write(item.UrunAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=", 471, "", 515, 1);
#nullable restore
#line 23 "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\Home\Urun.cshtml"
WriteAttributeValue("", 477, Html.Raw($"/Home/Urun/{item.UrunId}"), 477, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 23 "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\Home\Urun.cshtml"
                                                           Write(item.UrunId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td>");
#nullable restore
#line 24 "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\Home\Urun.cshtml"
           Write(item.UrunFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=", 598, "", 638, 1);
#nullable restore
#line 25 "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\Home\Urun.cshtml"
WriteAttributeValue("", 603, Html.Raw($"/img/{item.UrunResim}"), 603, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 638, "", 668, 1);
#nullable restore
#line 25 "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\Home\Urun.cshtml"
WriteAttributeValue("", 643, Html.Raw(item.UrunResim), 643, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 729, 2);
            WriteAttributeValue("", 707, "/Home/Sil/", 707, 10, true);
#nullable restore
#line 26 "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\Home\Urun.cshtml"
WriteAttributeValue("", 717, item.UrunId, 717, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">SİL</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 790, "\"", 825, 2);
            WriteAttributeValue("", 797, "/Home/UrunGetir/", 797, 16, true);
#nullable restore
#line 27 "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\Home\Urun.cshtml"
WriteAttributeValue("", 813, item.UrunId, 813, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">GÜNCELLE</a></td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 30 "D:\çalışmalar\asp.net core web projesi\heepsiburada\Heepsiburada\Heepsiburada\Views\Home\Urun.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"/Home/YeniUrun\" class=\"btn btn-primary\">YENİ ÜRÜN EKLE</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Urun>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591