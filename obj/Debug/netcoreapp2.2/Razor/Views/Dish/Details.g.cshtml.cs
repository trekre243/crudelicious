#pragma checksum "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce185688110a1b275c475803e5047d789f5a13f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_Details), @"mvc.1.0.view", @"/Views/Dish/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dish/Details.cshtml", typeof(AspNetCore.Views_Dish_Details))]
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
#line 2 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce185688110a1b275c475803e5047d789f5a13f7", @"/Views/Dish/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd8a226fd45f6f4dca8644497a4266ecaef22aad", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 167, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col s12\">\r\n        <a href=\"/\">Home</a>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col s12 center-align\">\r\n        <h3>");
            EndContext();
            BeginContext(181, 10, false);
#line 9 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(191, 19, true);
            WriteLiteral("</h3>\r\n        <h5>");
            EndContext();
            BeginContext(211, 10, false);
#line 10 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Details.cshtml"
       Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(221, 90, true);
            WriteLiteral("</h5>\r\n    </div>\r\n</div>\r\n<hr>\r\n<div class=\"row\">\r\n    <div class=\"col s12\">\r\n        <p>");
            EndContext();
            BeginContext(312, 17, false);
#line 16 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Details.cshtml"
      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(329, 44, true);
            WriteLiteral("</p>\r\n        <p><strong>Calories:</strong> ");
            EndContext();
            BeginContext(374, 14, false);
#line 17 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Details.cshtml"
                                 Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(388, 45, true);
            WriteLiteral("</p>\r\n        <p><strong>Tastiness:</strong> ");
            EndContext();
            BeginContext(434, 15, false);
#line 18 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Details.cshtml"
                                  Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(449, 93, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col s6 right-align\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 542, "\"", 575, 2);
            WriteAttributeValue("", 549, "/dish/delete/", 549, 13, true);
#line 23 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Details.cshtml"
WriteAttributeValue("", 562, Model.DishId, 562, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(576, 102, true);
            WriteLiteral(" class=\"waves-effect waves-light btn red\">Delete</a>\r\n    </div>\r\n    <div class=\"col s6\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 678, "\"", 704, 2);
            WriteAttributeValue("", 685, "/edit/", 685, 6, true);
#line 26 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Details.cshtml"
WriteAttributeValue("", 691, Model.DishId, 691, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(705, 66, true);
            WriteLiteral(" class=\"waves-effect waves-light btn\">Edit</a>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
