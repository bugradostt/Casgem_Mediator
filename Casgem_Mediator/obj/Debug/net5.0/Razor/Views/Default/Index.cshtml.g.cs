#pragma checksum "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bc36d943ecfc53b8864fd720aa5b8d1838330e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
#line 1 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\_ViewImports.cshtml"
using Casgem_Mediator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\_ViewImports.cshtml"
using Casgem_Mediator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc36d943ecfc53b8864fd720aa5b8d1838330e6", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62189fd8225a553ea39c1cac63db290c15f5c021", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Casgem_Mediator.MeditorPattern.Results.GetProductQueryResult>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0bc36d943ecfc53b8864fd720aa5b8d1838330e64243", async() => {
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
            WriteLiteral(@"

<div class=""container"">
    <br />
    <br />
    <a class=""btn btn-success"" href=""/Default/AddProduct/"">Ekle</a>

    <br />
    <br />

    <table class=""table table-striped"">
        <tr>
            <th>#</th>
            <th>Ürün</th>
            <th>Marka</th>
            <th>Kategori</th>
            <th>Stok</th>
            <th>Fiyat</th>
            <th></th>
            <th></th>
        </tr>

");
#nullable restore
#line 28 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml"
          int a=1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml"
         foreach (var i in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th>");
#nullable restore
#line 32 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml"
               Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml"
               Write(i.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml"
               Write(i.ProductBrand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml"
               Write(i.ProductCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml"
               Write(i.ProductStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml"
               Write(i.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                <td>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1004, "\"", 1046, 2);
            WriteAttributeValue("", 1011, "/Default/DeleteProduct/", 1011, 23, true);
#nullable restore
#line 39 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml"
WriteAttributeValue("", 1034, i.ProductId, 1034, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a>\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1148, "\"", 1190, 2);
            WriteAttributeValue("", 1155, "/Default/UpdateProduct/", 1155, 23, true);
#nullable restore
#line 42 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml"
WriteAttributeValue("", 1178, i.ProductId, 1178, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a>\r\n                </td>\r\n            </tr>\n");
#nullable restore
#line 45 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_Mediator\Casgem_Mediator\Views\Default\Index.cshtml"

            a++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Casgem_Mediator.MeditorPattern.Results.GetProductQueryResult>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
