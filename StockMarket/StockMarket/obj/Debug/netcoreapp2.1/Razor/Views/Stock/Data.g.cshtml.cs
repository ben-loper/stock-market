<<<<<<< HEAD
#pragma checksum "C:\workspace\Side Projects\stock-market\StockMarket\StockMarket\Views\Stock\Data.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ca2f0886886917dfe7ef7550c60ef9b0e834e4f"
=======
#pragma checksum "C:\workspace\Side Project\stock-market\StockMarket\StockMarket\Views\Stock\Data.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9976c8ddc9a75c56c0f2261c7d53ae372bcadb7b"
>>>>>>> 5b81b3872e9325a0f9c5d38eb8950f5f7e7cfeb5
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stock_Data), @"mvc.1.0.view", @"/Views/Stock/Data.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stock/Data.cshtml", typeof(AspNetCore.Views_Stock_Data))]
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
#line 1 "C:\workspace\Side Project\stock-market\StockMarket\StockMarket\Views\_ViewImports.cshtml"
using StockMarket;

#line default
#line hidden
#line 2 "C:\workspace\Side Project\stock-market\StockMarket\StockMarket\Views\_ViewImports.cshtml"
using StockMarket.Models;

#line default
#line hidden
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ca2f0886886917dfe7ef7550c60ef9b0e834e4f", @"/Views/Stock/Data.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9976c8ddc9a75c56c0f2261c7d53ae372bcadb7b", @"/Views/Stock/Data.cshtml")]
>>>>>>> 5b81b3872e9325a0f9c5d38eb8950f5f7e7cfeb5
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fbb6f8600756931e74d3dd6568ef2c69f0b103e", @"/Views/_ViewImports.cshtml")]
    public class Views_Stock_Data : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Data.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Title", async() => {
                BeginContext(15, 12, true);
                WriteLiteral("\r\n    Data\r\n");
                EndContext();
            }
            );
            BeginContext(30, 17, true);
            WriteLiteral("<h2>Data</h2>\r\n\r\n");
            EndContext();
<<<<<<< HEAD
            BeginContext(47, 252, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0ae0d97f6c944e69a05be6a22408b32", async() => {
                BeginContext(53, 239, true);
                WriteLiteral("\r\n    <input type=\"text\" placeholder=\"AAPL\" />\r\n    <span>Ticker Symbol (ex: \"AAPL\")</span>\r\n\r\n    <input type=\"date\" />\r\n    <span>Date</span>\r\n\r\n    <div>\r\n        <input type=\"submit\" id=\"submit\" class=\"btn btn-default\" />\r\n    </div>\r\n");
=======
            BeginContext(47, 273, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f81d7b1c2bb4e1ebbd54af857af73d2", async() => {
                BeginContext(53, 260, true);
                WriteLiteral(@"
    <input type=""text"" placeholder=""AAPL"" id=""symbol""/>
    <span>Ticker Symbol (ex: ""AAPL"")</span>

    <input type=""date""  id=""date""/>
    <span>Date</span>

    <div>
        <input type=""submit"" id=""submit"" class=""btn btn-default"" />
    </div>
");
>>>>>>> 5b81b3872e9325a0f9c5d38eb8950f5f7e7cfeb5
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
<<<<<<< HEAD
            BeginContext(299, 346, true);
=======
            BeginContext(320, 346, true);
>>>>>>> 5b81b3872e9325a0f9c5d38eb8950f5f7e7cfeb5
            WriteLiteral(@"

<table class=""table table-striped"" id=""dataTable"">
    <thead>
        <tr>
            <th>Symbol</th>
            <th>Date</th>
            <th>Open</th>
            <th>High</th>
            <th>Low</th>
            <th>Close</th>
            <th>Volume</th>
        </tr>
    </thead>
    <tbody>

    </tbody>
</table>

");
            EndContext();
            DefineSection("Scripts", async() => {
<<<<<<< HEAD
                BeginContext(663, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(669, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34a6c27206fe4036add08aa935f9bd08", async() => {
=======
                BeginContext(684, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(690, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dda364a03f542dcbdbf9ae050106426", async() => {
>>>>>>> 5b81b3872e9325a0f9c5d38eb8950f5f7e7cfeb5
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
<<<<<<< HEAD
                BeginContext(705, 2, true);
=======
                BeginContext(726, 2, true);
>>>>>>> 5b81b3872e9325a0f9c5d38eb8950f5f7e7cfeb5
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
