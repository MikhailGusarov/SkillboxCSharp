#pragma checksum "D:\Work\SkillBox\CodeSource\CodeSource Theme25\Example_2510\Example_2512\Views\ListWorkers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61c74b1ee78e51dd2ddc794282ffdb72f8e5be0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListWorkers_Index), @"mvc.1.0.view", @"/Views/ListWorkers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListWorkers/Index.cshtml", typeof(AspNetCore.Views_ListWorkers_Index))]
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
#line 1 "D:\Work\SkillBox\CodeSource\CodeSource Theme25\Example_2510\Example_2512\Views\ListWorkers\Index.cshtml"
using Example_2512.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c74b1ee78e51dd2ddc794282ffdb72f8e5be0a", @"/Views/ListWorkers/Index.cshtml")]
    public class Views_ListWorkers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Worker>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 47, true);
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            EndContext();
            BeginContext(96, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53ea421a93534427a7a4db74c7ce60fa", async() => {
                BeginContext(102, 27, true);
                WriteLiteral("\r\n    <title></title>\r\n    ");
                EndContext();
                BeginContext(129, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d6f045b6ed246efa9d34e13949bc4a5", async() => {
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
                BeginContext(189, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(200, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(202, 540, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10f60607257447c48b9f9f49877e087a", async() => {
                BeginContext(208, 234, true);
                WriteLiteral("\r\n    <table class=\"simple-little-table\" cellspacing=\'0\'>\r\n        <tr style=\"font-size:20px;\">\r\n            <th>Компания</th>\r\n            <th>Имя</th>\r\n            <th>Возраст</th>\r\n            <th>Оплата труда</th>\r\n        </tr>\r\n");
                EndContext();
#line 18 "D:\Work\SkillBox\CodeSource\CodeSource Theme25\Example_2510\Example_2512\Views\ListWorkers\Index.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
                BeginContext(501, 38, true);
                WriteLiteral("            <tr>\r\n                <th>");
                EndContext();
                BeginContext(540, 16, false);
#line 21 "D:\Work\SkillBox\CodeSource\CodeSource Theme25\Example_2510\Example_2512\Views\ListWorkers\Index.cshtml"
               Write(Model[i].Company);

#line default
#line hidden
                EndContext();
                BeginContext(556, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(584, 13, false);
#line 22 "D:\Work\SkillBox\CodeSource\CodeSource Theme25\Example_2510\Example_2512\Views\ListWorkers\Index.cshtml"
               Write(Model[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(597, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(625, 12, false);
#line 23 "D:\Work\SkillBox\CodeSource\CodeSource Theme25\Example_2510\Example_2512\Views\ListWorkers\Index.cshtml"
               Write(Model[i].Age);

#line default
#line hidden
                EndContext();
                BeginContext(637, 29, true);
                WriteLiteral("</th>\r\n                <th>$ ");
                EndContext();
                BeginContext(667, 15, false);
#line 24 "D:\Work\SkillBox\CodeSource\CodeSource Theme25\Example_2510\Example_2512\Views\ListWorkers\Index.cshtml"
                 Write(Model[i].Salary);

#line default
#line hidden
                EndContext();
                BeginContext(682, 28, true);
                WriteLiteral("</th>\r\n\r\n            </tr>\r\n");
                EndContext();
#line 27 "D:\Work\SkillBox\CodeSource\CodeSource Theme25\Example_2510\Example_2512\Views\ListWorkers\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(721, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(742, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Worker>> Html { get; private set; }
    }
}
#pragma warning restore 1591
