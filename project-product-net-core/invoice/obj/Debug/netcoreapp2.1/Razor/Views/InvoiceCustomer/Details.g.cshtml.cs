#pragma checksum "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8574cf4d97cfea6d6f8d7484310e52651e56ad6c"
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
#line 1 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\_ViewImports.cshtml"
using invoice;

#line default
#line hidden
#line 2 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\_ViewImports.cshtml"
using invoice.Models;

#line default
#line hidden
#line 3 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\_ViewImports.cshtml"
using invoice.Models.viewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8574cf4d97cfea6d6f8d7484310e52651e56ad6c", @"/Views/InvoiceCustomer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b7debf74c450f3b152c1fb7a05df9311811ee5f", @"/Views/_ViewImports.cshtml")]
    public class Views_InvoiceCustomer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<invoice.Models.viewModel.InvoiceView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
  
    ViewBag.Title = "Details invoice customer";

#line default
#line hidden
            BeginContext(105, 52, true);
            WriteLiteral("\r\n<h2></h2>\r\n\r\n<div>\r\n    <h4>Hóa Đơn Khách hàng  - ");
            EndContext();
            BeginContext(158, 20, false);
#line 11 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
                         Write(Model.TEN_KHACH_HANG);

#line default
#line hidden
            EndContext();
            BeginContext(178, 77, true);
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(256, 41, false);
#line 15 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ID_SP));

#line default
#line hidden
            EndContext();
            BeginContext(297, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(341, 37, false);
#line 18 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayFor(model => model.ID_SP));

#line default
#line hidden
            EndContext();
            BeginContext(378, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(422, 43, false);
#line 21 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MOTA_SP));

#line default
#line hidden
            EndContext();
            BeginContext(465, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(509, 39, false);
#line 24 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayFor(model => model.MOTA_SP));

#line default
#line hidden
            EndContext();
            BeginContext(548, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(592, 39, false);
#line 27 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GIA));

#line default
#line hidden
            EndContext();
            BeginContext(631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(675, 35, false);
#line 30 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayFor(model => model.GIA));

#line default
#line hidden
            EndContext();
            BeginContext(710, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(754, 43, false);
#line 33 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SOLUONG));

#line default
#line hidden
            EndContext();
            BeginContext(797, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(841, 39, false);
#line 36 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayFor(model => model.SOLUONG));

#line default
#line hidden
            EndContext();
            BeginContext(880, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(926, 48, false);
#line 40 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ID_KHACHHANG));

#line default
#line hidden
            EndContext();
            BeginContext(974, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1018, 44, false);
#line 43 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayFor(model => model.ID_KHACHHANG));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1106, 54, false);
#line 46 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DIA_CHI_KHACH_HANG));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1204, 50, false);
#line 49 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayFor(model => model.DIA_CHI_KHACH_HANG));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1298, 50, false);
#line 52 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TEN_KHACH_HANG));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1392, 46, false);
#line 55 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayFor(model => model.TEN_KHACH_HANG));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1482, 45, false);
#line 58 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ID_HOADON));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1571, 41, false);
#line 61 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayFor(model => model.ID_HOADON));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1656, 43, false);
#line 64 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NGAYBAN));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1743, 39, false);
#line 67 "E:\Anglar 5\FirebaseDemo\invoice\project-product-net-core\invoice\Views\InvoiceCustomer\Details.cshtml"
       Write(Html.DisplayFor(model => model.NGAYBAN));

#line default
#line hidden
            EndContext();
            BeginContext(1782, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1829, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b547fdab36ea4fa0afd0f84ebe3f7d3e", async() => {
                BeginContext(1851, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1867, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<invoice.Models.viewModel.InvoiceView> Html { get; private set; }
    }
}
#pragma warning restore 1591
