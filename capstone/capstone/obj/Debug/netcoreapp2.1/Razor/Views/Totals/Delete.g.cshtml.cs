#pragma checksum "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "689a2c0933f9ec547019b09157d61f6729944b4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Totals_Delete), @"mvc.1.0.view", @"/Views/Totals/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Totals/Delete.cshtml", typeof(AspNetCore.Views_Totals_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"689a2c0933f9ec547019b09157d61f6729944b4b", @"/Views/Totals/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87ce1fe2974c136a582b043d542acd7d96380c01", @"/Views/_ViewImports.cshtml")]
    public class Views_Totals_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<capstone.Models.Total>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(74, 166, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Total</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(241, 48, false);
#line 15 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(289, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(333, 44, false);
#line 18 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(377, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(421, 50, false);
#line 21 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaterialMargin));

#line default
#line hidden
            EndContext();
            BeginContext(471, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(515, 46, false);
#line 24 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaterialMargin));

#line default
#line hidden
            EndContext();
            BeginContext(561, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(605, 49, false);
#line 27 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaterialQuote));

#line default
#line hidden
            EndContext();
            BeginContext(654, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(698, 45, false);
#line 30 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaterialQuote));

#line default
#line hidden
            EndContext();
            BeginContext(743, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(787, 43, false);
#line 33 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubCost));

#line default
#line hidden
            EndContext();
            BeginContext(830, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(874, 39, false);
#line 36 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubCost));

#line default
#line hidden
            EndContext();
            BeginContext(913, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(957, 44, false);
#line 39 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubQuote));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1045, 40, false);
#line 42 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubQuote));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1129, 44, false);
#line 45 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ManHours));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1217, 40, false);
#line 48 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ManHours));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1301, 50, false);
#line 51 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UnburdenedRate));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1395, 46, false);
#line 54 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UnburdenedRate));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 57, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1499, 45, false);
#line 58 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Insurance));

#line default
#line hidden
            EndContext();
            BeginContext(1544, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1588, 41, false);
#line 61 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Insurance));

#line default
#line hidden
            EndContext();
            BeginContext(1629, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1673, 46, false);
#line 64 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LaborTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1763, 42, false);
#line 67 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LaborTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1805, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1849, 42, false);
#line 70 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Travel));

#line default
#line hidden
            EndContext();
            BeginContext(1891, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1935, 38, false);
#line 73 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Travel));

#line default
#line hidden
            EndContext();
            BeginContext(1973, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2017, 47, false);
#line 76 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Consumables));

#line default
#line hidden
            EndContext();
            BeginContext(2064, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2108, 43, false);
#line 79 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Consumables));

#line default
#line hidden
            EndContext();
            BeginContext(2151, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2195, 48, false);
#line 82 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InstallQuote));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2287, 44, false);
#line 85 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InstallQuote));

#line default
#line hidden
            EndContext();
            BeginContext(2331, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2375, 50, false);
#line 88 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CompositeLabor));

#line default
#line hidden
            EndContext();
            BeginContext(2425, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2469, 46, false);
#line 91 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CompositeLabor));

#line default
#line hidden
            EndContext();
            BeginContext(2515, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2559, 53, false);
#line 94 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InstallQuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2612, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2656, 49, false);
#line 97 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InstallQuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2705, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2749, 44, false);
#line 100 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SalesTax));

#line default
#line hidden
            EndContext();
            BeginContext(2793, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2837, 40, false);
#line 103 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SalesTax));

#line default
#line hidden
            EndContext();
            BeginContext(2877, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2921, 42, false);
#line 106 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Totals));

#line default
#line hidden
            EndContext();
            BeginContext(2963, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3007, 38, false);
#line 109 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Totals));

#line default
#line hidden
            EndContext();
            BeginContext(3045, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3083, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e2a3b867f4c4fb78d93d1fccaea097a", async() => {
                BeginContext(3109, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3119, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1ac4397d4294fbfbb1b7edafe78bc34", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 114 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TotalId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3160, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3244, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c089f0a00ea450bb111c8792ce25146", async() => {
                    BeginContext(3266, 12, true);
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
                BeginContext(3282, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3295, 10, true);
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
