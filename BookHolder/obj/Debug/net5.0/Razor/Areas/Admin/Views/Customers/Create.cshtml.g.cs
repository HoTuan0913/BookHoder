#pragma checksum "C:\Users\DELL\Desktop\DaAn_TotNghiep\DA_TotNghiep\BookHolder\BookHolder\BookHolder\BookHolder\Areas\Admin\Views\Customers\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1c5ae0c31e147db4cc59913354b348b99b0a106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Customers_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Customers/Create.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\DaAn_TotNghiep\DA_TotNghiep\BookHolder\BookHolder\BookHolder\BookHolder\Areas\Admin\Views\_ViewImports.cshtml"
using BookHolder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\DaAn_TotNghiep\DA_TotNghiep\BookHolder\BookHolder\BookHolder\BookHolder\Areas\Admin\Views\_ViewImports.cshtml"
using BookHolder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c5ae0c31e147db4cc59913354b348b99b0a106", @"/Areas/Admin/Views/Customers/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bca1c91d4447ad9419318eddb88b3b353da98e8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Customers_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookHolder.Areas.Admin.Models.Customers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("min-width: 200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("checked", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL\Desktop\DaAn_TotNghiep\DA_TotNghiep\BookHolder\BookHolder\BookHolder\BookHolder\Areas\Admin\Views\Customers\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page Container START -->
<div class=""page-container"">


    <!-- Content Wrapper START -->
    <div class=""main-content"">
        <div class=""page-header"">
            <div class=""header-sub-title"">
                <nav class=""breadcrumb breadcrumb-dash"">
                    <a href=""#"" class=""breadcrumb-item""><i class=""anticon anticon-home m-r-5""></i>Home</a>
                    <a class=""breadcrumb-item"" href=""#"">Components</a>
                    <span class=""breadcrumb-item active"">Tabs</span>
                </nav>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-body"">
                <h4>From Tạo sản phẩm</h4>
                <div class=""m-t-25"">
                    <ul class=""nav nav-tabs nav-justified"" id=""myTabJustified"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""home-tab-justified"" data-toggle=""tab"" href=""#home-justified"" role=""tab"" aria-controls=""home-j");
            WriteLiteral(@"ustified"" aria-selected=""true"">Home</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""profile-tab-justified"" data-toggle=""tab"" href=""#profile-justified"" role=""tab"" aria-controls=""profile-justified"" aria-selected=""false"">Profile</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""contact-tab-justified"" data-toggle=""tab"" href=""#contact-justified"" role=""tab"" aria-controls=""contact-justified"" aria-selected=""false"">Contact</a>
                        </li>
                    </ul>
");
            WriteLiteral(@"                    <div class=""tab-content m-t-15"" id=""myTabContentJustified"">
                        <div class=""tab-pane fade show active"" id=""home-justified"" aria-labelledby=""home-tab-justified"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1c5ae0c31e147db4cc59913354b348b99b0a1068277", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 53 "C:\Users\DELL\Desktop\DaAn_TotNghiep\DA_TotNghiep\BookHolder\BookHolder\BookHolder\BookHolder\Areas\Admin\Views\Customers\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <div class=""form-group"">
                                        <label class=""font-weight-semibold"" for=""productName"">Tên sản phẩm</label>
                                        <input type=""text"" class=""form-control"" >
                                    </div>
                                    <div class=""form-group"">
                                        <label class=""font-weight-semibold"" for=""productBrand"">Ảnh đại diện</label>
                                        <input name=""fThumb"" type=""file"" class=""form-control-file""  />
                                        <span  class=""text-danger""></span>
                                    </div>
                                    <div class=""row"">
                                        <div class=""form-group col-md-6"">
                                            <label class=""font-weight-semibold"" for=""productPrice"">Giá bán</label>
                                            <input type=""text"" class");
            WriteLiteral(@"=""form-control"" >
                                        </div>
                                        <div class=""form-group col-md-6"">
                                            <label class=""font-weight-semibold"" for=""productPrice"">Giảm Giá</label>
");
            WriteLiteral(@"                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""profile-justified"" role=""tabpanel"" aria-labelledby=""profile-tab-justified"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""form-group col-6"">
                                            <label class=""font-weight-semibold"" for=""productCategory"">Danh mục sản phẩm</label>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1c5ae0c31e147db4cc59913354b348b99b0a10612077", async() => {
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1c5ae0c31e147db4cc59913354b348b99b0a10612386", async() => {
                    WriteLiteral("Chọn danh mục");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 82 "C:\Users\DELL\Desktop\DaAn_TotNghiep\DA_TotNghiep\BookHolder\BookHolder\BookHolder\BookHolder\Areas\Admin\Views\Customers\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.productTypeId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                        <div class=""form-group col-6"">
                                            <label class=""font-weight-semibold"" for=""productName"">Tác Giả</label>
                                            <input type=""text"" class=""form-control"" >
                                        </div>
                                        <div class=""form-group col-6"">
                                            <label class=""font-weight-semibold"" for=""productName"">Số Lượng</label>
                                            <input type=""text"" class=""form-control"" >
                                        </div>
                                        <div class=""form-group col-6"">
                                            <label class=""font-weight-semibold"" for=""productBrand"">Ảnh Chi Tiết</label>
");
            WriteLiteral(@"                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""m-t-25"">
                                            <div class=""form-group d-flex align-items-center"">
                                                <div class=""switch m-r-10"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a1c5ae0c31e147db4cc59913354b348b99b0a10617079", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 104 "C:\Users\DELL\Desktop\DaAn_TotNghiep\DA_TotNghiep\BookHolder\BookHolder\BookHolder\BookHolder\Areas\Admin\Views\Customers\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Status);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                    <label for=""Status""></label>
                                                </div>
                                                <label>Trang Thái</label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""contact-justified"" role=""tabpanel"" aria-labelledby=""contact-tab-justified"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <textarea class=""summernote"" ");
            WriteLiteral(@"></textarea>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Content Wrapper END -->   
</div>
<!-- Page Container END -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookHolder.Areas.Admin.Models.Customers> Html { get; private set; }
    }
}
#pragma warning restore 1591
