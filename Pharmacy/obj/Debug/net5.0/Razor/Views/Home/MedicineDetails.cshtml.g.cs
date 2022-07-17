#pragma checksum "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\MedicineDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a61758237f27f24754788538e74841e807edb5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MedicineDetails), @"mvc.1.0.view", @"/Views/Home/MedicineDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a61758237f27f24754788538e74841e807edb5a", @"/Views/Home/MedicineDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec1fa82c30f4297a4f544e7b8da6148ece18b2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MedicineDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Medicine>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\MedicineDetails.cshtml"
  
    ViewData["Title"] = "Medicine Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a61758237f27f24754788538e74841e807edb5a3466", async() => {
                WriteLiteral(@"
    <!-- meta -->
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"" />

    <!-- links -->
    <link rel=""stylesheet"" href=""/Bootstrap 5/dist/css/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""/Home/style.css"" />
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a61758237f27f24754788538e74841e807edb5a4791", async() => {
                WriteLiteral("\r\n    <!-- Start ProductDetails-->\r\n    <div class=\"container\">\r\n        <div class=\"ProductDetails mt-5\">\r\n            <div class=\"row row-cols-lg-2 row-cols-1 g-5\">\r\n                <div class=\"col ItemDetails\">\r\n                    <h2>");
#nullable restore
#line 23 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\MedicineDetails.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 24 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\MedicineDetails.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <div>\r\n                        <h5>Price:</h5><b>");
#nullable restore
#line 26 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\MedicineDetails.cshtml"
                                     Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" $</b>\r\n                    </div>\r\n                    <div>\r\n                        <h5>Category:</h5><b>");
#nullable restore
#line 29 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\MedicineDetails.cshtml"
                                        Write(Model.ManufactureCompany.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col ItemImg\">\r\n                    <img");
                BeginWriteAttribute("src", " src=", 1119, "", 1136, 1);
#nullable restore
#line 33 "C:\Users\m.kalas\Desktop\Pharmacy\Pharmacy\Views\Home\MedicineDetails.cshtml"
WriteAttributeValue("", 1124, Model.Image, 1124, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"700\" height=\"700\"\r\n                         alt=\"Card image\"\r\n                         class=\"img-thumbnail\" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Medicine> Html { get; private set; }
    }
}
#pragma warning restore 1591