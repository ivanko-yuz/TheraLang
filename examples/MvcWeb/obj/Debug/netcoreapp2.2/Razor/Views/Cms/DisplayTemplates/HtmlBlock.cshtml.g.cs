#pragma checksum "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\DisplayTemplates\HtmlBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a62634a50d9d3505616a15abb2714713139dc6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_HtmlBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/HtmlBlock.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cms/DisplayTemplates/HtmlBlock.cshtml", typeof(AspNetCore.Views_Cms_DisplayTemplates_HtmlBlock))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a62634a50d9d3505616a15abb2714713139dc6e", @"/Views/Cms/DisplayTemplates/HtmlBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"107f1184d77f80a4fa29c7df5bfcea3406f2da9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_HtmlBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Extend.Blocks.HtmlBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 27, true);
            WriteLiteral("\r\n<div class=\"block\">\r\n    ");
            EndContext();
            BeginContext(68, 20, false);
#line 4 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\DisplayTemplates\HtmlBlock.cshtml"
Write(Html.Raw(Model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(88, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Extend.Blocks.HtmlBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
