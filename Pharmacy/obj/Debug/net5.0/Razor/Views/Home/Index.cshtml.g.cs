#pragma checksum "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aff35886ca4fe0d16e7edcd0abb23c03ebf13be"
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
#line 1 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\_ViewImports.cshtml"
using Pharmacy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\_ViewImports.cshtml"
using Pharmacy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aff35886ca4fe0d16e7edcd0abb23c03ebf13be", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec1fa82c30f4297a4f544e7b8da6148ece18b2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medicine>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/style.css?v=1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary w-50 mb-3 ms-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MedicineDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aff35886ca4fe0d16e7edcd0abb23c03ebf13be5392", async() => {
                WriteLiteral("\r\n    <!-- meta -->\r\n    <meta charset=\"UTF-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\" />\r\n\r\n    <!-- links -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6aff35886ca4fe0d16e7edcd0abb23c03ebf13be5886", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aff35886ca4fe0d16e7edcd0abb23c03ebf13be7768", async() => {
                WriteLiteral(@"

    <!--Start carousel-->
    <div class=""container-fluid mt-3"" style=""height:80vh"">
        <div id=""demo"" class=""carousel slide"" data-bs-ride=""carousel"">
            <!-- Indicators/dots -->
            <div class=""carousel-indicators"">
                <button type=""button""
                        data-bs-target=""#demo""
                        data-bs-slide-to=""0""
                        class=""active""></button>
                <button type=""button""
                        data-bs-target=""#demo""
                        data-bs-slide-to=""1""></button>
                <button type=""button""
                        data-bs-target=""#demo""
                        data-bs-slide-to=""2""></button>
            </div>

            <!-- The slideshow/carousel -->
            <div class=""carousel-inner"">
                <div class=""carousel-item"">
                    <img src=""https://images.pexels.com/photos/4021811/pexels-photo-4021811.jpeg?auto=compress&cs=tinysrgb&w=1600""
                     ");
                WriteLiteral(@"    alt=""New York""
                         class=""d-block""
                         style=""width: 100%;height:80vh;"" />
                </div>
                <div class=""carousel-item"">
                    <img src=""https://images.pexels.com/photos/356040/pexels-photo-356040.jpeg?auto=compress&cs=tinysrgb&w=1600""
                         alt=""Chicago""
                         class=""d-block""
                         style=""width: 100%;height:80vh;"" />
                </div>
                <div class=""carousel-item active"">
                    <img src=""	https://images.pexels.com/photos/3652103/pexels-photo-3652103.jpeg?auto=compress&cs=tinysrgb&w=1600""
                         alt=""Image 1""
                         class=""d-block ""
                         style=""width: 100%;
                           height:80vh"" />
                </div>
            </div>

            <!-- Left and right controls/icons -->
            <button class=""carousel-control-prev""
                    type=""");
                WriteLiteral(@"button""
                    data-bs-target=""#demo""
                    data-bs-slide=""prev"">
                <span class=""carousel-control-prev-icon""></span>
            </button>
            <button class=""carousel-control-next""
                    type=""button""
                    data-bs-target=""#demo""
                    data-bs-slide=""next"">
                <span class=""carousel-control-next-icon""></span>
            </button>
        </div>
    </div>

    <!-- Start Products-->
    <div class=""Products mt-5"">
");
#nullable restore
#line 76 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\Index.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <!-- Start HeaderProduct-->\r\n            <div class=\"HeaderProduct\">\r\n                <h2>More Than 1,000 Medicine</h2>\r\n                <h6>The best Medicines you can find here at the right price</h6>\r\n            </div>\r\n");
                WriteLiteral("            <!-- Start Products Cards -->\r\n            <div class=\"container\">\r\n                <div class=\"row row-cols-2 row-cols-lg-5 row-cols-md-3 g-2\">\r\n\r\n");
#nullable restore
#line 88 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\Index.cshtml"
                     foreach (Medicine item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col\">\r\n                            <div class=\"card h-100\">\r\n                                <img class=\"card-img-top  h-50\"");
                BeginWriteAttribute("src", "\r\n                                     src=\"", 3663, "\"", 3718, 1);
#nullable restore
#line 93 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\Index.cshtml"
WriteAttributeValue("", 3707, item.Image, 3707, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                     alt=\"Card image\" />\r\n                                <div class=\"card-body\">\r\n                                    <h4 class=\"card-title\">");
#nullable restore
#line 96 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\Index.cshtml"
                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                    <p class=\"card-text\">\r\n                                        ");
#nullable restore
#line 98 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\Index.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </p>\r\n\r\n                                </div>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aff35886ca4fe0d16e7edcd0abb23c03ebf13be13201", async() => {
                    WriteLiteral("More Details");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\Index.cshtml"
                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 108 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 112 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"ErrorSearch\">\r\n                <h1>500</h1>\r\n                <h3>Internal Server Error</h3>\r\n                <h6>The Product is not available, Please try again later</h6>\r\n            </div>\r\n");
#nullable restore
#line 120 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medicine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
