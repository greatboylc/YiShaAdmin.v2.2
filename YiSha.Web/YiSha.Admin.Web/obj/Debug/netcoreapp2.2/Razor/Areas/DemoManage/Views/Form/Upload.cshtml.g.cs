#pragma checksum "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13ae06efad52b930e26ecf27e9578a093ee81431"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DemoManage_Views_Form_Upload), @"mvc.1.0.view", @"/Areas/DemoManage/Views/Form/Upload.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DemoManage/Views/Form/Upload.cshtml", typeof(AspNetCore.Areas_DemoManage_Views_Form_Upload))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#line 3 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#line 4 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#line 5 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#line 6 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#line 7 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#line 8 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ae06efad52b930e26ecf27e9578a093ee81431", @"/Areas/DemoManage/Views/Form/Upload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b622e924f35698514110c8d85c04ddd5a27d39", @"/Areas/DemoManage/_ViewImports.cshtml")]
    public class Areas_DemoManage_Views_Form_Upload : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
  
    Layout = "~/Views/Shared/_FormGray.cshtml";

#line default
#line hidden
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("header", async() => {
                BeginContext(151, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(158, 116, false);
#line 7 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/fileinput/5.0.3/css/fileinput.min.css")));

#line default
#line hidden
                EndContext();
                BeginContext(274, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(281, 114, false);
#line 8 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/fileinput/5.0.3/js/fileinput.min.js")));

#line default
#line hidden
                EndContext();
                BeginContext(395, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(400, 1227, true);
            WriteLiteral(@"
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>文件上传控件 <small>https://github.com/kartik-v/bootstrap-fileinput</small></h5>
                </div>
                <div class=""ibox-content"">
                    <div class=""form-group"">
                        <label class=""font-noraml"">简单示例</label>
                        <div class=""file-loading"">
                            <input id=""fileinput-demo-1"" type=""file"">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""font-noraml"">多文件上传</label>
                        <div class=""file-loading"">
                            <input id=""fileinput-demo-2"" type=""file"" multiple>
                        </div>
                    </div>
                </div>
            </div>
    ");
            WriteLiteral("    </div>\r\n    </div>\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n        $(\"#fileinput-demo-1\").fileinput({\r\n            language: \'zh\',\r\n            \'uploadUrl\': \'");
            EndContext();
            BeginContext(1628, 34, false);
#line 42 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
                     Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
            EndContext();
            BeginContext(1662, 33, true);
            WriteLiteral("\' + \'/File/UploadFile?fileModule=");
            EndContext();
            BeginContext(1696, 32, false);
#line 42 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
                                                                                         Write(UploadFileType.News.ParseToInt());

#line default
#line hidden
            EndContext();
            BeginContext(1728, 150, true);
            WriteLiteral("\',\r\n            showPreview: false\r\n        });\r\n\r\n        $(\"#fileinput-demo-2\").fileinput({\r\n            language: \'zh\',\r\n            \'uploadUrl\': \'");
            EndContext();
            BeginContext(1879, 34, false);
#line 48 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
                     Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
            EndContext();
            BeginContext(1913, 33, true);
            WriteLiteral("\' + \'/File/UploadFile?fileModule=");
            EndContext();
            BeginContext(1947, 32, false);
#line 48 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
                                                                                         Write(UploadFileType.News.ParseToInt());

#line default
#line hidden
            EndContext();
            BeginContext(1979, 113, true);
            WriteLiteral("\',\r\n            overwriteInitial: false,\r\n            initialPreviewAsData: true,\r\n            initialPreview: [\'");
            EndContext();
            BeginContext(2093, 35, false);
#line 51 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Upload.cshtml"
                         Write(Url.Content("~/image/portrait.png"));

#line default
#line hidden
            EndContext();
            BeginContext(2128, 35, true);
            WriteLiteral("\']\r\n        });\r\n    });\r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IHostingEnvironment HostingEnvironment { get; private set; }
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
