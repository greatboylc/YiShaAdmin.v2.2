#pragma checksum "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Tab.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "904bd41c8caa0089f16d4b6b079557fbe11c83ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DemoManage_Views_Form_Tab), @"mvc.1.0.view", @"/Areas/DemoManage/Views/Form/Tab.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DemoManage/Views/Form/Tab.cshtml", typeof(AspNetCore.Areas_DemoManage_Views_Form_Tab))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"904bd41c8caa0089f16d4b6b079557fbe11c83ec", @"/Areas/DemoManage/Views/Form/Tab.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b622e924f35698514110c8d85c04ddd5a27d39", @"/Areas/DemoManage/_ViewImports.cshtml")]
    public class Areas_DemoManage_Views_Form_Tab : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\BaiduNetdiskDownload\网络\YiShaAdmin.v2.2\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Tab.cshtml"
  
    Layout = "~/Views/Shared/_FormGray.cshtml";

#line default
#line hidden
            BeginContext(56, 2962, true);
            WriteLiteral(@"
<div class=""wrapper wrapper-content animated fadeIn"">
    <div class=""row"">
        <div class=""col-sm-6"">
            <div class=""tabs-container"">
                <ul class=""nav nav-tabs"">
                    <li class=""active"">
                        <a data-toggle=""tab"" href=""#tab-1"" aria-expanded=""true""> 第一个选项卡</a>
                    </li>
                    <li class="""">
                        <a data-toggle=""tab"" href=""#tab-2"" aria-expanded=""false"">第二个选项卡</a>
                    </li>
                </ul>
                <div class=""tab-content"">
                    <div id=""tab-1"" class=""tab-pane active"">
                        <div class=""panel-body"">
                            <strong>HTML5 文档类型</strong>
                            <p>Bootstrap 使用到的某些 HTML 元素和 CSS 属性需要将页面设置为 HTML5 文档类型。在你项目中的每个页面都要参照下面的格式进行设置。</p>
                        </div>
                    </div>
                    <div id=""tab-2"" class=""tab-pane"">
                        <div class=""panel-body"">");
            WriteLiteral(@"
                            <strong>移动设备优先</strong>
                            <p>在 Bootstrap 2 中，我们对框架中的某些关键部分增加了对移动设备友好的样式。而在 Bootstrap 3 中，我们重写了整个框架，使其一开始就是对移动设备友好的。这次不是简单的增加一些可选的针对移动设备的样式，而是直接融合进了框架的内核中。也就是说，Bootstrap 是移动设备优先的。针对移动设备的样式融合进了框架的每个角落，而不是增加一个额外的文件。</p>
                        </div>
                    </div>
                </div>


            </div>
        </div>

        <div class=""col-sm-6"">
            <div class=""panel blank-panel"">

                <div class=""panel-heading"">
                    <div class=""panel-title m-b-md"">
                        <h4>图标选项卡</h4>
                    </div>
                    <div class=""panel-options"">

                        <ul class=""nav nav-tabs"">
                            <li class=""active"">
                                <a data-toggle=""tab"" href=""tabs_panels.html#tab-4""><i class=""fa fa-laptop""></i></a>
                            </li>
                            <li class="""">
                               ");
            WriteLiteral(@" <a data-toggle=""tab"" href=""tabs_panels.html#tab-5""><i class=""fa fa-desktop""></i></a>
                            </li>
                            <li class="""">
                                <a data-toggle=""tab"" href=""tabs_panels.html#tab-6""><i class=""fa fa-signal""></i></a>
                            </li>
                            <li class="""">
                                <a data-toggle=""tab"" href=""tabs_panels.html#tab-7""><i class=""fa fa-bar-chart-o""></i></a>
                            </li>
                        </ul>
                    </div>
                </div>

                <div class=""panel-body"">
                    <div class=""tab-content"">
                        <div id=""tab-4"" class=""tab-pane active"">
                            <strong>排版与链接</strong>

                            <p>Bootstrap 排版、链接样式设置了基本的全局样式。分别是： 为 body 元素设置 background-color: #fff; 使用 ");
            EndContext();
            BeginContext(3019, 18, true);
            WriteLiteral("@font-family-base、");
            EndContext();
            BeginContext(3038, 18, true);
            WriteLiteral("@font-size-base 和 ");
            EndContext();
            BeginContext(3057, 44, true);
            WriteLiteral("@line-height-base a变量作为排版的基本参数 为所有链接设置了基本颜色 ");
            EndContext();
            BeginContext(3102, 1906, true);
            WriteLiteral(@"@link-color ，并且当链接处于 :hover 状态时才添加下划线 这些样式都能在 scaffolding.less 文件中找到对应的源码。</p>
                        </div>

                        <div id=""tab-5"" class=""tab-pane"">
                            <strong>Normalize.css</strong>

                            <p>为了增强跨浏览器表现的一致性，我们使用了 Normalize.css，这是由 Nicolas Gallagher 和 Jonathan Neal 维护的一个CSS 重置样式库。</p>
                        </div>
                        <div id=""tab-6"" class=""tab-pane"">
                            <strong>布局容器</strong>

                            <p>Bootstrap 需要为页面内容和栅格系统包裹一个 .container 容器。我们提供了两个作此用处的类。注意，由于 padding 等属性的原因，这两种 容器类不能互相嵌套。</p>
                        </div>
                        <div id=""tab-7"" class=""tab-pane"">
                            <strong>栅格系统</strong>

                            <p>Bootstrap 提供了一套响应式、移动设备优先的流式栅格系统，随着屏幕或视口（viewport）尺寸的增加，系统会自动分为最多12列。它包含了易于使用的预定义类，还有强大的mixin 用于生成更具语义的布局。</p>
                        </div>
                    </div>

                </div>

            </div>");
            WriteLiteral(@"
        </div>
    </div>
    <div class=""row m-b-lg"">
        <div class=""col-sm-6"">
            <div class=""tabs-container"">

                <div class=""tabs-left"">
                    <ul class=""nav nav-tabs"">
                        <li class=""active"">
                            <a data-toggle=""tab"" href=""#tab-8""> 第一个选项卡</a>
                        </li>
                        <li class="""">
                            <a data-toggle=""tab"" href=""#tab-9""> 第二个选项卡</a>
                        </li>
                    </ul>
                    <div class=""tab-content "">
                        <div id=""tab-8"" class=""tab-pane active"">
                            <div class=""panel-body"">
                                <strong>排版与链接</strong>

                                <p>Bootstrap 排版、链接样式设置了基本的全局样式。分别是： 为 body 元素设置 background-color: #fff; 使用 ");
            EndContext();
            BeginContext(5009, 18, true);
            WriteLiteral("@font-family-base、");
            EndContext();
            BeginContext(5028, 18, true);
            WriteLiteral("@font-size-base 和 ");
            EndContext();
            BeginContext(5047, 44, true);
            WriteLiteral("@line-height-base a变量作为排版的基本参数 为所有链接设置了基本颜色 ");
            EndContext();
            BeginContext(5092, 1448, true);
            WriteLiteral(@"@link-color ，并且当链接处于 :hover 状态时才添加下划线 这些样式都能在 scaffolding.less 文件中找到对应的源码。</p>
                            </div>
                        </div>
                        <div id=""tab-9"" class=""tab-pane"">
                            <div class=""panel-body"">
                                <strong>栅格系统</strong>

                                <p>Bootstrap 提供了一套响应式、移动设备优先的流式栅格系统，随着屏幕或视口（viewport）尺寸的增加，系统会自动分为最多12列。它包含了易于使用的预定义类，还有强大的mixin 用于生成更具语义的布局。</p>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>
        <div class=""col-sm-6"">
            <div class=""tabs-container"">
                <div class=""tabs-right"">
                    <ul class=""nav nav-tabs"">
                        <li class=""active"">
                            <a data-toggle=""tab"" href=""#tab-10"">第一个选项卡</a>
                        </li>
                        <li class="""">
                            <a data-toggle=""t");
            WriteLiteral(@"ab"" href=""#tab-11""> 第二个选项卡</a>
                        </li>
                    </ul>
                    <div class=""tab-content "">
                        <div id=""tab-10"" class=""tab-pane active"">
                            <div class=""panel-body"">
                                <strong>排版与链接</strong>

                                <p>Bootstrap 排版、链接样式设置了基本的全局样式。分别是： 为 body 元素设置 background-color: #fff; 使用 ");
            EndContext();
            BeginContext(6541, 18, true);
            WriteLiteral("@font-family-base、");
            EndContext();
            BeginContext(6560, 18, true);
            WriteLiteral("@font-size-base 和 ");
            EndContext();
            BeginContext(6579, 44, true);
            WriteLiteral("@line-height-base a变量作为排版的基本参数 为所有链接设置了基本颜色 ");
            EndContext();
            BeginContext(6624, 642, true);
            WriteLiteral(@"@link-color ，并且当链接处于 :hover 状态时才添加下划线 这些样式都能在 scaffolding.less 文件中找到对应的源码。</p>
                            </div>
                        </div>
                        <div id=""tab-11"" class=""tab-pane"">
                            <div class=""panel-body"">
                                <strong>栅格系统</strong>

                                <p>Bootstrap 提供了一套响应式、移动设备优先的流式栅格系统，随着屏幕或视口（viewport）尺寸的增加，系统会自动分为最多12列。它包含了易于使用的预定义类，还有强大的mixin 用于生成更具语义的布局。</p>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>");
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
