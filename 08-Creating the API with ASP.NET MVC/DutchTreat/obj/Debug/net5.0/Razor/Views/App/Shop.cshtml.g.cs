#pragma checksum "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\Views\App\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db6344a69b8664c139d271765e1f9a4d99fff51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Shop), @"mvc.1.0.view", @"/Views/App/Shop.cshtml")]
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
#line 2 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\_ViewImports.cshtml"
using DutchTreat.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\_ViewImports.cshtml"
using DutchTreat.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\_ViewImports.cshtml"
using DutchTreat.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3db6344a69b8664c139d271765e1f9a4d99fff51", @"/Views/App/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b973a9a55300cf2bb763c0967d20962a394b222f", @"/_ViewImports.cshtml")]
    public class Views_App_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Shop</h1>\r\n<p>Count: ");
#nullable restore
#line 3 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\Views\App\Shop.cshtml"
     Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\Views\App\Shop.cshtml"
     foreach (var p in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3\">\r\n            <div class=\"border bg-light rounded p-1\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 233, "\"", 258, 3);
            WriteAttributeValue("", 239, "/img/", 239, 5, true);
#nullable restore
#line 8 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\Views\App\Shop.cshtml"
WriteAttributeValue("", 244, p.ArtId, 244, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 254, ".jpg", 254, 4, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 277, "\"", 291, 1);
#nullable restore
#line 8 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\Views\App\Shop.cshtml"
WriteAttributeValue("", 283, p.Title, 283, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <h3>");
#nullable restore
#line 9 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\Views\App\Shop.cshtml"
               Write(p.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 9 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\Views\App\Shop.cshtml"
                             Write(p.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <ul>\r\n                    <li>Price: $");
#nullable restore
#line 11 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\Views\App\Shop.cshtml"
                           Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>Artist: ");
#nullable restore
#line 12 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\Views\App\Shop.cshtml"
                           Write(p.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>Title: ");
#nullable restore
#line 13 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\Views\App\Shop.cshtml"
                          Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>Description: ");
#nullable restore
#line 14 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\Views\App\Shop.cshtml"
                                Write(p.ArtDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n                <button id=\"buyButton\" class=\"btn btn-success\">Buy</button>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\D-Drive\Pankaj\Code\ASP.NET\Web App with ASP.NET Core-Angular\08-Creating the API with ASP.NET MVC\DutchTreat\Views\App\Shop.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
