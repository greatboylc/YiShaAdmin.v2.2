#pragma checksum "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\LogOperate\LogOperateDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "267def5998a292e15c1f757ff19f5bda6d4d9905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_LogOperate_LogOperateDetail), @"mvc.1.0.view", @"/Areas/SystemManage/Views/LogOperate/LogOperateDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SystemManage/Views/LogOperate/LogOperateDetail.cshtml", typeof(AspNetCore.Areas_SystemManage_Views_LogOperate_LogOperateDetail))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#line 2 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#line 3 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#line 4 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#line 5 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#line 6 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#line 7 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Enum.SystemManage;

#line default
#line hidden
#line 8 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267def5998a292e15c1f757ff19f5bda6d4d9905", @"/Areas/SystemManage/Views/LogOperate/LogOperateDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_LogOperate_LogOperateDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal m-t"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\LogOperate\LogOperateDetail.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
            BeginContext(57, 50, true);
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            EndContext();
            BeginContext(107, 1125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "267def5998a292e15c1f757ff19f5bda6d4d99055494", async() => {
                BeginContext(151, 1074, true);
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label"">登录信息</label>
            <div class=""form-control-static"" col=""UserName""></div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label"">请求地址</label>
            <div class=""form-control-static"" col=""ExecuteUrl""></div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label"">请求参数</label>
            <div class=""form-control-static"">
                <pre><span col=""ExecuteParam""></span></pre>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label"">状态</label>
            <div class=""form-control-static"" col=""LogStatus""></div>
        </div>
        <div class=""form-group"" id=""exception"" style=""display:none"">
            <label class=""col-sm-2 control-label"">异常信息</label>
            <div class=""form-control-static"">
                <pre><span col=""ExecuteResult""></spa");
                WriteLiteral("n></pre>\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1232, 223, true);
            WriteLiteral("\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    var id = ys.request(\"id\");\r\n    $(function () {\r\n        getForm();\r\n    });\r\n\r\n    function getForm() {\r\n        if (id > 0) {\r\n            ys.ajax({\r\n                url: \'");
            EndContext();
            BeginContext(1456, 52, false);
#line 43 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\LogOperate\LogOperateDetail.cshtml"
                 Write(Url.Content("~/SystemManage/LogOperate/GetFormJson"));

#line default
#line hidden
            EndContext();
            BeginContext(1508, 556, true);
            WriteLiteral(@"' + '?id=' + id,
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        var result = obj.Result;
                        result.UserName = (ys.isNullOrEmpty(result.UserName) ? """" : result.UserName) + "" / "";
                        result.UserName += (ys.isNullOrEmpty(result.DepartmentName) ? """" : result.DepartmentName) + "" / "";
                        result.UserName += result.IpAddress + "" / "" + result.IpLocation;
                        if (result.LogStatus == """);
            EndContext();
            BeginContext(2065, 38, false);
#line 51 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\LogOperate\LogOperateDetail.cshtml"
                                            Write(OperateStatusEnum.Success.ParseToInt());

#line default
#line hidden
            EndContext();
            BeginContext(2103, 146, true);
            WriteLiteral("\") {\r\n                            $(\"#exception\").hide();\r\n                            result.LogStatus = \'<span class=\"label label-primary\">\' + \"");
            EndContext();
            BeginContext(2250, 42, false);
#line 53 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\LogOperate\LogOperateDetail.cshtml"
                                                                                  Write(OperateStatusEnum.Success.GetDescription());

#line default
#line hidden
            EndContext();
            BeginContext(2292, 190, true);
            WriteLiteral("\" + \'</span>\';\r\n                        } else {\r\n                            $(\"#exception\").show();\r\n                            result.LogStatus = \'<span class=\"label label-warning\">\' + \"");
            EndContext();
            BeginContext(2483, 39, false);
#line 56 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\LogOperate\LogOperateDetail.cshtml"
                                                                                  Write(OperateStatusEnum.Fail.GetDescription());

#line default
#line hidden
            EndContext();
            BeginContext(2522, 191, true);
            WriteLiteral("\" + \'</span>\';\r\n                        }\r\n                        $(\"#form\").setWebControls(result);\r\n                    }\r\n                }\r\n            });\r\n        }\r\n    }\r\n</script>\r\n");
            EndContext();
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
