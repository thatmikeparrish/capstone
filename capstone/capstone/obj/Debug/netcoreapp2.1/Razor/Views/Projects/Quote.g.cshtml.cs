#pragma checksum "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7726350cbe0ffa8a8b34945ce39eaacd4b103a65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Quote), @"mvc.1.0.view", @"/Views/Projects/Quote.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Quote.cshtml", typeof(AspNetCore.Views_Projects_Quote))]
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
#line 1 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\_ViewImports.cshtml"
using capstone;

#line default
#line hidden
#line 2 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\_ViewImports.cshtml"
using capstone.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7726350cbe0ffa8a8b34945ce39eaacd4b103a65", @"/Views/Projects/Quote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87ce1fe2974c136a582b043d542acd7d96380c01", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Quote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<capstone.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logoMikeParrishMix.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("thatmikeparrish"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("quoteLogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
  
    ViewData["Title"] = "Quote";

#line default
#line hidden
            BeginContext(75, 97, true);
            WriteLiteral("\r\n<div class=\"quote\">\r\n    <div class=\"row topRow\">\r\n        <div class=\"col-md-8\">\r\n            ");
            EndContext();
            BeginContext(172, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "24d669e28e8d4fd19181c3bc38c118ba", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(257, 224, true);
            WriteLiteral("\r\n            <p>Phone: 615-788-6484</p>\r\n            <p>E-mail: thatmikeparrish@gmail.com</p>\r\n        </div>\r\n        <div class=\"submitDate col-md-4 text-center\">\r\n            <h1>Quote</h1>\r\n            <p>Submitted on: ");
            EndContext();
            BeginContext(482, 45, false);
#line 16 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
                        Write(Html.DisplayFor(model => model.SubmittedDate));

#line default
#line hidden
            EndContext();
            BeginContext(527, 240, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4 quoteInfo borderTop borderRight borderBottom borderLeft\">\r\n            <p>\r\n                <strong>Quote for:</strong>\r\n            </p>\r\n            <p>");
            EndContext();
            BeginContext(768, 21, false);
#line 24 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
          Write(Model.Client.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(789, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(811, 24, false);
#line 25 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
          Write(Model.Client.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(835, 192, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-4 quoteInfo borderTop borderRight borderBottom\">\r\n            <p>\r\n                <strong>Quote #:</strong>\r\n            </p>\r\n            <p>");
            EndContext();
            BeginContext(1028, 19, false);
#line 31 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
          Write(Model.ProjectNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1047, 198, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-4 quoteInfo borderTop borderRight borderBottom\">\r\n            <p>\r\n                <strong>Quote expires:</strong>\r\n            </p>\r\n            <p>");
            EndContext();
            BeginContext(1246, 46, false);
#line 37 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
          Write(Html.DisplayFor(model => model.ExpirationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 374, true);
            WriteLiteral(@"</p>
        </div>
    </div>
    <div class=""row borderBottom"">
        <div class=""col-md-10"">
            <p class=""text-center"">
                <strong>Description</strong>
            </p>
        </div>
        <div class=""col-md-2"">
            <p class=""text-center"">
                <strong>Cost</strong>
            </p>
        </div>
    </div>
");
            EndContext();
#line 52 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
     foreach (LineItem li in Model.LineItems)
    {

#line default
#line hidden
            BeginContext(1720, 127, true);
            WriteLiteral("    <div class=\"row borderRight borderBottom borderLeft\">\r\n        <div class=\"col-md-10\">\r\n             <p class=\"descMargin\">");
            EndContext();
            BeginContext(1848, 38, false);
#line 56 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
                              Write(String.Format("{0:c}", li.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1886, 100, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n             <p class=\"descMargin text-right\">");
            EndContext();
            BeginContext(1987, 32, false);
#line 59 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
                                         Write(String.Format("{0:c}", li.Total));

#line default
#line hidden
            EndContext();
            BeginContext(2019, 34, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 62 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
    }

#line default
#line hidden
            BeginContext(2060, 386, true);
            WriteLiteral(@"    <div class=""row totals"">
        <div class=""col-md-10 text-right"">
            <p>
                <strong>Subtotal:</strong>
            </p>
            <p>
                <strong>Sales Tax:</strong>
            </p>
            <h3>
                <strong>Total:</strong>
            </h3>
        </div>
        <div class=""col-md-2 text-center"">
            <p>");
            EndContext();
            BeginContext(2447, 40, false);
#line 76 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
          Write(String.Format("{0:c}", Model.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2487, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(2509, 43, false);
#line 77 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
          Write(String.Format("{0:c}", Model.TotalSalesTax));

#line default
#line hidden
            EndContext();
            BeginContext(2552, 48, true);
            WriteLiteral("</p>\r\n            <h3>\r\n                <strong>");
            EndContext();
            BeginContext(2601, 40, false);
#line 79 "C:\Users\Mike Parrish\workspace\nss\Capstone\capstone\capstone\Views\Projects\Quote.cshtml"
                   Write(String.Format("{0:c}", Model.QuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2641, 156, true);
            WriteLiteral("</strong>\r\n            </h3>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<a href=\"javascript:void(0);\" onclick=\"history.go(-1);\" class=\"btn btn-default\">Back</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<capstone.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
