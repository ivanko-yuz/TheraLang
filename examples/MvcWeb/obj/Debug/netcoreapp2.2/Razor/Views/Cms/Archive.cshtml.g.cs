#pragma checksum "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3171f50d956976c9cce7388a68dac690e7ed506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Archive), @"mvc.1.0.view", @"/Views/Cms/Archive.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cms/Archive.cshtml", typeof(AspNetCore.Views_Cms_Archive))]
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
#line 2 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
using System.Globalization;

#line default
#line hidden
#line 3 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
using Piranha;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3171f50d956976c9cce7388a68dac690e7ed506", @"/Views/Cms/Archive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"107f1184d77f80a4fa29c7df5bfcea3406f2da9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Archive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcWeb.Models.BlogArchive>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
  
    ViewBag.Title = Model.Title;

    Func<string> BlogLink = () => {
        return Model.Permalink
            + (Model.Archive.Category != null ? $"/category/{Model.Archive.Category.Slug}"  : "")
            + (Model.Archive.Year.HasValue ? $"/{Model.Archive.Year}" : "" )
            + (Model.Archive.Month.HasValue ? $"/{Model.Archive.Month}" : "");
    };

    Func<string> MonthName = () => {
        if (Model.Archive.Month.HasValue) {
            return new DateTime(2018, Model.Archive.Month.Value, 1) .ToString("MMMM", CultureInfo.InvariantCulture);
        }
        return "";
    };

    Func<Piranha.Models.DynamicPost, Piranha.Extend.Blocks.HtmlBlock> GetFirstHtmlBlock = (post) => 
    {
        foreach (var block in post.Blocks)
        {
            if (block is Piranha.Extend.Blocks.HtmlBlock)
            {
                return (Piranha.Extend.Blocks.HtmlBlock)block;
            }
        }
        return null;
    };

#line default
#line hidden
            BeginContext(1058, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1061, 28, false);
#line 34 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
Write(Html.DisplayFor(m => m.Hero));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 142, true);
            WriteLiteral("\r\n\r\n<div class=\"container body-container\">\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"col-lg-8 col-md-10 col-xs-12\">\r\n");
            EndContext();
#line 39 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
             foreach (var post in Model.Archive.Posts) 
            {

#line default
#line hidden
            BeginContext(1303, 108, true);
            WriteLiteral("                <article class=\"archive-item\">\r\n                    <header>\r\n                        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1411, "\"", 1433, 1);
#line 43 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1418, post.Permalink, 1418, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1434, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1436, 10, false);
#line 43 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
                                                 Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1446, 127, true);
            WriteLiteral("</a></h2>\r\n                    </header>\r\n                    <p class=\"small\">\r\n                        <strong>In</strong> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1573, "\"", 1614, 2);
            WriteAttributeValue("", 1580, "/blog/category/", 1580, 15, true);
#line 46 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1595, post.Category.Slug, 1595, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1615, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1617, 19, false);
#line 46 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
                                                                                    Write(post.Category.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1636, 86, true);
            WriteLiteral("</a> <span class=\"sep\">&#9670;</span>\r\n                        <strong>Tags</strong>\r\n");
            EndContext();
