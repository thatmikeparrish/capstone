#pragma checksum "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa14c1a9b18c59858583e9f408955775aef22ce3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LineItems_Details), @"mvc.1.0.view", @"/Views/LineItems/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LineItems/Details.cshtml", typeof(AspNetCore.Views_LineItems_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa14c1a9b18c59858583e9f408955775aef22ce3", @"/Views/LineItems/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87ce1fe2974c136a582b043d542acd7d96380c01", @"/Views/_ViewImports.cshtml")]
    public class Views_LineItems_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<capstone.Models.LineItem>
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>LineItem</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(201, 47, false);
#line 14 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(292, 43, false);
#line 17 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(335, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(379, 48, false);
#line 20 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(427, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(471, 44, false);
#line 23 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(515, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(559, 50, false);
#line 26 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaterialMargin));

#line default
#line hidden
            EndContext();
            BeginContext(609, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(653, 46, false);
#line 29 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaterialMargin));

#line default
#line hidden
            EndContext();
            BeginContext(699, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(743, 49, false);
#line 32 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaterialQuote));

#line default
#line hidden
            EndContext();
            BeginContext(792, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(836, 45, false);
#line 35 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaterialQuote));

#line default
#line hidden
            EndContext();
            BeginContext(881, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(925, 43, false);
#line 38 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubCost));

#line default
#line hidden
            EndContext();
            BeginContext(968, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1012, 39, false);
#line 41 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubCost));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1095, 45, false);
#line 44 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubMargin));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1184, 41, false);
#line 47 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubMargin));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1269, 44, false);
#line 50 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubQuote));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1357, 40, false);
#line 53 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubQuote));

#line default
#line hidden
            EndContext();
            BeginContext(1397, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1441, 44, false);
#line 56 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ManHours));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1529, 40, false);
#line 59 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.ManHours));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1613, 45, false);
#line 62 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LaborCost));

#line default
#line hidden
            EndContext();
            BeginContext(1658, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1702, 41, false);
#line 65 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.LaborCost));

#line default
#line hidden
            EndContext();
            BeginContext(1743, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1787, 46, false);
#line 68 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LaborQuote));

#line default
#line hidden
            EndContext();
            BeginContext(1833, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1877, 42, false);
#line 71 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.LaborQuote));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1963, 49, false);
#line 74 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuoteSalesTax));

#line default
#line hidden
            EndContext();
            BeginContext(2012, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2056, 45, false);
#line 77 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuoteSalesTax));

#line default
#line hidden
            EndContext();
            BeginContext(2101, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2145, 41, false);
#line 80 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(2186, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2230, 37, false);
#line 83 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
       Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(2267, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2314, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d4d529032b047889c53056c9fe83b96", async() => {
                BeginContext(2368, 4, true);
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
#line 88 "C:\Users\mparr\Workspace\serverSide\Capstone\capstone\capstone\Views\LineItems\Details.cshtml"
                           WriteLiteral(Model.LineItemId);

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
            BeginContext(2376, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2384, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db5a287f5e014bd882f3a6ade62f5a66", async() => {
                BeginContext(2406, 12, true);
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
            BeginContext(2422, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<capstone.Models.LineItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
