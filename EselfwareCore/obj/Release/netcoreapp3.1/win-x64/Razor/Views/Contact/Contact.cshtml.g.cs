#pragma checksum "C:\Users\Ener Automation\source\repos\EselfwareCore\EselfwareCore\Views\Contact\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "534a50c2b9637748f38fc916164e4aaa362a47b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Contact), @"mvc.1.0.view", @"/Views/Contact/Contact.cshtml")]
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
#line 1 "C:\Users\Ener Automation\source\repos\EselfwareCore\EselfwareCore\Views\_ViewImports.cshtml"
using EselfwareCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ener Automation\source\repos\EselfwareCore\EselfwareCore\Views\_ViewImports.cshtml"
using EselfwareCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"534a50c2b9637748f38fc916164e4aaa362a47b3", @"/Views/Contact/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98dbaa9a141eede9dd3928aa60766a773c867ab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/template/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/template/img/ekFotographs/QRCode.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/template/img/svg/section-icon-5.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("main_contact_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ener Automation\source\repos\EselfwareCore\EselfwareCore\Views\Contact\Contact.cshtml"
  
    ViewData["Title"] = "Contact";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "534a50c2b9637748f38fc916164e4aaa362a47b36524", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<section class=""features section-padding-100-70"" style=""background: url(~/template/img/svg/benefits-bg.svg) no-repeat center left;"">
    <div class=""section-heading text-center"">
        <!-- Dream Dots -->
        <div class=""dream-dots justify-content-center fadeInUp"" data-wow-delay=""0.2s"" style=""visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;"">
            <div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "534a50c2b9637748f38fc916164e4aaa362a47b38060", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"dream-dots justify-content-center fadeInUp\" data-wow-delay=\"0.2s\" style=\"visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;\">\r\n            <div>\r\n                <p");
            BeginWriteAttribute("style", " style=\"", 867, "\"", 875, 0);
            EndWriteAttribute();
            WriteLiteral(@">KONUM / LOCATION</p>
            </div>
        </div>
        <div class=""dream-dots justify-content-center fadeInUp"" data-wow-delay=""0.2s"" style=""visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;"">
            <div>
                <p style=""color:black;font-weight:bold"">ENER OTOMASYON ELEKTRİK SAN. VE TİC. LTD. ŞTİ.</p>
            </div>
        </div>

        <div class=""dream-dots justify-content-center fadeInUp"" data-wow-delay=""0.2s"" style=""visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <p style=""color:black;font-weight:bold"">Merkez / Head Office</p>
                    <p>Çınarlı Mah. Fatih Cad. No:16-18 K:14 D:44/1404</p>
                    <p>Ater Tower / Konak / İZMİR</p>
                </div>
");
            WriteLiteral(@"                <div class=""col-md-6"">
                    <p style=""color:black;font-weight:bold"">Üretim / Production</p>
                    <p>Karacaoğlan Mah. 6170 Sk. No:11/Z-46</p>
                    <p>Bornova / İZMİR</p>
                </div>

            </div>
        </div>

        <div class=""dream-dots justify-content-center fadeInUp"" data-wow-delay=""0.2s"" style=""visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;"">
            <div class=""row"">
                <p style=""color:black;font-weight:bold"">M +90 532 430 6484</p>
            </div>
        </div>

        <div class=""dream-dots justify-content-center fadeInUp"" data-wow-delay=""0.2s"" style=""visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;"">
            <div class=""row"">
                <p style=""color:black;font-weight:bold"">T +90 232 433 1 435</p>
            </div>
        </div>


        <div class=""dream-dots justify-content-center fadeInUp"" data-wow-delay=""0.2s"" style=""");
            WriteLiteral(@"visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;"">
            <div class=""row"">
                <p style=""color:black;font-weight:bold"">T +90 850 411 ENER</p>
            </div>
        </div>

        <div class=""dream-dots justify-content-center fadeInUp"" data-wow-delay=""0.2s"" style=""visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;"">
            <div class=""row"">
                <p style=""color:black;font-weight:bold"">F +90 232 433 1 437</p>
            </div>
        </div>

        <div class=""dream-dots justify-content-center fadeInUp"" data-wow-delay=""0.2s"" style=""visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;"">
            <div class=""row"">
                <p style=""color:black;font-weight:bold"">www.enerotomasyon.com.tr</p>
            </div>
        </div>

    </div>
</section>

<!-- ##### Contact Area Start ##### -->
<div class=""contact_us_area section-padding-100-0"" id=""contact"">
    <div class=""container"">
   ");
            WriteLiteral(@"     <div class=""row"">
            <div class=""col-12"">
                <div class=""section-heading text-center"">
                    <!-- Dream Dots -->
                    <div class=""dream-dots justify-content-center fadeInUp"" data-wow-delay=""0.2s"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "534a50c2b9637748f38fc916164e4aaa362a47b312957", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                    <h2 class=""fadeInUp"" data-wow-delay=""0.3s"">Bizimle İletişime Geçin</h2>
                    <p class=""fadeInUp"" data-wow-delay=""0.4s"">Bilgi almak için lütfen mesajınızı bırakınız. En yakın zamanda sizinle iletişime geçeceğiz.</p>
                </div>
            </div>
        </div>

        <!-- Contact Form -->
        <div class=""row justify-content-center"">
            <div class=""col-12 col-md-10 col-lg-8"">
                <div class=""contact_form"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "534a50c2b9637748f38fc916164e4aaa362a47b314625", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-12"">
                                <div id=""success_fail_info""></div>
                            </div>

                            <div class=""col-12 col-md-6"">
                                <div class=""group fadeInUp"" data-wow-delay=""0.2s"">
                                    <input type=""text"" name=""name"" id=""name"" required>
                                    <span class=""highlight""></span>
                                    <span class=""bar""></span>
                                    <label>Ad</label>
                                </div>
                            </div>
                            <div class=""col-12 col-md-6"">
                                <div class=""group fadeInUp"" data-wow-delay=""0.3s"">
                                    <input type=""text"" name=""email"" id=""email"" required>
                                    <span class=""highlight""></span>
                           ");
                WriteLiteral(@"         <span class=""bar""></span>
                                    <label>Email</label>
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""group fadeInUp"" data-wow-delay=""0.4s"">
                                    <input type=""text"" name=""subject"" id=""subject"" required>
                                    <span class=""highlight""></span>
                                    <span class=""bar""></span>
                                    <label>Konu</label>
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""group fadeInUp"" data-wow-delay=""0.5s"">
                                    <textarea name=""message"" id=""message"" required></textarea>
                                    <span class=""highlight""></span>
                                    <span class=""bar""></span>
                WriteLiteral(@"
                                    <label>Mesaj</label>
                                </div>
                            </div>
                            <div class=""col-12 text-center fadeInUp"" data-wow-delay=""0.6s"">
                                <button type=""submit"" class=""btn dream-btn"" id=""btnSendContact""><span id=""spanBtnLoginText"">Mesajı Gönder</span></button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(""#btnSendContact"").click(function () {
        var data = {
            'name': $('#name').val(),
            'email': $('#email').val(),
            'subject': $('#subject').val(),
            'message': $('#message').val(),
        }
        if (data.name != null) {
            $(""#btnSendContact"").prop('disabled', true);
            $(""#spanBtnLoginText"").empty();
            $(""#spanBtnLoginText"").append(""Mesajınız Gönderiliyor"");
            /*btn btn-primary btn-block btn-c mt-4 mb-4*/
            $(""#btnSendContact"").attr('class', 'btn btn-warning btn-block btn-c mt-4 mb-4');

            $.ajax({
                type: ""POST"",
                url: '/iletisimReg',
                data: data,
                success: function (deger) {
                    var span = $(""#spanhata"");
                    var divError = $(""#divError"");
                    span.empty(");
            WriteLiteral(@");
                    if (deger === ""Success"") {
                        window.location.href = '/iletisim#contact';
                    }
                    else if (deger.islem === ""Error"") {
                        span.append(""Giriş bilgileri hatalı !"");
                        $(""#btnSendContact"").prop('disabled', false);
                        $(""#spanBtnLoginText"").empty();
                        $(""#spanBtnLoginText"").append(""Mesajı Gönder"");
                        $(""#btnSendContact"").attr('class', 'btn btn-primary btn-block btn-c mt-4 mb-4');
                        divError.show();
                    }
                    else {
                        span.append(""Bilinmeyen bir hata oluştu !"");
                        $(""#btnSendContact"").prop('disabled', false);
                        $(""#spanBtnLoginText"").empty();
                        $(""#spanBtnLoginText"").append(""Mesajı Gönder"");
                        $(""#btnSendContact"").attr('class', 'btn btn-primary btn-block ");
            WriteLiteral(@"btn-c mt-4 mb-4');
                        divError.show();
                    }
                }

            });
        } else {
            var divError = $(""#divError"");
            var span = $(""#spanhata"");
            span.empty();
            span.append(""Boş alan bırakılamaz"");
            divError.show();
        }
    });
</script>
<!-- ##### Contact Area End ##### -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591