#pragma checksum "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Product\CartViewList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d077a4bb5bf049144fcb32277934bc7d0f6f8326"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_CartViewList), @"mvc.1.0.view", @"/Views/Product/CartViewList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d077a4bb5bf049144fcb32277934bc7d0f6f8326", @"/Views/Product/CartViewList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_CartViewList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModel.CShoppingCartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/CartViewList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 50px; margin-right:50px ;  object-fit: fill; width: 250px; height:100%; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Product\CartViewList.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>CartViewList</h1>

<br />

<div class=""row"" style=""align-items:center;width:98%;margin:auto"">
    <div class=""col-md-2""><h3>我的購物車</h3></div>
    <div class=""col-md-3"" style=""padding-left:0;"">
        <ul class=""breadcrumb"" style=""background-color: white; font-size: 18px;margin:auto;"">
            <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 453, "\"", 460, 0);
            EndWriteAttribute();
            WriteLiteral(">首頁</a></li>\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d077a4bb5bf049144fcb32277934bc7d0f6f83265446", async() => {
                WriteLiteral("產品列表");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d077a4bb5bf049144fcb32277934bc7d0f6f83266566", async() => {
                WriteLiteral("購物車");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
        </ul>
    </div>
</div>



<div class=""container-fluid"" style=""width: 100%; margin: auto;  margin-top: 20px; margin-bottom: 20px;"">

    <div style=""text-align: center ;"">
        <button style=""background-color: rgb(19, 51, 86); color: white; font-size: 20px; height: 46px; width: 100%; margin: auto;"">繼續購物</button>
    </div>

    <hr>

    <div style=""background-color: rgb(236, 236, 236); "">

");
#nullable restore
#line 33 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Product\CartViewList.cshtml"
           int pay = 0;
            decimal tax = 0;
            foreach (var item in Model)
            {
                pay += item.小計;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <!-- =================================  整組模型 Start  =================================== -->
                <div style=""height: 200px; max-height: 200px; padding: 10px; display: flex; flex-direction: row"">
                    <div style=""  background-color: white; width: 350px; max-width: 350px; height: 180px ; max-height:180px;"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d077a4bb5bf049144fcb32277934bc7d0f6f83268808", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1590, "~/images/", 1590, 9, true);
#nullable restore
#line 42 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Product\CartViewList.cshtml"
AddHtmlAttributeValue("", 1599, item.prodspec.ProductImage, 1599, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>

                    <!-- ==========================  card模型 Start  ============================== -->
                    <div class=""card"" style=""  margin-left: 10px;   background-color: white; width: 100%;  height: 180px ; max-height:180px;"">
                        <br>
                        <div class=""card-body"" style=""display: flex; justify-content: space-around;margin-top: 15px;"">
                            <h4> ");
#nullable restore
#line 49 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Product\CartViewList.cshtml"
                            Write(Html.DisplayFor(modelItem => item.prod.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p><span>數量:&nbsp;</span><input type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 2323, "\"", 2385, 1);
#nullable restore
#line 50 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Product\CartViewList.cshtml"
WriteAttributeValue("", 2331, Html.DisplayFor(modelItem => item.cart.ProductAmount), 2331, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 60px; text-align: center;\"> &nbsp;&nbsp; &nbsp;<span>價格:&nbsp;</span> <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2489, "\"", 2552, 2);
#nullable restore
#line 50 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Product\CartViewList.cshtml"
WriteAttributeValue("", 2497, Html.DisplayFor(modelItem => item.prodspec.UnitPrice), 2497, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2551, "", 2552, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" readonly style=""width: 120px; text-align: center;""></p>
                        </div>

                        <div class=""card-footer"" style=""padding: 0; max-height: 50px; height: 50px;"">
                            <button style=""border: 0; background-color: transparent; width: 64%; height: 100%;"">瀏覽產品</button>

                            <button style=""border: 0; background-color:transparent; width: 34%; height: 100%; border-left: 1px solid rgb(229, 229, 229);"">刪除</button>
                        </div>
                    </div>
                    <!-- ==========================card模型 End ============================== -->
                </div>
");
#nullable restore
#line 61 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Product\CartViewList.cshtml"

                tax = pay * 0.05m;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!-- =================================整組模型 End =================================== -->
        <!-- ===============================  下半部 Start  =====================================-->
        <div style=""height: 250px; max-height: 250px; padding: 10px; display: flex; flex-direction: row;"">

            <div style=""   background-color: rgba(255, 255, 255, 0.679); width: 650px; max-width: 650px; height: 100%; "">
                <button style=""width: 100%; height: 32%; border: 0; margin-bottom: 3px; background-color: white;"" type=""button""");
            BeginWriteAttribute("class", " class=\"", 3845, "\"", 3853, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""modal"" data-bs-target=""#myModal1"">送貨方式</button>
                <div class=""modal fade"" id=""myModal1"" tabindex=""-1"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h3 class=""modal-title"">訂單配送</h3>
                                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal""></button>
                            </div>
                            <div class=""modal-body"">
                                <h5>注意事項</h5>
                                <br />
                                <ul>
                                    <li>訂單一經處理，您將會收到一封郵件，確認訂單已成立。</li>
                                    <li>配送時間須配合貨運公司。</li>
                                    <li>請注意，訂單一經確認，便不得更改送貨地址。</li>
                                    <li>由於惡劣天氣、自然災害或其他無法控制的狀況，訂單運送可能會延遲。</li>
                                </ul>
                         ");
            WriteLiteral(@"       <br />
                                <h5>配送方式</h5>
                                <br />
                                <p>
                                    宅配
                                    <ul>
                                        <li> 費用 : 需加收運費。</li>
                                        <li> 送貨時間 : 由您接獲發貨確認電郵起計3至7個工作天。</li>
                                    </ul>
                                </p>

                                <p>
                                    7-11超商付款取貨
                                    <ul>
                                        <li> 費用 : 需加收運費。</li>
                                        <li> 送貨時間 : 由您接獲發貨確認電郵起計3至7個工作天。</li>
                                    </ul>
                                </p>

                                <p>
                                    到店取貨
                                    <ul>
                                        <li> 費用 : 免收運費。</li>
                                        <li");
            WriteLiteral("> 送貨時間 : 您將會收到電郵通知，確認可於門市取貨的時間。</li>\r\n                                        <li> 到店取貨需出示附有照片的身分證明文件 (例如護照、身分證、駕駛執照) </li>\r\n                                    </ul>\r\n                                </p>\r\n                            </div>\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n                <button style=\"width: 100%; height: 32%; border: 0; margin-bottom: 3px; background-color: white;\" type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 6421, "\"", 6429, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""modal"" data-bs-target=""#myModal2"">付款方式</button>
                <div class=""modal fade"" id=""myModal2"" tabindex=""-1"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h3 class=""modal-title"">付款方式</h3>
                                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal""></button>
                            </div>
                            <div class=""modal-body"">
                                <p>我們提供的歐富寶和LinePay付款方式。如需使用其他付款方式，請致電 0800 123 4567 與客戶服務中心聯繫。</p>
                                <br />
                                <p>漢克斯眼科採用加密系統，以保障客戶的個人與付款資料。</p>
                                <br />
                                <p>如欲獲取更多資訊或協助，歡迎聯絡我們的客戶服務中心。</p>
                            </div>
                        </div>
                    </div>
                </div>
                <button style=""w");
            WriteLiteral("idth: 100%; height: 32%; border: 0; margin-bottom: 3px; background-color: white;\" type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 7549, "\"", 7557, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""modal"" data-bs-target=""#myModal3"">退換貨規定</button>
                <div class=""modal fade"" id=""myModal3"" tabindex=""-1"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h3 class=""modal-title"">退換貨規定</h3>
                                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal""></button>
                            </div>
                            <div class=""modal-body"">
                                <h5>退換貨須知</h5>
                                <br />
                                <ul>
                                    <li>
                                        若因商品本身瑕疵狀況 （瑕疵商品定義：非人為因素問題造成的故障、毀損、磨損、擦傷、刮傷、髒污或包裝破損等），請務必在收到商品後先拍照記錄，再來信客服，以確認為商品本身瑕疵或為運送上問題及後續退換辦理。
                                    </li>

                                    <li class=""mt-2"">商品退換，請務必保持原商品完整（無異味髒污、磨損毀壞、加工改造等）、包裝齊全性（內外包裝、封膜、封口、隨貨文件、贈");
            WriteLiteral(@"品等），並使用原紙箱送回，若因包裝不妥導致寄回損壞，將不受理退換貨申請。</li>
                                    <li class=""mt-2"">該商品除了瑕疵及商品有誤之外，其他原因產生的退貨運費，皆由消費者自行負擔。退換貨完成申請後，請自行自費寄至 nueva 指定收貨地址。更換商品以一次為限，如遇商品缺貨或其他因素無法出貨的情況則退款處理。</li>
                                    <li class=""mt-2"">特價商品，恕不接受退換貨，請見諒。</li>
                                </ul>
                                <br />
                                <h5>退款處理</h5>
                                <br />
                                <p>
                                    若退貨狀況成立，漢克斯眼科 將於7-14個工作天內（不包含例假日）以下列方式退款給您：
                                    <ul>
                                        <li>
                                            刷卡付款者：直接把款項刷退至原付款的信用卡帳號中。因各刷卡行結帳日不同之關係，實際入帳入還請洽詢您的銀行。

                                        </li>
                                        <li> 完匯將以 E-MAIL 告知。</li>
                                    </ul>
                                </p>

                                <p>
                                    ");
            WriteLiteral(@"7-11超商付款取貨
                                    <ul>
                                        <li> 費用 : 需加收運費。</li>
                                        <li> 送貨時間 : 由您接獲發貨確認電郵起計3至7個工作天。</li>
                                    </ul>
                                </p>

                                <p>
                                    到店取貨
                                    <ul>
                                        <li> 費用 : 免收運費。</li>
                                        <li> 送貨時間 : 您將會收到電郵通知，確認可於門市取貨的時間。</li>
                                        <li> 到店取貨需出示附有照片的身分證明文件 (例如護照、身分證、駕駛執照) </li>
                                    </ul>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div style=""  margin-left: 10px;   background-color: white; width: 100%; "">
                <div style=""width: 80%; display: flex ; justify-content: space-bet");
            WriteLiteral("ween; margin: auto;margin-top: 25px;\">\r\n                    <h5>交易金額:</h5><h5>");
#nullable restore
#line 195 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Product\CartViewList.cshtml"
                                 Write(pay.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n                <div style=\"width: 80%; display: flex ; justify-content: space-between; margin: auto;\">\r\n                    <h5>稅額:</h5><h5>");
#nullable restore
#line 198 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Product\CartViewList.cshtml"
                               Write(tax.ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n                <br>\r\n                <div style=\"width: 80%; display: flex ; justify-content: space-between; margin: auto; margin-top:15px\">\r\n                    <h5>總額:</h5><h5 style=\"color: red\">");
#nullable restore
#line 202 "C:\Users\hankshsu\Desktop\期末專題v1完整版\期末專題v1完整版\Medical\Medical\Views\Product\CartViewList.cshtml"
                                                   Write((pay+tax).ToString("C0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                </div>
                <div style="" width: 80%; margin: auto; margin-top: 15px;"">
                    <button style=""width: 97%; height:40px;margin-left: 10px;background-color: black;color: white;"">前往結帳</button>
                </div>
            </div>
        </div>
        <!-- ===============================  下半部 End  =====================================-->
    </div>


</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\" crossorigin=\"anonymous\"></script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModel.CShoppingCartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
