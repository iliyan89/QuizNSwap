#pragma checksum "C:\Users\Ilian\Documents\GitHub\QuizNSwap\Areas\Play\Views\Play\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66dc0ccda20df576da8930799a134cfcf8fcfe44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Play_Views_Play_Index), @"mvc.1.0.view", @"/Areas/Play/Views/Play/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66dc0ccda20df576da8930799a134cfcf8fcfe44", @"/Areas/Play/Views/Play/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Areas/Play/Views/_ViewImports.cshtml")]
    public class Areas_Play_Views_Play_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ilian\Documents\GitHub\QuizNSwap\Areas\Play\Views\Play\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Play/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div class=\"container\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 154, "\"", 162, 0);
            EndWriteAttribute();
            WriteLiteral(">&nbsp;</div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 186, "\"", 194, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 210, "\"", 218, 0);
            EndWriteAttribute();
            WriteLiteral(">User</div>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 244, "\"", 252, 0);
            EndWriteAttribute();
            WriteLiteral("><input type=\"text\" id=\"userInput\" /></div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-2\">Message</div>\r\n        <div class=\"col-4\"><input type=\"text\" id=\"messageInput\" /></div>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 469, "\"", 477, 0);
            EndWriteAttribute();
            WriteLiteral(">&nbsp;</div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 501, "\"", 509, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"col-6\">\r\n            <input type=\"button\" id=\"sendButton\" value=\"Send Message\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n<div");
            BeginWriteAttribute("class", " class=\"", 656, "\"", 664, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 676, "\"", 684, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <hr />\r\n    </div>\r\n</div>\r\n<div");
            BeginWriteAttribute("class", " class=\"", 728, "\"", 736, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 748, "\"", 756, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <ul id=\"messagesList\"></ul>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66dc0ccda20df576da8930799a134cfcf8fcfe445900", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66dc0ccda20df576da8930799a134cfcf8fcfe446939", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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