#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ca46c6fddc3c1e624dee43cd2899efffe83f1a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Pages_FytAdmin_Index), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Index.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Pages_FytAdmin_Index), null)]
namespace FytSoa.Web.Pages.FytAdmin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
#line 2 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ca46c6fddc3c1e624dee43cd2899efffe83f1a9", @"/Pages/FytAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/img/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/echarts.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/macarons.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/nprogress.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Index.cshtml"
  
    ViewData["Title"] = "管理平台";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(173, 227, true);
            WriteLiteral("<div class=\"layui-layout layui-layout-admin\">\r\n    <div class=\"layui-header\">\r\n        <div class=\"layui-logo\">FytErp-进销存管理平台</div>\r\n        <ul class=\"layui-nav layui-layout-left\">\r\n            <li class=\"layui-nav-item pr50\">");
            EndContext();
            BeginContext(400, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5aab02f1ba4144188862bb454969f682", async() => {
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
            EndContext();
            BeginContext(452, 508, true);
            WriteLiteral(@"</li>
        </ul>
        <ul class=""layui-nav layui-layout-right"">
            <li class=""layui-nav-item"">
                <a data-pjax href=""/fytadmin/default""><i class=""layui-icon""></i></a>
            </li>
            <li class=""layui-nav-item"">
                <a href=""/demo/""><i class=""layui-icon""></i><span class=""layui-badge-dot""></span></a>
            </li>
            <li class=""layui-nav-item"">
                <a href=""javascript:;"">
                    <span class=""username"">");
            EndContext();
            BeginContext(961, 78, false);
#line 23 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Index.cshtml"
                                      Write(User.Identities.First(u => u.IsAuthenticated).FindFirst(ClaimTypes.Name).Value);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 61, true);
            WriteLiteral(" <i class=\"layui-icon\"></i></span>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1100, "\"", 1191, 1);
#line 24 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Index.cshtml"
WriteAttributeValue("", 1106, User.Identities.First(u => u.IsAuthenticated).FindFirst(ClaimTypes.Thumbprint).Value, 1106, 85, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1192, 4908, true);
            WriteLiteral(@" class=""layui-nav-img"">
                </a>
                <dl class=""layui-nav-child"">
                    <dd><a data-pjax href=""/fytadmin/sys/admin/"">个人中心</a></dd>
                    <hr />
                    <dd><a href=""/fytadmin/logout/"">退出登录</a></dd>
                </dl>
            </li>
        </ul>
    </div>

    <div class=""layui-side layui-bg-black"">
        <div class=""layui-side-scroll"">
            <!-- 左侧导航区域（可配合layui已有的垂直导航） -->
            <ul class=""layui-nav layui-nav-tree fyt-nav-tree"" lay-filter=""test"">
                <li class=""layui-nav-item layui-nav-itemed"">
                    <a class="""" href=""javascript:;""><i class=""layui-icon""></i>系统管理</a>
                    <dl class=""layui-nav-child"">
                        <dd><a data-pjax href=""/fytadmin/sys/organize/"">部门管理</a></dd>
                        <dd><a data-pjax href=""/fytadmin/sys/role/"">角色管理</a></dd>
                        <dd><a data-pjax href=""/fytadmin/sys/admin/"">用户管理</a></dd>
                ");
            WriteLiteral(@"        <dd><a data-pjax href=""/fytadmin/sys/menu/"">菜单管理</a></dd>
                        <dd><a data-pjax href=""/fytadmin/sys/log/"">系统日志</a></dd>
                        <dd><a data-pjax href=""/fytadmin/sys/codes/"">字典管理</a></dd>
                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a class="""" href=""javascript:;""><i class=""layui-icon""></i>采购管理</a>
                    <dl class=""layui-nav-child"">
                        <dd><a data-pjax href=""/fytadmin/test/"">未完成入库</a></dd>
                        <dd><a href=""javascript:;"">已完成付款</a></dd>
                        <dd><a href=""javascript:;"">未完成到票</a></dd>
                        <dd><a href=""javascript:;"">全部采购</a></dd>
                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a class="""" href=""javascript:;""><i class=""layui-icon""></i>加盟商管理</a>
                    <dl class=""layui-nav-child"">
                        <dd><a data-pjax h");
            WriteLiteral(@"ref=""/fytadmin/shop/index/"">加盟商列表</a></dd>
                        <dd><a data-pjax href=""/fytadmin/shop/staffindex/"">店员管理</a></dd>
                        <dd><a data-pjax href=""/fytadmin/shop/push/"">消息通知</a></dd>
                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a class="""" href=""javascript:;""><i class=""layui-icon""></i>库存管理</a>
                    <dl class=""layui-nav-child"">
                        <dd><a data-pjax href=""/fytadmin/goods/barcode/"">条形码管理</a></dd>
                        <dd><a data-pjax href=""/fytadmin/stock/import/"">入库管理</a></dd>
                        <dd><a data-pjax href=""/fytadmin/stock/export/"">出库管理</a></dd>
                        <dd><a data-pjax href=""/fytadmin/stock/changes/"">调拨管理</a></dd>
                        <dd><a data-pjax href=""/fytadmin/goods/index/"">商品管理</a></dd>
                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a href=""javascript:");
            WriteLiteral(@";""><i class=""layui-icon""></i>财务管理</a>
                    <dl class=""layui-nav-child"">
                        <dd><a href=""javascript:;"">总账</a></dd>
                        <dd><a href=""javascript:;"">应收应付</a></dd>
                        <dd><a href="""">付款核销</a></dd>
                        <dd><a href="""">报表中心</a></dd>
                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a href=""javascript:;""><i class=""layui-icon""></i>会员管理</a>
                    <dl class=""layui-nav-child"">
                        <dd><a href=""javascript:;"">会员列表</a></dd>
                        <dd><a href=""javascript:;"">会员积分</a></dd>
                        <dd><a href="""">消费日志</a></dd>
                        <dd><a href="""">生日祝福</a></dd>
                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a href=""javascript:;""><i class=""layui-icon""></i>销售管理</a>
                    <dl class=""layui-nav-child"">
      ");
            WriteLiteral(@"                  <dd><a href=""javascript:;"">销售明细</a></dd>
                        <dd><a href=""javascript:;"">退货管理</a></dd>
                        <dd><a href="""">返货管理</a></dd>
                        <dd><a href="""">折扣管理</a></dd>
                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a href=""javascript:;""><i class=""layui-icon""></i>报表管理</a>
                    <dl class=""layui-nav-child"">
                        <dd><a href=""javascript:;"">采购报表</a></dd>
                        <dd><a href=""javascript:;"">出入库报表</a></dd>
                        <dd><a href="""">销售报表</a></dd>
                    </dl>
                </li>
            </ul>
        </div>
    </div>

    <div class=""layui-body"" id=""container"">

    </div>
</div>
");
            EndContext();
            BeginContext(6100, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa9fcf48140b40cab98188cb5c4695b5", async() => {
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
            EndContext();
            BeginContext(6173, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6175, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aa7c6d8b105434a9ce0cba8db01ab72", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6245, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6247, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40836af4743f40a0a315624c27e82eb9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6318, 743, true);
            WriteLiteral(@"
<script>
    layui.config({
        base: '/themes/js/modules/'
    }).use(['element', 'layer', 'jquery', 'common', 'pjax'], function () {
        var os = layui.common
            , element = layui.element
            , $ = layui.$;
        $.pjax({
            url: '/fytadmin/default',
            container: '#container',
            fragment: '#container'
        });
        $(document).pjax('a', '#container',
            {
                fragment: ""#container"",
                cache: false,
                show: 'fade'
            }
        );
        $(document).on('pjax:start', function () { NProgress.start(); });
        $(document).on('pjax:end', function () { NProgress.done(); });
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.IndexModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
