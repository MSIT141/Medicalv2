#pragma checksum "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\RatingDoctor\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ee2536d237f9883814969a112eb2f670fac3638"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RatingDoctor_List), @"mvc.1.0.view", @"/Views/RatingDoctor/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ee2536d237f9883814969a112eb2f670fac3638", @"/Views/RatingDoctor/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_RatingDoctor_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModels.RatingDoctoeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\RatingDoctor\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Hero Start -->
<div class=""container-fluid bg-primary py-5 hero-header mb-5"">
    <div class=""row py-3"">
        <div class=""col-12 text-center"">
            <h3 class=""display-3 text-white animated zoomIn"">評論修改</h3>
        </div>
    </div>
</div>
<!-- Hero End -->
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
#line 37 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\RatingDoctor\List.cshtml"
          
            int count = 0;
            foreach (var item in Model)
            {
                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\RatingDoctor\List.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\RatingDoctor\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Doctor.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\RatingDoctor\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RatingTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\RatingDoctor\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\RatingDoctor\List.cshtml"
                   Write(Html.ActionLink("修改", "Edit", new { id = item.ratingDoctor.RatingDoctorId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 57 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\RatingDoctor\List.cshtml"
                   Write(Html.ActionLink("刪除", "Delete", "RatingDoctor", new { id = item.ratingDoctor.RatingDoctorId },
                                new { onclick = "return confirm('確定要刪除嗎 ? ')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 61 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\RatingDoctor\List.cshtml"
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
