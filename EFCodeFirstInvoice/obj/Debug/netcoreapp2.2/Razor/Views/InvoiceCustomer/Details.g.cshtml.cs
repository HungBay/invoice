#pragma checksum "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\InvoiceCustomer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1325d390ab36be9aed24dde4a9269141c8f2d161"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvoiceCustomer_Details), @"mvc.1.0.view", @"/Views/InvoiceCustomer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InvoiceCustomer/Details.cshtml", typeof(AspNetCore.Views_InvoiceCustomer_Details))]
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
#line 1 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\_ViewImports.cshtml"
using EFCodeFirstInvoice;

#line default
#line hidden
#line 2 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\_ViewImports.cshtml"
using EFCodeFirstInvoice.Models;

#line default
#line hidden
#line 3 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\_ViewImports.cshtml"
using EFCodeFirstInvoice.Models.viewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1325d390ab36be9aed24dde4a9269141c8f2d161", @"/Views/InvoiceCustomer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"004b51a152d804eca72b60aa096761e0fd748ca9", @"/Views/_ViewImports.cshtml")]
    public class Views_InvoiceCustomer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InvoiceView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\InvoiceCustomer\Details.cshtml"
  
    ViewBag.Title = "Detail Customer Invoice";


#line default
#line hidden
            BeginContext(92, 204, true);
            WriteLiteral("<div class=\"col-md-12\">\r\n    <div class=\"row\">\r\n        <table class=\"table\">\r\n            <thead class=\"thead-light\">\r\n                <tr>\r\n                    <th scope=\"col\">\r\n                        ");
            EndContext();
            BeginContext(297, 45, false);
#line 13 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\InvoiceCustomer\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.ID_HOADON));

#line default
#line hidden
            EndContext();
            BeginContext(342, 91, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">\r\n                        ");
            EndContext();
            BeginContext(434, 43, false);
#line 16 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\InvoiceCustomer\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.MOTA_SP));

#line default
#line hidden
            EndContext();
            BeginContext(477, 91, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">\r\n                        ");
            EndContext();
            BeginContext(569, 39, false);
#line 19 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\InvoiceCustomer\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.GIA));

#line default
#line hidden
            EndContext();
            BeginContext(608, 91, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">\r\n                        ");
            EndContext();
            BeginContext(700, 43, false);
#line 22 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\InvoiceCustomer\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.SOLUONG));

#line default
#line hidden
            EndContext();
            BeginContext(743, 212, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\" class=\"text-center\">\r\n                        Action\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 30 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\InvoiceCustomer\Details.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1020, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1105, 44, false);
#line 34 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\InvoiceCustomer\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ID_HOADON));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1241, 42, false);
#line 37 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\InvoiceCustomer\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MOTA_SP));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1375, 38, false);
#line 40 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\InvoiceCustomer\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.GIA));

#line default
#line hidden
            EndContext();
            BeginContext(1413, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1505, 42, false);
#line 43 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\InvoiceCustomer\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SOLUONG));

#line default
#line hidden
            EndContext();
            BeginContext(1547, 83, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n");
            EndContext();
            BeginContext(1773, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1801, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1325d390ab36be9aed24dde4a9269141c8f2d1618911", async() => {
                BeginContext(1847, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1863, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 50 "E:\Mon hoc\Chuyen de 1\EFCodeFirstInvoice\Views\InvoiceCustomer\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1942, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InvoiceView>> Html { get; private set; }
    }
}
#pragma warning restore 1591