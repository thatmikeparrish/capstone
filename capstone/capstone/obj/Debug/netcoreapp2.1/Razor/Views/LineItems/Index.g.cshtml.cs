#pragma checksum "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2f5ef03f7cb4bcc2188e5f666a95844f182bd9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LineItems_Index), @"mvc.1.0.view", @"/Views/LineItems/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LineItems/Index.cshtml", typeof(AspNetCore.Views_LineItems_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f5ef03f7cb4bcc2188e5f666a95844f182bd9f", @"/Views/LineItems/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87ce1fe2974c136a582b043d542acd7d96380c01", @"/Views/_ViewImports.cshtml")]
    public class Views_LineItems_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<capstone.Models.LineItem>>
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(118, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "329b80f2780a4d7d89f3ea19df46f266", async() => {
                BeginContext(141, 10, true);
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
            BeginContext(155, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(248, 47, false);
#line 16 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(295, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(351, 48, false);
#line 19 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(399, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(455, 50, false);
#line 22 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaterialMargin));

#line default
#line hidden
            EndContext();
            BeginContext(505, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(561, 49, false);
#line 25 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaterialQuote));

#line default
#line hidden
            EndContext();
            BeginContext(610, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(666, 43, false);
#line 28 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SubCost));

#line default
#line hidden
            EndContext();
            BeginContext(709, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(765, 45, false);
#line 31 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SubMargin));

#line default
#line hidden
            EndContext();
            BeginContext(810, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(866, 44, false);
#line 34 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SubQuote));

#line default
#line hidden
            EndContext();
            BeginContext(910, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(966, 44, false);
#line 37 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ManHours));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1066, 50, false);
#line 40 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UnburdenedRate));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1172, 45, false);
#line 43 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Insurance));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1273, 46, false);
#line 46 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LaborTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1375, 42, false);
#line 49 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Travel));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1473, 47, false);
#line 52 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Consumables));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1576, 48, false);
#line 55 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InstallQuote));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1680, 50, false);
#line 58 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompositeLabor));

#line default
#line hidden
            EndContext();
            BeginContext(1730, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1786, 53, false);
#line 61 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InstallQuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1895, 49, false);
#line 64 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuoteSalesTax));

#line default
#line hidden
            EndContext();
            BeginContext(1944, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2000, 42, false);
#line 67 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Totals));

#line default
#line hidden
            EndContext();
            BeginContext(2042, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 73 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2160, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2209, 46, false);
#line 76 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2255, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2311, 41, false);
#line 79 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.MaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(2352, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2408, 44, false);
#line 82 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:P0}", item.MaterialMargin));

#line default
#line hidden
            EndContext();
            BeginContext(2452, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2508, 42, false);
#line 85 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.MaterialQuote));

#line default
#line hidden
            EndContext();
            BeginContext(2550, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2606, 36, false);
#line 88 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.SubCost));

#line default
#line hidden
            EndContext();
            BeginContext(2642, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2698, 39, false);
#line 91 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:P0}", item.SubMargin));

#line default
#line hidden
            EndContext();
            BeginContext(2737, 57, true);
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2795, 37, false);
#line 95 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.SubQuote));

#line default
#line hidden
            EndContext();
            BeginContext(2832, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2888, 43, false);
#line 98 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ManHours));

#line default
#line hidden
            EndContext();
            BeginContext(2931, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2987, 43, false);
#line 101 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.UnburdenedRate));

#line default
#line hidden
            EndContext();
            BeginContext(3030, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3086, 38, false);
#line 104 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.Insurance));

#line default
#line hidden
            EndContext();
            BeginContext(3124, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3180, 39, false);
#line 107 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.LaborTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3219, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3275, 35, false);
#line 110 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.Travel));

#line default
#line hidden
            EndContext();
            BeginContext(3310, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3366, 40, false);
#line 113 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.Consumables));

#line default
#line hidden
            EndContext();
            BeginContext(3406, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3462, 41, false);
#line 116 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.InstallQuote));

#line default
#line hidden
            EndContext();
            BeginContext(3503, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3559, 43, false);
#line 119 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.CompositeLabor));

#line default
#line hidden
            EndContext();
            BeginContext(3602, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3658, 46, false);
#line 122 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.InstallQuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3704, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3760, 42, false);
#line 125 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.QuoteSalesTax));

#line default
#line hidden
            EndContext();
            BeginContext(3802, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3858, 35, false);
#line 128 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
           Write(String.Format("{0:c}", item.Totals));

#line default
#line hidden
            EndContext();
            BeginContext(3893, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3948, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "861cee7fd62849fab43d3be5246fe1f0", async() => {
                BeginContext(4001, 4, true);
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
#line 131 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
                                       WriteLiteral(item.LineItemId);

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
            BeginContext(4009, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4029, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d3376445ee94af9a215e15af41afd3e", async() => {
                BeginContext(4085, 7, true);
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
#line 132 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
                                          WriteLiteral(item.LineItemId);

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
            BeginContext(4096, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4116, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f9db91866f840938c3dda6493bb9075", async() => {
                BeginContext(4171, 6, true);
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
#line 133 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
                                         WriteLiteral(item.LineItemId);

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
            BeginContext(4181, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 136 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4220, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<capstone.Models.LineItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
