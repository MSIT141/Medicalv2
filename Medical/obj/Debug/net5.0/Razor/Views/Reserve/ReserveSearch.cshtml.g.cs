#pragma checksum "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9996afaf71af2313b0a8953ae0df573fa1f97189"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reserve_ReserveSearch), @"mvc.1.0.view", @"/Views/Reserve/ReserveSearch.cshtml")]
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
#line 1 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9996afaf71af2313b0a8953ae0df573fa1f97189", @"/Views/Reserve/ReserveSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Reserve_ReserveSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.Models.Reserve>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml"
  
    ViewData["Title"] = "ReserveList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Hero Start -->
<div class=""container-fluid bg-primary py-5 hero-header mb-5"">
    <div class=""row py-3"">
        <div class=""col-12 text-center"">
            <h3 class=""display-3 text-white animated zoomIn"">預約掛號查詢</h3>
        </div>
    </div>
</div>

<h1>");
#nullable restore
#line 16 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml"
Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<!-- Hero End -->
<div class=""col-12 col-sm-6"">
    <table id=""table1"" class=""table table-bordered"">
        <thead>
            <tr>
                <th>預約醫生</th>
                <th>看診日期</th>
                <th>看診順序</th>
                <th>預約備註</th>
                <th>預約方式</th>
                <th>預約狀態</th>
                <th>預約科目</th>
                <th>設定</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml"
              
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml"
                           Write(item.ClinicDetail.Doctor.DoctorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml"
                           Write(item.ClinicDetail.ClinicDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml"
                           Write(item.SequenceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml"
                           Write(item.RemarkPatient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml"
                           Write(item.Source.Source1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml"
                           Write(item.State.State1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <!-- Button trigger modal -->\r\n                                <!--<button type=\"button\" id=\"");
#nullable restore
#line 46 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml"
                                                         Write(item.ReserveId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-primary\" data-bs-toggle=\"modal\" data-bs-target=\"#exampleModal\">\r\n            取消預約\r\n        </button>-->\r\n                                ");
#nullable restore
#line 49 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml"
                           Write(Html.ActionLink("取消預約", "Delete", new { id = item.ReserveId }, new { onclick = "return confirm('是否取消預約?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Reserve\ReserveSearch.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">取消預約</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""關閉""></button>
                </div>
                <div class=""modal-body"">
                    是否取消預約?                   
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">否</button>
                    <button type=""button"" class=""btn btn-primary"">確定取消</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.Models.Reserve>> Html { get; private set; }
    }
}
#pragma warning restore 1591
