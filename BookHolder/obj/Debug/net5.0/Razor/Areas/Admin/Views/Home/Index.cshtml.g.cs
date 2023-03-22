#pragma checksum "A:\DA_TotNghiep\BookHolder\BookHolder\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c749e027c756a42a07ee24318c68072ad22379bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c749e027c756a42a07ee24318c68072ad22379bb", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bca1c91d4447ad9419318eddb88b3b353da98e8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""content-page"" class=""content-page"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-6 col-lg-3"">
                <div class=""iq-card iq-card-block iq-card-stretch iq-card-height"">
                    <div class=""iq-card-body"">
                        <div class=""d-flex align-items-center"">
                            <div class=""rounded-circle iq-card-icon bg-primary""><i class=""ri-user-line""></i></div>
                            <div class=""text-left ml-3"">
                                <h2 class=""mb-0""><span class=""counter"">7900</span></h2>
                                <h5");
            BeginWriteAttribute("class", " class=\"", 648, "\"", 656, 0);
            EndWriteAttribute();
            WriteLiteral(@">Người dùng</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3"">
                <div class=""iq-card iq-card-block iq-card-stretch iq-card-height"">
                    <div class=""iq-card-body"">
                        <div class=""d-flex align-items-center"">
                            <div class=""rounded-circle iq-card-icon bg-danger""><i class=""ri-book-line""></i></div>
                            <div class=""text-left ml-3"">
                                <h2 class=""mb-0""><span class=""counter"">4.8</span>K</h2>
                                <h5");
            BeginWriteAttribute("class", " class=\"", 1354, "\"", 1362, 0);
            EndWriteAttribute();
            WriteLiteral(@">Sách</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3"">
                <div class=""iq-card iq-card-block iq-card-stretch iq-card-height"">
                    <div class=""iq-card-body"">
                        <div class=""d-flex align-items-center"">
                            <div class=""rounded-circle iq-card-icon bg-warning""><i class=""ri-shopping-cart-2-line""></i></div>
                            <div class=""text-left ml-3"">
                                <h2 class=""mb-0""><span class=""counter"">1.2</span>K</h2>
                                <h5");
            BeginWriteAttribute("class", " class=\"", 2066, "\"", 2074, 0);
            EndWriteAttribute();
            WriteLiteral(@">Đơn Hàng</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3"">
                <div class=""iq-card iq-card-block iq-card-stretch iq-card-height"">
                    <div class=""iq-card-body"">
                        <div class=""d-flex align-items-center"">
                            <div class=""rounded-circle iq-card-icon bg-info""><i class=""ri-radar-line""></i></div>
                            <div class=""text-left ml-3"">
                                <h2 class=""mb-0""><span class=""counter"">690</span></h2>
                                <h5");
            BeginWriteAttribute("class", " class=\"", 2768, "\"", 2776, 0);
            EndWriteAttribute();
            WriteLiteral(@">Chờ Duyệt</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""iq-card iq-card-block iq-card-stretch iq-card-height"">
                    <div class=""iq-card-header d-flex justify-content-between align-items-center"">
                        <div class=""iq-header-title"">
                            <h4 class=""card-title mb-0"">Doanh số hàng ngày</h4>
                        </div>
                    </div>
                    <div class=""iq-card-body"">
                        <div id=""iq-sale-chart""></div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""iq-card iq-card-block iq-card-stretch iq-card-height"">
                    <div class=""iq-card-header d-flex justify-content-between align-items-center"">
                        <div class=""iq-header-title"">
");
            WriteLiteral(@"                            <h4 class=""card-title mb-0"">Tóm lược</h4>
                        </div>
                    </div>
                    <div class=""iq-card-body"">
                        <ul class=""list-inline p-0 mb-0"">
                            <li>
                                <div class=""iq-details mb-2"">
                                    <span class=""title"">Thu nhập</span>
                                    <div class=""percentage float-right text-primary"">95 <span>%</span></div>
                                    <div class=""iq-progress-bar-linear d-inline-block w-100"">
                                        <div class=""iq-progress-bar iq-bg-primary"">
                                            <span class=""bg-primary"" data-percent=""90""></span>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li>
                             ");
            WriteLiteral(@"   <div class=""iq-details mb-2"">
                                    <span class=""title"">Lợi nhuận</span>
                                    <div class=""percentage float-right text-warning"">72 <span>%</span></div>
                                    <div class=""iq-progress-bar-linear d-inline-block w-100"">
                                        <div class=""iq-progress-bar iq-bg-warning"">
                                            <span class=""bg-warning"" data-percent=""75""></span>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class=""iq-details mb-2"">
                                    <span class=""title"">Chi phí</span>
                                    <div class=""percentage float-right text-info"">75 <span>%</span></div>
                                    <div class=""iq-progress-bar-linear d-inline-block w");
            WriteLiteral(@"-100"">
                                        <div class=""iq-progress-bar iq-bg-info"">
                                            <span class=""bg-info"" data-percent=""65""></span>
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""iq-card iq-card-block iq-card-stretch iq-card-height"">
                    <div class=""iq-card-body"">
                        <h4 class=""text-uppercase text-black mb-0"">Phiên (Bây giờ)</h4>
                        <div class=""d-flex justify-content-between align-items-center"">
                            <div class=""font-size-80 text-black"">12</div>
                            <div class=""text-left"">
                                <p class=""m-0 text-uppercase font-size-12"">1 giờ</p>
           ");
            WriteLiteral(@"                     <div class=""mb-1 text-black"">1500<span class=""text-danger""><i class=""ri-arrow-down-s-fill""></i>3.25%</span></div>
                                <p class=""m-0 text-uppercase font-size-12"">1 ngày</p>
                                <div class=""mb-1 text-black"">1890<span class=""text-success""><i class=""ri-arrow-down-s-fill""></i>1.00%</span></div>
                                <p class=""m-0 text-uppercase font-size-12"">1 tuần</p>
                                <div class=""text-black"">1260<span class=""text-danger""><i class=""ri-arrow-down-s-fill""></i>9.87%</span></div>
                            </div>
                        </div>
                        <div id=""wave-chart-7""></div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-12"">
                <div class=""iq-card iq-card-block iq-card-stretch iq-card-height"">
                    <div class=""iq-card-header d-flex justify-content-between"">
                        <di");
            WriteLiteral(@"v class=""iq-header-title"">
                            <h4 class=""card-title"">Mở hóa đơn</h4>
                        </div>
                        <div class=""iq-card-header-toolbar d-flex align-items-center"">
                            <div class=""dropdown"">
                                <span class=""dropdown-toggle text-primary"" id=""dropdownMenuButton5"" data-toggle=""dropdown"">
                                    <i class=""ri-more-fill""></i>
                                </span>
                                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuButton5"">
                                    <a class=""dropdown-item"" href=""#""><i class=""ri-eye-fill mr-2""></i>Xem</a>
                                    <a class=""dropdown-item"" href=""#""><i class=""ri-delete-bin-6-fill mr-2""></i>Xoá</a>
                                    <a class=""dropdown-item"" href=""#""><i class=""ri-pencil-fill mr-2""></i>Sửa</a>
                                    <a class=""dropdown-item""");
            WriteLiteral(@" href=""#""><i class=""ri-printer-fill mr-2""></i>In</a>
                                    <a class=""dropdown-item"" href=""#""><i class=""ri-file-download-fill mr-2""></i>Tải xuống</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""iq-card-body"">
                        <div class=""table-responsive"">
                            <table class=""table mb-0 table-borderless"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">Khách hàng</th>
                                        <th scope=""col"">Ngày</th>
                                        <th scope=""col"">Hóa đơn</th>
                                        <th scope=""col"">Số tiền</th>
                                        <th scope=""col"">Tình trạng</th>
                                        <th scope=""col"">Hoạt động</th>

                    ");
            WriteLiteral(@"                </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Ông Trần Thuận</td>
                                        <td>18/10/2019</td>
                                        <td>20156</td>
                                        <td>150.000đ</td>
                                        <td><div class=""badge badge-pill badge-success"">Đã thanh toán</div></td>
                                        <td>Sao chép</td>
                                    </tr>
                                    <tr>
                                        <td>Hoàng Vũ</td>
                                        <td>26/10/2019</td>
                                        <td>7859</td>
                                        <td>200.000đ</td>
                                        <td><div class=""badge badge-pill badge-success"">Đã thanh toán</div></td>
                             ");
            WriteLiteral(@"           <td>Gửi Email</td>
                                    </tr>
                                    <tr>
                                        <td>QT shop</td>
                                        <td>18/11/2019</td>
                                        <td>6396</td>
                                        <td>250.000đ</td>
                                        <td><div class=""badge badge-pill badge-danger"">Chưa thanh toán</div></td>
                                        <td>Trước hạn</td>
                                    </tr>
                                    <tr>
                                        <td>Quang Minh</td>
                                        <td>14/12/2019</td>
                                        <td>7854</td>
                                        <td>500.000đ</td>
                                        <td><div class=""badge badge-pill badge-success"">Đã thanh toán</div></td>
                                        <td>Sao chép</td>
      ");
            WriteLiteral(@"                              </tr>
                                    <tr>
                                        <td>QT Store</td>
                                        <td>24/12/2019</td>
                                        <td>568569</td>
                                        <td>10000đ</td>
                                        <td><div class=""badge badge-pill badge-success"">Đã thanh toán</div></td>
                                        <td>Gửi Email</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
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