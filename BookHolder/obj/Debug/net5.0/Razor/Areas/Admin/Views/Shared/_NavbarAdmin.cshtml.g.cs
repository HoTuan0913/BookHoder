#pragma checksum "A:\DA_TotNghiep\BookHolder\BookHolder\Areas\Admin\Views\Shared\_NavbarAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3adb3a7675952b563a9cb63043c39956f4e91a8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__NavbarAdmin), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_NavbarAdmin.cshtml")]
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
#line 1 "A:\DA_TotNghiep\BookHolder\BookHolder\Areas\Admin\Views\_ViewImports.cshtml"
using BookHolder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\DA_TotNghiep\BookHolder\BookHolder\Areas\Admin\Views\_ViewImports.cshtml"
using BookHolder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3adb3a7675952b563a9cb63043c39956f4e91a8f", @"/Areas/Admin/Views/Shared/_NavbarAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bca1c91d4447ad9419318eddb88b3b353da98e8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__NavbarAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"iq-sidebar\">\r\n    <div class=\"iq-sidebar-logo d-flex justify-content-between\">\r\n        <a href=\"admin-dashboard.html\" class=\"header-logo\">\r\n            <img src=\"images/logo.png\" class=\"img-fluid rounded-normal\"");
            BeginWriteAttribute("alt", " alt=\"", 224, "\"", 230, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""logo-title"">
                <span class=""text-primary text-uppercase"">NhasachTV</span>
            </div>
        </a>
        <div class=""iq-menu-bt-sidebar"">
            <div class=""iq-menu-bt align-self-center"">
                <div class=""wrapper-menu"">
                    <div class=""main-circle""><i class=""las la-bars""></i></div>
                </div>
            </div>
        </div>
    </div>
    <div id=""sidebar-scrollbar"">
        <nav class=""iq-sidebar-menu"">
            <ul id=""iq-sidebar-toggle"" class=""iq-menu"">
                <li><a href=""admin-dashboard.html""><i class=""las la-home iq-arrow-left""></i>Bảng Điều Khiển</a></li>
                <li><a href=""admin-category.html""><i class=""ri-record-circle-line""></i>Danh Mục Sách</a></li>
                <li><a href=""admin-author.html""><i class=""ri-record-circle-line""></i>Tác Giả</a></li>
                <li><a href=""admin-books.html""><i class=""ri-record-circle-line""></i>Sách</a></li>
                <l");
            WriteLiteral(@"i><a href=""sign-in.html""><i class=""ri-record-circle-line""></i>Đăng Xuất</a></li>
            </ul>
        </nav>
        <div id=""sidebar-bottom"" class=""p-3 position-relative"">
            <div class=""iq-card"">
                <div class=""iq-card-body"">
                    <div class=""sidebarbottom-content"">
                        <button type=""submit"" class=""btn w-100 btn-primary mt-4 view-more"">NhasachTV</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591