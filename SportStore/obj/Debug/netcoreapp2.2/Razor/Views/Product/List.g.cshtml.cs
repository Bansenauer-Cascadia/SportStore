#pragma checksum "/Users/Wing/Desktop/namofni/SportStore/SportStore/Views/Product/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "405c0f8eaae5887e6b663b65028fd308547634e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SportStore.Models.Product.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/List.cshtml", typeof(SportStore.Models.Product.Views_Product_List))]
namespace SportStore.Models.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"405c0f8eaae5887e6b663b65028fd308547634e2", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed2c1a6291277dda69eab1784d37ff533394c38", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/Wing/Desktop/namofni/SportStore/SportStore/Views/Product/List.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
            BeginContext(57, 22, true);
            WriteLiteral("    <div>\n        <h3>");
            EndContext();
            BeginContext(80, 6, false);
#line 6 "/Users/Wing/Desktop/namofni/SportStore/SportStore/Views/Product/List.cshtml"
       Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(86, 14, true);
            WriteLiteral("</h3>\n        ");
            EndContext();
            BeginContext(101, 13, false);
#line 7 "/Users/Wing/Desktop/namofni/SportStore/SportStore/Views/Product/List.cshtml"
   Write(p.Description);

#line default
#line hidden
            EndContext();
            BeginContext(114, 13, true);
            WriteLiteral("\n        <h4>");
            EndContext();
            BeginContext(128, 21, false);
#line 8 "/Users/Wing/Desktop/namofni/SportStore/SportStore/Views/Product/List.cshtml"
       Write(p.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(149, 17, true);
            WriteLiteral("</h4>\n    </div>\n");
            EndContext();
#line 10 "/Users/Wing/Desktop/namofni/SportStore/SportStore/Views/Product/List.cshtml"
}

#line default
#line hidden
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