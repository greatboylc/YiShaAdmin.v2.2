#pragma checksum "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\AutoJobLog\AutoJobLogIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bebdb8e6f56d43481e1112565c1f4d55c0df7153"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_AutoJobLog_AutoJobLogIndex), @"mvc.1.0.view", @"/Areas/SystemManage/Views/AutoJobLog/AutoJobLogIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SystemManage/Views/AutoJobLog/AutoJobLogIndex.cshtml", typeof(AspNetCore.Areas_SystemManage_Views_AutoJobLog_AutoJobLogIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bebdb8e6f56d43481e1112565c1f4d55c0df7153", @"/Areas/SystemManage/Views/AutoJobLog/AutoJobLogIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_AutoJobLog_AutoJobLogIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\AutoJobLog\AutoJobLogIndex.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
            BeginContext(53, 1065, true);
            WriteLiteral(@"<div class=""container-div"">
    <div class=""row"">
        <div id=""searchDiv"" class=""col-sm-12 search-collapse"">
            <div class=""select-list"">
                <ul>
                    <li>
                        任务名称：<input id=""jobName"" col=""JobName"" type=""text"" />
                    </li>
                    <li>
                        <a id=""btnSearch"" class=""btn btn-primary btn-sm"" onclick=""searchGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""btn-group-sm hidden-xs"" id=""toolbar"">
            <a id=""btnDelete"" class=""btn btn-danger disabled"" onclick=""deleteForm()""><i class=""fa fa-remove""></i> 删除</a>
        </div>
        <div class=""col-sm-12 select-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(function () {
        initGrid();
    });

    functi");
            WriteLiteral("on initGrid() {\r\n        var queryUrl = \'");
            EndContext();
            BeginContext(1119, 56, false);
#line 33 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\AutoJobLog\AutoJobLogIndex.cshtml"
                   Write(Url.Content("~/SystemManage/AutoJobLog/GetPageListJson"));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 453, true);
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: 'Id', visible: false },
                { field: 'JobName', title: '任务名称' },
                {
                    field: 'LogStatus', title: '执行状态', align: 'center',
                    formatter: function (value, row, index) {
                        if (value == """);
            EndContext();
            BeginContext(1629, 38, false);
#line 43 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\AutoJobLog\AutoJobLogIndex.cshtml"
                                 Write(OperateStatusEnum.Success.ParseToInt());

#line default
#line hidden
            EndContext();
            BeginContext(1667, 81, true);
            WriteLiteral("\") {\r\n                            return \'<span class=\"badge badge-primary\">\' + \"");
            EndContext();
            BeginContext(1749, 42, false);
#line 44 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\AutoJobLog\AutoJobLogIndex.cshtml"
                                                                      Write(OperateStatusEnum.Success.GetDescription());

#line default
#line hidden
            EndContext();
            BeginContext(1791, 125, true);
            WriteLiteral("\" + \'</span>\';\r\n                        } else {\r\n                            return \'<span class=\"badge badge-warning\">\' + \"");
            EndContext();
            BeginContext(1917, 39, false);
#line 46 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\AutoJobLog\AutoJobLogIndex.cshtml"
                                                                      Write(OperateStatusEnum.Fail.GetDescription());

#line default
#line hidden
            EndContext();
            BeginContext(1956, 1129, true);
            WriteLiteral(@""" + '</span>';
                        }
                    }
                },
                { field: 'Remark', title: '任务信息' },
                {
                    field: 'BaseCreateTime', title: '创建时间', formatter: function (value, row, index) {
                        return ys.formatDate(value, ""yyyy-MM-dd HH:mm:ss"");
                    }
                }
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $('#searchDiv').getWebControls(pagination);
                return queryString;
            }
        });
    }

    function searchGrid() {
        $('#gridTable').ysTable('search');
        resetToolbarStatus();
    }

    function deleteForm() {
        var selectedRow = $(""#gridTable"").bootstrapTable(""getSelections"");
        if (ys.checkRowDelete(selectedRow)) {
            ys.confirm(""确认要删除选中的"" + selectedRow.length + ""条数据吗？"", function () {");
            WriteLiteral("\n                var ids = ys.getIds(selectedRow);\r\n                ys.ajax({\r\n                    url: \'");
            EndContext();
            BeginContext(3086, 55, false);
#line 76 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\SystemManage\Views\AutoJobLog\AutoJobLogIndex.cshtml"
                     Write(Url.Content("~/SystemManage/AutoJobLog/DeleteFormJson"));

#line default
#line hidden
            EndContext();
            BeginContext(3141, 478, true);
            WriteLiteral(@"' + '?ids=' + ids,
                    type: ""post"",
                    success: function (obj) {
                        if (obj.Tag == 1) {
                            ys.msgSuccess(obj.Message);
                            searchGrid();
                        }
                        else {
                            ys.msgError(obj.Message);
                        }
                    }
                });
            });
        }
    }
</script>
");
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