#line 48 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
                         foreach (var tag in post.Tags)
                        {

#line default
#line hidden
            BeginContext(1806, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1836, "\"", 1862, 2);
            WriteAttributeValue("", 1843, "/blog/tag/", 1843, 10, true);
#line 50 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1853, tag.Slug, 1853, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1863, 2, true);
            WriteLiteral(">#");
            EndContext();
            BeginContext(1866, 9, false);
#line 50 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
                                                      Write(tag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1875, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 51 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
                        }

#line default
#line hidden
            BeginContext(1908, 109, true);
            WriteLiteral("                        <span class=\"sep\">&#9670;</span>\r\n                        <strong>Published</strong> ");
            EndContext();
            BeginContext(2018, 43, false);
#line 53 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
                                              Write(post.Published.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(2061, 28, true);
            WriteLiteral("\r\n                    </p>\r\n");
            EndContext();
#line 55 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
                     if (post.Regions.Hero.PrimaryImage.Media != null)
                    {

#line default
#line hidden
            BeginContext(2184, 28, true);
            WriteLiteral("                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2212, "\"", 2278, 1);
#line 57 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2218, Url.Content(post.Regions.Hero.PrimaryImage.Media.PublicUrl), 2218, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2279, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 58 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
                    }

#line default
#line hidden
            BeginContext(2305, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2326, 45, false);
#line 59 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
               Write(Html.Raw(GetFirstHtmlBlock(post)?.Body ?? ""));

#line default
#line hidden
            EndContext();
            BeginContext(2371, 26, true);
            WriteLiteral("\r\n\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2397, "\"", 2419, 1);
#line 61 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2404, post.Permalink, 2404, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2420, 75, true);
            WriteLiteral(" class=\"btn btn-sm btn-default\">Read more</a>\r\n                </article>\r\n");
            EndContext();
#line 63 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
            }

#line default
#line hidden
            BeginContext(2510, 34, true);
            WriteLiteral("        </div>    \r\n    </div>\r\n\r\n");
            EndContext();
#line 67 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
     if (Model.Archive.TotalPages > 1) 
    {

#line default
#line hidden
            BeginContext(2592, 262, true);
            WriteLiteral(@"        <div class=""row"">
            <div class=""col"">
                <nav aria-label=""Page navigation"">
                <ul class=""pagination justify-content-center"">
                    <li class=""page-item"">
                        <a class=""page-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2854, "\"", 2879, 2);
#line 74 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2861, BlogLink(), 2861, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2872, "/page/1", 2872, 7, true);
            EndWriteAttribute();
            BeginContext(2880, 284, true);
            WriteLiteral(@">
                            <span aria-hidden=""true"">&laquo;</span>
                            <span class=""sr-only"">Previous</span>
                        </a>
                    </li>
                    <li class=""page-item"">
                        <a class=""page-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3164, "\"", 3231, 3);
#line 80 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3171, BlogLink(), 3171, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3182, "/page/", 3182, 6, true);
#line 80 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3188, Math.Max(1, Model.Archive.CurrentPage - 1), 3188, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3232, 197, true);
            WriteLiteral(">\r\n                            <span aria-hidden=\"true\">&lsaquo;</span>\r\n                            <span class=\"sr-only\">Previous</span>\r\n                        </a>\r\n                    </li>\r\n");
            EndContext();
#line 85 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
                     for (var n = 1; n <= Model.Archive.TotalPages; n++) 
                    {

#line default
#line hidden
            BeginContext(3527, 27, true);
            WriteLiteral("                        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3554, "\"", 3621, 2);
            WriteAttributeValue("", 3562, "page-item", 3562, 9, true);
#line 87 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue(" ", 3571, Model.Archive.CurrentPage == n ? "active" : "", 3572, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3622, 21, true);
            WriteLiteral("><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3643, "\"", 3669, 3);
#line 87 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3650, BlogLink(), 3650, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3661, "/page/", 3661, 6, true);
#line 87 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3667, n, 3667, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3670, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3672, 1, false);
#line 87 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
                                                                                                                                           Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(3673, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 88 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
                    }

#line default
#line hidden
            BeginContext(3707, 88, true);
            WriteLiteral("                    <li class=\"page-item\">\r\n                        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3795, "\"", 3885, 3);
#line 90 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3802, BlogLink(), 3802, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3813, "/page/", 3813, 6, true);
#line 90 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3819, Math.Min(Model.Archive.TotalPages, Model.Archive.CurrentPage + 1), 3819, 66, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3886, 305, true);
            WriteLiteral(@">
                            <span aria-hidden=""true"">&rsaquo;</span>
                            <span class=""sr-only"">Next</span>                        
                        </a>
                    </li>
                    <li class=""page-item"">
                        <a class=""page-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4191, "\"", 4240, 3);
#line 96 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4198, BlogLink(), 4198, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 4209, "/page/", 4209, 6, true);
#line 96 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4215, Model.Archive.TotalPages, 4215, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4241, 307, true);
            WriteLiteral(@">
                            <span aria-hidden=""true"">&raquo;</span>
                            <span class=""sr-only"">Next</span>                        
                        </a>
                    </li>
                </ul>
                </nav>
            </div>
        </div>        
");
            EndContext();
#line 105 "D:\GIT\TheraLang\TheraLang\examples\MvcWeb\Views\Cms\Archive.cshtml"
    }

#line default
#line hidden
            BeginContext(4555, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcWeb.Models.BlogArchive> Html { get; private set; }
    }
}
#pragma warning restore 1591
