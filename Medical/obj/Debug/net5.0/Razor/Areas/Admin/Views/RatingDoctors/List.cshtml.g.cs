#pragma checksum "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa00141cf6dd5af7842d2b7b52bf04fb49826d5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_RatingDoctors_List), @"mvc.1.0.view", @"/Areas/Admin/Views/RatingDoctors/List.cshtml")]
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
#line 1 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa00141cf6dd5af7842d2b7b52bf04fb49826d5e", @"/Areas/Admin/Views/RatingDoctors/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_RatingDoctors_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModels.RatingDoctoeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>評論修改</h1>
<br>

<table class=""table"">
    <thead>
        <tr>
            <th>
                序
            </th>
            <th>
                醫生
            </th>
            <th>
                評分分數
            </th>
            <th>
                評語
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
          
            int count = 0;
            foreach (var item in Model)
            {
                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Doctor.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RatingTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
                   Write(Html.ActionLink("修改", "Edit", new { id = item.ratingDoctor.RatingDoctorId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 50 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
                   Write(Html.ActionLink("刪除", "Delete", "RatingDoctor", new { id = item.ratingDoctor.RatingDoctorId },
                                new { onclick = "return confirm('確定要刪除嗎 ? ')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 54 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\RatingDoctors\List.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModels.RatingDoctoeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
