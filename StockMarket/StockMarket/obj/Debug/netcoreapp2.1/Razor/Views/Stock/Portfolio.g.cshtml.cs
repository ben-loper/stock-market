<<<<<<< HEAD
#pragma checksum "C:\workspace\Side Projects\stock-market\StockMarket\StockMarket\Views\Stock\Portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1d41bd8696d16f8c3bae7d0bc2af7985ba2b309"
=======
#pragma checksum "C:\workspace\Side Project\stock-market\StockMarket\StockMarket\Views\Stock\Portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67b7b28a7f234a8753eb6f8ba4f6ca9f6ab43612"
>>>>>>> 7f3a69e11fe89f82c0e5c6792cfd023281d5d2d1
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stock_Portfolio), @"mvc.1.0.view", @"/Views/Stock/Portfolio.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stock/Portfolio.cshtml", typeof(AspNetCore.Views_Stock_Portfolio))]
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
#line 1 "C:\workspace\Side Projects\stock-market\StockMarket\StockMarket\Views\_ViewImports.cshtml"
using StockMarket;

#line default
#line hidden
#line 2 "C:\workspace\Side Projects\stock-market\StockMarket\StockMarket\Views\_ViewImports.cshtml"
using StockMarket.Models;

#line default
#line hidden
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1d41bd8696d16f8c3bae7d0bc2af7985ba2b309", @"/Views/Stock/Portfolio.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67b7b28a7f234a8753eb6f8ba4f6ca9f6ab43612", @"/Views/Stock/Portfolio.cshtml")]
>>>>>>> 7f3a69e11fe89f82c0e5c6792cfd023281d5d2d1
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fbb6f8600756931e74d3dd6568ef2c69f0b103e", @"/Views/_ViewImports.cshtml")]
    public class Views_Stock_Portfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Title", async() => {
                BeginContext(19, 17, true);
                WriteLiteral("\r\n    Portfolio\r\n");
                EndContext();
            }
            );
            BeginContext(39, 26, true);
            WriteLiteral("\r\n\r\n<h2>Portfolio</h2>\r\n\r\n");
            EndContext();
<<<<<<< HEAD
            BeginContext(65, 587, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3185f71197e4e17a236e6c9c143c41b", async() => {
                BeginContext(71, 574, true);
=======
            BeginContext(71, 384, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5454294f61d44310a6d5cb7f07a6edbc", async() => {
                BeginContext(77, 371, true);
>>>>>>> 7f3a69e11fe89f82c0e5c6792cfd023281d5d2d1
                WriteLiteral(@"
    <input type=""text"" placeholder=""AAPL"" />
    <span>Ticker Symbol (ex: ""AAPL"")</span>

    <input type=""date"" />
    <span>Date</span>

    <input type=""text"" placeholder=""500"" />
    <span>Number of Shares</span>

    <input type=""text"" placeholder=""189.95"" />
    <span>Price</span>

    <div>
        <input type=""submit"" id=""submit"" />
    </div>
<<<<<<< HEAD

    <div class=""table-header"">
        <div>Ticker Symbol</div>
        <div>Date</div>
        <div>Number of Shares</div>
        <div>Price</div>
        <div>Market Value</div>
    </div>

=======
>>>>>>> 7f3a69e11fe89f82c0e5c6792cfd023281d5d2d1
");
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
            BeginContext(455, 241, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Ticker Symbol</th>\r\n        <th>Date</th>\r\n        <th>Number of Shares</th>\r\n        <th>Price</th>\r\n        <th>Market Value</th>\r\n    </tr>\r\n    <tr>\r\n        <td></td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
