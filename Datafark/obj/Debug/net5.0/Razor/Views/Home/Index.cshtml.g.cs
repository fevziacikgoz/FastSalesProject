#pragma checksum "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a8a19d1703de0ae58646ea962fbf153ff1038a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\_ViewImports.cshtml"
using Datafark;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\_ViewImports.cshtml"
using Datafark.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
using DAL.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a8a19d1703de0ae58646ea962fbf153ff1038a5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f549f48ed62b0d40ddeea001528bab6aa482ce4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/product.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a8a19d1703de0ae58646ea962fbf153ff1038a54807", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a8a19d1703de0ae58646ea962fbf153ff1038a55921", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 237, "~/js/jsevent.js?", 237, 16, true);
#nullable restore
#line 9 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 253, DateTime.Now.Ticks, 253, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
 if(Model.Count > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container page-wrapper\">\r\n            <div class=\"page-inner\">\r\n                <div class=\"row\">\r\n                    <div class=\"el-wrapper\">\r\n                        <div class=\"box-up\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                             if (item.ProductImages.Count > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img class=\"img\"");
            BeginWriteAttribute("src", " src=\"", 709, "\"", 761, 1);
#nullable restore
#line 23 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
WriteAttributeValue("", 715, item.ProductImages.FirstOrDefault().ImagePath, 715, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 24 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a8a19d1703de0ae58646ea962fbf153ff1038a59089", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"img-info\">\r\n                                <div class=\"info-inner\">\r\n");
#nullable restore
#line 31 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                                     if (item.IsVariant == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"bi bi-info-circle\"></i>\r\n");
#nullable restore
#line 34 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"p-name\">");
#nullable restore
#line 35 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"p-company\">");
#nullable restore
#line 36 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                                                       Write(item.ProductSkus.FirstOrDefault().Barcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n");
#nullable restore
#line 38 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                                 if (item.IsVariant == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"a-size\"> Varyantlı Ürün : <span class=\"size\">");
#nullable restore
#line 40 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                                                                                        Write(string.Join(",", item.ProductSkus.ToList().Select(s => s.VariantPath)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></div>\r\n");
#nullable restore
#line 41 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>

                        <div class=""box-down"">
                            <div class=""h-bg"">
                                <div class=""h-bg-inner""></div>
                            </div>
");
#nullable restore
#line 50 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                             if (item.IsVariant == false)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"cart\" href=\"#\" data-id=\"");
#nullable restore
#line 52 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                                                             Write(item.ProductSkus.FirstOrDefault().Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <span class=\"price\">Fiyat : ");
#nullable restore
#line 53 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                                                           Write(item.ProductSkus.FirstOrDefault().ProductSkuPrices.Where(w=>w.ProductSkuPriceTypeId==2).FirstOrDefault().Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"add-to-cart\">\r\n                                        <span class=\"txt\">Sepete Ekle</span>\r\n                                    </span>\r\n                                </a>\r\n");
#nullable restore
#line 58 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"cartvariant\" href=\"#\" data-id=\"");
#nullable restore
#line 62 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <span class=\"price\">Fiyat : ");
#nullable restore
#line 63 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                                                           Write(item.ProductSkus.FirstOrDefault().ProductSkuPrices.Where(w=>w.ProductSkuPriceTypeId==2).FirstOrDefault().Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"add-to-cart\">\r\n                                        <span class=\"txt\">Sepete Ekle</span>\r\n                                    </span>\r\n                                </a>\r\n");
#nullable restore
#line 68 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 75 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"  position: fixed;height: 50px;padding: 5px;top: 135px;\">\r\n        ");
#nullable restore
#line 77 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
   Write(Html.PagedListPager((IPagedList)Model,page=>  Url.Action("Index" , new { page = page }),
    new PagedListRenderOptions
    {
    ContainerDivClasses = new[] { "navigation" },
    LiElementClasses = new[] { "page-item" },
    PageClasses = new[] { "page-link" },
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 85 "C:\Users\fevzi\source\repos\hizlisatis\Datafark\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             \r\n\r\n\r\n<script type=\"text/javascript\">\r\n    \r\n</script>\r\n    <style type=\"text/css\">\r\n       \r\n\r\n    </style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
