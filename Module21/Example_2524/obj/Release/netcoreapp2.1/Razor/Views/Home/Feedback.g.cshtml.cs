#pragma checksum "D:\Work\SkillBox\CodeSource\CodeSource Theme25\Example_2510\Example_2524\Views\Home\Feedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b33ed4e59d0194fb05e01799249c5d03b88b3905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Feedback), @"mvc.1.0.view", @"/Views/Home/Feedback.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Feedback.cshtml", typeof(AspNetCore.Views_Home_Feedback))]
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
#line 1 "D:\Work\SkillBox\CodeSource\CodeSource Theme25\Example_2510\Example_2524\Views\_ViewImports.cshtml"
using Example_2525.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33ed4e59d0194fb05e01799249c5d03b88b3905", @"/Views/Home/Feedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91cea17f9002331ac20f6f497d7946ca6889d8ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Feedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Work\SkillBox\CodeSource\CodeSource Theme25\Example_2510\Example_2524\Views\Home\Feedback.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Feedback";

#line default
#line hidden
            BeginContext(69, 14, true);
            WriteLiteral("\r\n<p>\r\n    <b>");
            EndContext();
            BeginContext(84, 12, false);
#line 7 "D:\Work\SkillBox\CodeSource\CodeSource Theme25\Example_2510\Example_2524\Views\Home\Feedback.cshtml"
  Write(ViewBag.Data);

#line default
#line hidden
            EndContext();
            BeginContext(96, 10, true);
            WriteLiteral("</b>\r\n</p>");
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
