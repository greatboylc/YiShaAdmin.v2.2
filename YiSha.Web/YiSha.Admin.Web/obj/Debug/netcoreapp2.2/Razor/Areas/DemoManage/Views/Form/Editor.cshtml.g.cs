#pragma checksum "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Editor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13924ceae86278a32607513accb1102912ce0d19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DemoManage_Views_Form_Editor), @"mvc.1.0.view", @"/Areas/DemoManage/Views/Form/Editor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DemoManage/Views/Form/Editor.cshtml", typeof(AspNetCore.Areas_DemoManage_Views_Form_Editor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13924ceae86278a32607513accb1102912ce0d19", @"/Areas/DemoManage/Views/Form/Editor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b622e924f35698514110c8d85c04ddd5a27d39", @"/Areas/DemoManage/_ViewImports.cshtml")]
    public class Areas_DemoManage_Views_Form_Editor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Editor.cshtml"
  
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
                BeginContext(158, 114, false);
#line 7 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Editor.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/summernote/0.8.8/summernote.min.css")));

#line default
#line hidden
                EndContext();
                BeginContext(272, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(279, 113, false);
#line 8 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Editor.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/summernote/0.8.8/summernote.min.js")));

#line default
#line hidden
                EndContext();
                BeginContext(392, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(397, 2956, true);
            WriteLiteral(@"
<div class=""wrapper wrapper-content"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-content"">
                    <h2>Summernote</h2>
                    <p>
                        <a href=""https://github.com/summernote/summernote"" target=""_blank"">Summernote</a> 是一个简单的基于Bootstrap的WYSIWYG富文本编辑器
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>Summernote 富文本编辑器</h5>
                </div>
                <div class=""ibox-content no-padding"">
                    <div class=""summernote"">
                        <h2>一沙后台管理系统</h2>
                        <p>
                            YiShaAdmin 是一个开源的后台管理系统快速开发框架，基于.NET Core Web技术（ASP.NET Core Web，ASP.NET Core Web Api），主要目的让开发者专注业务，
           ");
            WriteLiteral(@"                 降低技术难度，从而节省人力成本，缩短项目周期，提高软件安全质量。
                        </p>
                        <p>
                            <span class=""label label-warning"">免费开源</span>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>编辑/保存为html代码示例</h5>
                    <button id=""edit"" class=""btn btn-primary btn-xs m-l-sm"" onclick=""edit()"" type=""button"">编辑</button>
                    <button id=""save"" class=""btn btn-primary  btn-xs"" onclick=""save()"" type=""button"">保存</button>
                </div>
                <div class=""ibox-content"" id=""eg"">

                    <div class=""click2edit wrapper"">
                        <h3>你好，一沙 </h3>
                        <p>
                            YiShaAdmin 是一个开源的后台管理系统快速开发框架，基于.NET Core Web技术（ASP.NE");
            WriteLiteral(@"T Core Web，ASP.NET Core Web Api），主要目的让开发者专注业务，
                            降低技术难度，从而节省人力成本，缩短项目周期，提高软件安全质量。
                        </p>
                        <p>
                            <span class=""label label-warning"">开源免费</span>
                        </p>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        $('.summernote').summernote({
            lang: 'zh-CN'
        });
    });

    var edit = function () {
        $(""#eg"").addClass(""no-padding"");
        $('.click2edit').summernote({
            lang: 'zh-CN',
            focus: true
        });
    };

    var save = function () {
        $(""#eg"").removeClass(""no-padding"");
        var html = $('.click2edit').summernote('code');
        $('.click2edit').summernote('destroy');
    };
</script>");
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