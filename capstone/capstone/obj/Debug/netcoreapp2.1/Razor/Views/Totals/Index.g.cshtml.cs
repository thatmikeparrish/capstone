#pragma checksum "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "448ce53926c7363bfcfa24d3941174c2277f8069"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Totals_Index), @"mvc.1.0.view", @"/Views/Totals/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Totals/Index.cshtml", typeof(AspNetCore.Views_Totals_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"448ce53926c7363bfcfa24d3941174c2277f8069", @"/Views/Totals/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87ce1fe2974c136a582b043d542acd7d96380c01", @"/Views/_ViewImports.cshtml")]
    public class Views_Totals_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<capstone.Models.Total>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(115, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c250c73033e414dabc27af3cf562504", async() => {
                BeginContext(138, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(152, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(245, 48, false);
#line 16 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(293, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(349, 50, false);
#line 19 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaterialMargin));

#line default
#line hidden
            EndContext();
            BeginContext(399, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(455, 49, false);
#line 22 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaterialQuote));

#line default
#line hidden
            EndContext();
            BeginContext(504, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(560, 43, false);
#line 25 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SubCost));

#line default
#line hidden
            EndContext();
            BeginContext(603, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(659, 44, false);
#line 28 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SubQuote));

#line default
#line hidden
            EndContext();
            BeginContext(703, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(759, 44, false);
#line 31 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ManHours));

#line default
#line hidden
            EndContext();
            BeginContext(803, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(859, 50, false);
#line 34 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UnburdenedRate));

#line default
#line hidden
            EndContext();
            BeginContext(909, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(965, 45, false);
#line 37 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Insurance));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1066, 46, false);
#line 40 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LaborTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1168, 42, false);
#line 43 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Travel));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1266, 47, false);
#line 46 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Consumables));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1369, 48, false);
#line 49 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InstallQuote));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1473, 50, false);
#line 52 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompositeLabor));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1579, 53, false);
#line 55 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InstallQuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1688, 44, false);
#line 58 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SalesTax));

#line default
#line hidden
            EndContext();
            BeginContext(1732, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1788, 42, false);
#line 61 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Totals));

#line default
#line hidden
            EndContext();
            BeginContext(1830, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 67 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1948, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1997, 47, false);
#line 70 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(2044, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2100, 49, false);
#line 73 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaterialMargin));

#line default
#line hidden
            EndContext();
            BeginContext(2149, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2205, 48, false);
#line 76 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaterialQuote));

#line default
#line hidden
            EndContext();
            BeginContext(2253, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2309, 42, false);
#line 79 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SubCost));

#line default
#line hidden
            EndContext();
            BeginContext(2351, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2407, 43, false);
#line 82 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SubQuote));

#line default
#line hidden
            EndContext();
            BeginContext(2450, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2506, 43, false);
#line 85 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ManHours));

#line default
#line hidden
            EndContext();
            BeginContext(2549, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2605, 49, false);
#line 88 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UnburdenedRate));

#line default
#line hidden
            EndContext();
            BeginContext(2654, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2710, 44, false);
#line 91 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Insurance));

#line default
#line hidden
            EndContext();
            BeginContext(2754, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2810, 45, false);
#line 94 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LaborTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2855, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2911, 41, false);
#line 97 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Travel));

#line default
#line hidden
            EndContext();
            BeginContext(2952, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3008, 46, false);
#line 100 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Consumables));

#line default
#line hidden
            EndContext();
            BeginContext(3054, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3110, 47, false);
#line 103 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InstallQuote));

#line default
#line hidden
            EndContext();
            BeginContext(3157, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3213, 49, false);
#line 106 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompositeLabor));

#line default
#line hidden
            EndContext();
            BeginContext(3262, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3318, 52, false);
#line 109 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InstallQuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3370, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3426, 43, false);
#line 112 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SalesTax));

#line default
#line hidden
            EndContext();
            BeginContext(3469, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3525, 41, false);
#line 115 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Totals));

#line default
#line hidden
            EndContext();
            BeginContext(3566, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3621, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e7e16ba05ad4d9881b6f02b15ffc026", async() => {
                BeginContext(3671, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 118 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
                                       WriteLiteral(item.TotalId);

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
            BeginContext(3679, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3699, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd9299ae0c284a25a812325381c70cad", async() => {
                BeginContext(3752, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 119 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
                                          WriteLiteral(item.TotalId);

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
            BeginContext(3763, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3783, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "087173e5184845f1be638f4c396ae10a", async() => {
                BeginContext(3835, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
                                         WriteLiteral(item.TotalId);

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
            BeginContext(3845, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 123 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\Totals\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3884, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<capstone.Models.Total>> Html { get; private set; }
    }
}
#pragma warning restore 1591
