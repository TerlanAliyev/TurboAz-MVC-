#pragma checksum "C:\Users\Terlan\source\repos\Turboaz\Turboaz\Views\Shared\_Layout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3cdad9efffe06954a7547f93513966c558b61ba1a2cf6eff3863dbefb2bf8966"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3cdad9efffe06954a7547f93513966c558b61ba1a2cf6eff3863dbefb2bf8966", @"/Views/Shared/_Layout.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cdad9efffe06954a7547f93513966c558b61ba1a2cf6eff3863dbefb2bf89662910", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                Write(
#nullable restore
#line 6 "C:\Users\Terlan\source\repos\Turboaz\Turboaz\Views\Shared\_Layout.cshtml"
            ViewBag.Title

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"</title>
    <script src=""https://code.jquery.com/jquery-3.7.1.js""
            integrity=""sha256-eKhayi8LEQwp4NKxN+CfCh+3qOVUtJn3QNZ0TciWLP4="" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.6.0/css/all.min.css""
          integrity=""sha512-Kc323vGBEqzTmouAECnVceyQqyqdsSiqLQISBL29aUW4U/M7pSPA/gEUZQqv1cwx4OnYxTxve5UMg5GT6L4JJg==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""turboaz.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cdad9efffe06954a7547f93513966c558b61ba1a2cf6eff3863dbefb2bf89664779", async() => {
                WriteLiteral("\r\n    <div class=\"basliq\">\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 695, "\"", 702, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <i class=\"fa-solid fa-heart-circle-check\"></i>\r\n            Seçilmişlər\r\n        </a>\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 815, "\"", 822, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-user\"></i>Giriş</a>\r\n\r\n    </div>\r\n    <nav>\r\n        <div class=\"left\">\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 934, "\"", 941, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"font-size: 18px; font-weight: 700;\">TURBO.AZ</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1014, "\"", 1021, 0);
                EndWriteAttribute();
                WriteLiteral(">Bütün elanlar</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1056, "\"", 1063, 0);
                EndWriteAttribute();
                WriteLiteral(">Salonlar</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1093, "\"", 1100, 0);
                EndWriteAttribute();
                WriteLiteral(">Moto</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1126, "\"", 1133, 0);
                EndWriteAttribute();
                WriteLiteral(">Ehtiyat hissələr və aksesuarlar</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1186, "\"", 1193, 0);
                EndWriteAttribute();
                WriteLiteral(">İcarə</a>\r\n        </div>\r\n        <div class=\"right\">\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1265, "\"", 1272, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <span>Yeni elan</span>\r\n            </a>\r\n        </div>\r\n    </nav>\r\n    <div>\r\n        ");
                Write(
#nullable restore
#line 39 "C:\Users\Terlan\source\repos\Turboaz\Turboaz\Views\Shared\_Layout.cshtml"
         RenderBody()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    </div>\r\n    <footer>\r\n        <div class=\"top\">\r\n            <div class=\"left\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1499, "\"", 1506, 0);
                EndWriteAttribute();
                WriteLiteral(">Reklam yerləşdirin</a>\r\n            </div>\r\n            <div class=\"right\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1603, "\"", 1610, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-facebook-f\"></i></a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1675, "\"", 1682, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-instagram\"></i></a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1746, "\"", 1753, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-envelope\"></i>turbo@turbo.az</a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1829, "\"", 1836, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa-solid fa-phone""></i>(012) 505-77-55</a>
            </div>
        </div>
        <div class=""bottom"">
            <div class=""left"">
                <p>
                    Saytın Administrasiyası reklam bannerlərinin və yerləşdirilmiş elanların məzmununa görə məsuliyyət
                    daşımır.
                </p>
            </div>
            <div class=""right"">
                <p>
                    2006-2024 Digital Classifieds MMC. VÖEN: 1405631661
                </p>
            </div>
        </div>
    </footer>
");
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
