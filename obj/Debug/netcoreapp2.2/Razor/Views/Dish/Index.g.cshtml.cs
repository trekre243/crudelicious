#pragma checksum "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2715a0e39d21af1e36bd2b15fe6c309d2f044c97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_Index), @"mvc.1.0.view", @"/Views/Dish/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dish/Index.cshtml", typeof(AspNetCore.Views_Dish_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2715a0e39d21af1e36bd2b15fe6c309d2f044c97", @"/Views/Dish/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd8a226fd45f6f4dca8644497a4266ecaef22aad", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 361, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col s12 center-align"">
        <h3>Welecome to CRUDelicious</h3>
    </div>
</div>
<div class=""row"">
    <div class=""col s6"">
        Check out some recent dishes!
    </div>
    <div class=""col s6 right-align"">
        <a href=""/new"">Add a Dish</a>
    </div>
</div>
<div class=""row"">
    <div class=""col s12"">
");
            EndContext();
#line 17 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Index.cshtml"
         foreach(var dish in Model)
        {

#line default
#line hidden
            BeginContext(428, 18, true);
            WriteLiteral("            <h5><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 446, "\"", 465, 1);
#line 19 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Index.cshtml"
WriteAttributeValue("", 453, dish.DishId, 453, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(466, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(468, 9, false);
#line 19 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Index.cshtml"
                                  Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(477, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(486, 9, false);
#line 19 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Index.cshtml"
                                                    Write(dish.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(495, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 20 "C:\Users\tkrec\Downloads\c#\CRUDelicious\Views\Dish\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(513, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
