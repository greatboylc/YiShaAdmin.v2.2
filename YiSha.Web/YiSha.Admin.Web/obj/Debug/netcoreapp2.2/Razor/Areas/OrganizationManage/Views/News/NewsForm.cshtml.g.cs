#pragma checksum "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e0646f8553b02d8372a021812168ef2e3489a3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrganizationManage_Views_News_NewsForm), @"mvc.1.0.view", @"/Areas/OrganizationManage/Views/News/NewsForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/OrganizationManage/Views/News/NewsForm.cshtml", typeof(AspNetCore.Areas_OrganizationManage_Views_News_NewsForm))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#line 3 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#line 4 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#line 5 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#line 6 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#line 7 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#line 8 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#line 9 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e0646f8553b02d8372a021812168ef2e3489a3a", @"/Areas/OrganizationManage/Views/News/NewsForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrganizationManage/_ViewImports.cshtml")]
    public class Areas_OrganizationManage_Views_News_NewsForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal m"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
            DefineSection("header", async() => {
                BeginContext(150, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(157, 114, false);
#line 6 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/summernote/0.8.8/summernote.min.css")));

#line default
#line hidden
                EndContext();
                BeginContext(271, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(278, 113, false);
#line 7 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/summernote/0.8.8/summernote.min.js")));

#line default
#line hidden
                EndContext();
                BeginContext(391, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(400, 112, false);
#line 9 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/imageupload/1.0/css/imgup.min.css")));

#line default
#line hidden
                EndContext();
                BeginContext(512, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(519, 110, false);
#line 10 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/imageupload/1.0/js/imgup.min.js")));

#line default
#line hidden
                EndContext();
                BeginContext(629, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(638, 132, false);
#line 12 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.tagsinput/0.8.0/bootstrap-tagsinput.min.css")));

#line default
#line hidden
                EndContext();
                BeginContext(770, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(777, 131, false);
#line 13 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.tagsinput/0.8.0/bootstrap-tagsinput.min.js")));

#line default
#line hidden
                EndContext();
                BeginContext(908, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(913, 50, true);
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            EndContext();
            BeginContext(963, 2370, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e0646f8553b02d8372a021812168ef2e3489a3a8615", async() => {
                BeginContext(1005, 1317, true);
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">标题 <font class=""red""> *</font> </label>
            <div class=""col-sm-10"">
                <input id=""newsTitle"" col=""NewsTitle"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">文章类别<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""newsType"" col=""NewsType""></div>
            </div>
            <label class=""col-sm-2 control-label "">发布时间<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""newsDate"" col=""NewsDate"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">作者<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""newsAuthor"" col=""NewsAuthor"" type=""text"" class=""form");
                WriteLiteral(@"-control"" />
            </div>
            <label class=""col-sm-2 control-label "">排序<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""newsSort"" col=""NewsSort"" type=""text"" class=""form-control"" />
            </div>
        </div>
        ");
                EndContext();
                BeginContext(2323, 157, false);
#line 44 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
   Write(await Html.PartialAsync("/Areas/SystemManage/Shared/AreaFormPartial.cshtml", new ViewDataDictionary(this.ViewData) { { "Label", "2" }, { "Content", "10" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2480, 846, true);
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">文章标签</label>
            <div class=""col-sm-10"">
                <input id=""newsTag"" col=""NewsTag"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">
                <span>缩略图</span><br />
                <span>(宽高比 1.5：1)</span>
            </label>
            <div class=""col-sm-10"">
                <div id=""thumbImage"" class=""img-box"">
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">文章内容 </label>
            <div class=""col-sm-10"">
                <div id=""newsContent"" class=""summernote""></div>
            </div>
        </div>
    ");
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
            BeginContext(3333, 1350, true);
            WriteLiteral(@"
</div>

<script type=""text/javascript"">
    var id = ys.request(""id"");
    $(function () {
        laydate.render({ elem: '#newsDate', type: 'datetime', format: 'yyyy-MM-dd HH:mm' });

        $('#newsTag').tagsinput({ trimValue: true });

        $(""#newsType"").ysComboBox({
            data: top.getDataDict(""NewsType""),
            key: ""DictKey"",
            value: ""DictValue"",
            class: ""form-control""
        });

        $('#newsContent').summernote({
            height: '220px',
            lang: 'zh-CN',
            dialogsInBody: true,
            callbacks: {
                onImageUpload: function (files, editor, welEditable) {
                    uploadNewsImage(files[0], editor, welEditable);
                }
            }
        });

        $(""#thumbImage"").imageUpload({ uploadImage: 'uploadThumbImage', limit: 1, context: ctx });

        getForm();

        $(""#form"").validate({
            rules: {
                newsTitle: { required: true },
   ");
            WriteLiteral(@"             newsType_select: { required: true },
                newsDate: { required: true },
                newsAuthor: { required: true },
                newsSort: { required: true }
            }
        });
    });

    function getForm() {
        if (id > 0) {
            ys.ajax({
                url: '");
            EndContext();
            BeginContext(4684, 52, false);
#line 113 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/News/GetFormJson"));

#line default
#line hidden
            EndContext();
            BeginContext(4736, 816, true);
            WriteLiteral(@"' + '?id=' + id,
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        obj.Result.NewsDate = ys.formatDate(obj.Result.NewsDate, ""yyyy-MM-dd HH:mm"");
                        $(""#form"").setWebControls(obj.Result);
                        $(""#newsContent"").summernote('code', obj.Result.NewsContent);
                        $(""#thumbImage"").imageUpload(""setImageUrl"", obj.Result.ThumbImage);
                      
                        $.each(obj.Result.NewsTag.split(','), function (index,val) {
                             $('#newsTag').tagsinput('add', val);
                        });
                    }
                }
            });
        }
        else {
            ys.ajax({
                url: '");
            EndContext();
            BeginContext(5553, 55, false);
#line 131 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/News/GetMaxSortJson"));

#line default
#line hidden
            EndContext();
            BeginContext(5608, 215, true);
            WriteLiteral("\',\r\n                type: \"get\",\r\n                success: function (obj) {\r\n                    if (obj.Tag == 1) {\r\n                        var defaultData = {};\r\n                        defaultData.NewsAuthor = \"");
            EndContext();
            BeginContext(5824, 29, false);
#line 136 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                             Write(ViewBag.OperatorInfo.RealName);

#line default
#line hidden
            EndContext();
            BeginContext(5853, 52, true);
            WriteLiteral("\";\r\n                        defaultData.NewsDate = \'");
            EndContext();
            BeginContext(5906, 41, false);
#line 137 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                           Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(5947, 551, true);
            WriteLiteral(@"';
                        defaultData.NewsSort = obj.Result;
                        $(""#form"").setWebControls(defaultData);
                    }
                }
            });
        }
    }

    function saveForm(index) {
        if ($(""#form"").validate().form()) {
            var postData = $(""#form"").getWebControls({ Id: id });
            postData.NewsContent = $(""#newsContent"").summernote('code');
            postData.ThumbImage = $(""#thumbImage"").imageUpload(""getImageUrl"");
            ys.ajax({
                url: '");
            EndContext();
            BeginContext(6499, 53, false);
#line 152 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/News/SaveFormJson"));

#line default
#line hidden
            EndContext();
            BeginContext(6552, 670, true);
            WriteLiteral(@"',
                type: ""post"",
                data: postData,
                success: function (obj) {
                    if (obj.Tag == 1) {
                        ys.msgSuccess(obj.Message);
                        parent.searchGrid();
                        parent.layer.close(index);
                    }
                    else {
                        ys.msgError(obj.Message);
                    }
                }
            });
        }
    }

    function uploadNewsImage(file, editor, welEditable) {
        var formdata = new FormData();
        formdata.append(""file"", file);
        ys.ajaxUploadFile({
            url: '");
            EndContext();
            BeginContext(7223, 34, false);
#line 173 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
             Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
            EndContext();
            BeginContext(7257, 33, true);
            WriteLiteral("\' + \'/File/UploadFile?fileModule=");
            EndContext();
            BeginContext(7291, 32, false);
#line 173 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                                                                 Write(UploadFileType.News.ParseToInt());

#line default
#line hidden
            EndContext();
            BeginContext(7323, 174, true);
            WriteLiteral("\',\r\n            data: formdata,\r\n            success: function (obj) {\r\n                if (obj.Tag == 1) {\r\n                    $(\"#newsContent\").summernote(\'insertImage\', \'");
            EndContext();
            BeginContext(7498, 34, false);
#line 177 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                                            Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
            EndContext();
            BeginContext(7532, 344, true);
            WriteLiteral(@"' + obj.Result, '/');
                }
                else {
                    ys.msgError(obj.Message);
                }
            }
        })
    }

    function uploadThumbImage(file, callback) {
        var formdata = new FormData();
        formdata.append(""file"", file);
        ys.ajaxUploadFile({
            url: '");
            EndContext();
            BeginContext(7877, 34, false);
#line 190 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
             Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
            EndContext();
            BeginContext(7911, 33, true);
            WriteLiteral("\' + \'/File/UploadFile?fileModule=");
            EndContext();
            BeginContext(7945, 32, false);
#line 190 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                                                                                 Write(UploadFileType.News.ParseToInt());

#line default
#line hidden
            EndContext();
            BeginContext(7977, 180, true);
            WriteLiteral("\',\r\n            data: formdata,\r\n            success: function (obj) {\r\n                if (obj.Tag == 1) {\r\n                    if (callback) {\r\n                        callback(\'");
            EndContext();
            BeginContext(8158, 34, false);
#line 195 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\News\NewsForm.cshtml"
                             Write(GlobalContext.SystemConfig.ApiSite);

#line default
#line hidden
            EndContext();
            BeginContext(8192, 197, true);
            WriteLiteral("\' + obj.Result);\r\n                    }\r\n                }\r\n                else {\r\n                    ys.msgError(obj.Message);\r\n                }\r\n            }\r\n        })\r\n    }\r\n</script>\r\n\r\n");
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
