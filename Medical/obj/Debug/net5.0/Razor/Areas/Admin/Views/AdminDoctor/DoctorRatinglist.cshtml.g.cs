#pragma checksum "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ca37df44717e77cbaf81ab75454889bbf863ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminDoctor_DoctorRatinglist), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminDoctor/DoctorRatinglist.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ca37df44717e77cbaf81ab75454889bbf863ec9", @"/Areas/Admin/Views/AdminDoctor/DoctorRatinglist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminDoctor_DoctorRatinglist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModel.CRatingDoctorViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
  
    ViewData["Title"] = "DoctorRatinglist";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>醫生評論管理</h1>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca37df44717e77cbaf81ab75454889bbf863ec93934", async() => {
                WriteLiteral("回到上一頁");
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
            WriteLiteral(@"
</div>


<table class=""table"">
    <thead>
        <tr>
            <th>
                評論編號
            </th>
            <th>
                醫師姓名
            </th>
            <th>
                醫師評分
            </th>
            <th>
                ");
#nullable restore
#line 27 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
   
    int count = 0;
    foreach (var item in Model) {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
           Write(Html.DisplayFor(modelItem => item.Doctor.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
           Write(Html.DisplayFor(modelItem => item.RatingType.RatingTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
           Write(Html.ActionLink("刪除", "DoctorRatingDelete", new { id = item.RatingDoctorId }, new { onclick = "return confirm('確定要刪除?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Areas\Admin\Views\AdminDoctor\DoctorRatinglist.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModel.CRatingDoctorViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
