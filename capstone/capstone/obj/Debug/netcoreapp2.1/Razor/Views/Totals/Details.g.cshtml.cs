#pragma checksum "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ef04ce128c748a2c0a14a56a23836dd11fe5c09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Totals_Details), @"mvc.1.0.view", @"/Views/Totals/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Totals/Details.cshtml", typeof(AspNetCore.Views_Totals_Details))]
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
#line 1 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\_ViewImports.cshtml"
using capstone;

#line default
#line hidden
#line 2 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\_ViewImports.cshtml"
using capstone.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef04ce128c748a2c0a14a56a23836dd11fe5c09", @"/Views/Totals/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87ce1fe2974c136a582b043d542acd7d96380c01", @"/Views/_ViewImports.cshtml")]
    public class Views_Totals_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<capstone.Models.Total>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(75, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Total</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(195, 48, false);
#line 14 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(243, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(287, 44, false);
#line 17 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(331, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(375, 50, false);
#line 20 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaterialMargin));

#line default
#line hidden
            EndContext();
            BeginContext(425, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(469, 46, false);
#line 23 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaterialMargin));

#line default
#line hidden
            EndContext();
            BeginContext(515, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(559, 49, false);
#line 26 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaterialQuote));

#line default
#line hidden
            EndContext();
            BeginContext(608, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(652, 45, false);
#line 29 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaterialQuote));

#line default
#line hidden
            EndContext();
            BeginContext(697, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(741, 43, false);
#line 32 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubCost));

#line default
#line hidden
            EndContext();
            BeginContext(784, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(828, 39, false);
#line 35 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubCost));

#line default
#line hidden
            EndContext();
            BeginContext(867, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(911, 44, false);
#line 38 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubQuote));

#line default
#line hidden
            EndContext();
            BeginContext(955, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(999, 40, false);
#line 41 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubQuote));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1083, 44, false);
#line 44 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ManHours));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1171, 40, false);
#line 47 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.ManHours));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1255, 50, false);
#line 50 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnburdenedRate));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1349, 46, false);
#line 53 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnburdenedRate));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1439, 45, false);
#line 56 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Insurance));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1528, 41, false);
#line 59 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Insurance));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1613, 46, false);
#line 62 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LaborTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1659, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1703, 42, false);
#line 65 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.LaborTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1745, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1789, 42, false);
#line 68 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Travel));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1875, 38, false);
#line 71 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Travel));

#line default
#line hidden
            EndContext();
            BeginContext(1913, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1957, 47, false);
#line 74 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Consumables));

#line default
#line hidden
            EndContext();
            BeginContext(2004, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2048, 43, false);
#line 77 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Consumables));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2135, 48, false);
#line 80 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InstallQuote));

#line default
#line hidden
            EndContext();
            BeginContext(2183, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2227, 44, false);
#line 83 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.InstallQuote));

#line default
#line hidden
            EndContext();
            BeginContext(2271, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2315, 50, false);
#line 86 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompositeLabor));

#line default
#line hidden
            EndContext();
            BeginContext(2365, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2409, 46, false);
#line 89 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompositeLabor));

#line default
#line hidden
            EndContext();
            BeginContext(2455, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2499, 53, false);
#line 92 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InstallQuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2552, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2596, 49, false);
#line 95 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.InstallQuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2645, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2689, 44, false);
#line 98 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SalesTax));

#line default
#line hidden
            EndContext();
            BeginContext(2733, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2777, 40, false);
#line 101 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.SalesTax));

#line default
#line hidden
            EndContext();
            BeginContext(2817, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2861, 42, false);
#line 104 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Totals));

#line default
#line hidden
            EndContext();
            BeginContext(2903, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2947, 38, false);
#line 107 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Totals));

#line default
#line hidden
            EndContext();
            BeginContext(2985, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3032, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ca4ab188ff94293a04ce5858de8a320", async() => {
                BeginContext(3083, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Details.cshtml"
                           WriteLiteral(Model.TotalId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3091, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3099, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ef7adbecd5463d9479c4c90514b49f", async() => {
                BeginContext(3121, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3137, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<capstone.Models.Total> Html { get; private set; }
    }
}
#pragma warning restore 1591
