#pragma checksum "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\ClinicDetail\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfeaec77f0c3320e017d2a7acb7b1ca9912bed07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClinicDetail_List), @"mvc.1.0.view", @"/Views/ClinicDetail/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfeaec77f0c3320e017d2a7acb7b1ca9912bed07", @"/Views/ClinicDetail/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_ClinicDetail_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.Models.ClinicDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\ClinicDetail\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Hero Start -->
<div class=""container-fluid bg-primary py-5 hero-header mb-5"">
    <div class=""row py-3"">
        <div class=""col-12 text-center"">
            <h3 class=""display-3 text-white animated zoomIn"">即時門診</h3>
        </div>
    </div>
</div>
<!-- Hero End -->
<div style=""display: flex; /* 水平置中*/ justify-content: center; /* 垂直置中 */ align-items: center; flex-wrap: wrap; "">
");
#nullable restore
#line 16 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\ClinicDetail\List.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-3 wow zoomIn\" data-wow-delay=\"0.1s\" style=\"float: left; border: solid 2px black; margin:20px\">\r\n            <div class=\"bg-primary d-flex flex-column p-5\" style=\"height: 300px;\">\r\n                <h2>診間  ");
#nullable restore
#line 21 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\ClinicDetail\List.cshtml"
                   Write(item.Room.RoomName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                <div class=""d-flex justify-content-between text-white mb-3"">
                    <h4 class=""text-white mb-3"">
                        醫生姓名:
                    </h4>
                    <p class=""mb-0"">
                        ");
#nullable restore
#line 28 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\ClinicDetail\List.cshtml"
                   Write(item.Doctor.DoctorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
                <div class=""d-flex justify-content-between text-white mb-3"">
                    <h4 class=""text-white mb-3"">
                        科目:
                    </h4>
                    <p class=""mb-0"">
                        ");
#nullable restore
#line 36 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\ClinicDetail\List.cshtml"
                   Write(item.Department.DeptName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
                <div class=""d-flex justify-content-between text-white mb-3"">
                    <h4 class=""text-white mb-3"">
                        現在號碼:
                    </h4>
                    <p class=""mb-0"">
                        1
                    </p>
                </div>
            </div>
        </div>
");
#nullable restore
#line 49 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\ClinicDetail\List.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.Models.ClinicDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
