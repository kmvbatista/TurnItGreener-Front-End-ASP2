#pragma checksum "C:\Users\Pichau\Desktop\TCC ENTRA21\TurnItGreener-Front-End-ASP2\BatteryCollectionViews\Views\Perfil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bad346f91ecbd74c4c86f18337c50656cf72764d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_Index), @"mvc.1.0.view", @"/Views/Perfil/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Perfil/Index.cshtml", typeof(AspNetCore.Views_Perfil_Index))]
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
#line 1 "C:\Users\Pichau\Desktop\TCC ENTRA21\TurnItGreener-Front-End-ASP2\BatteryCollectionViews\Views\_ViewImports.cshtml"
using BatteryCollectionViews;

#line default
#line hidden
#line 2 "C:\Users\Pichau\Desktop\TCC ENTRA21\TurnItGreener-Front-End-ASP2\BatteryCollectionViews\Views\_ViewImports.cshtml"
using BatteryCollectionViews.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bad346f91ecbd74c4c86f18337c50656cf72764d", @"/Views/Perfil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d54da6e7bf3fdb08bb60db08b2e15a44921879", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Pichau\Desktop\TCC ENTRA21\TurnItGreener-Front-End-ASP2\BatteryCollectionViews\Views\Perfil\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(32, 214, true);
            WriteLiteral("    <!-- Breadcrumbs-->\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">\r\n            <a href=\"#\">Início</a>\r\n        </li>\r\n        <li class=\"breadcrumb-item active\">Meu Perfil</li>\r\n    </ol>\r\n");
            EndContext();
            BeginContext(248, 323, true);
            WriteLiteral(@"    <!-- Area Chart Example-->
    <div class=""card mb-3"">
        <div class=""card-header"">
            <i class=""fas fa-chart-area""></i>
            Pontuação Semanal
        </div>
        <div class=""card-body"">
            <canvas id=""myAreaChart"" width=""100"" height=""30""></canvas>
        </div>
    </div>
");
            EndContext();
            BeginContext(573, 858, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-lg-8"">
            <div class=""card mb-3"">
                <div class=""card-header"">
                    <i class=""fas fa-chart-bar""></i>
                    Pontuação Mensal
                </div>
                <div class=""card-body"">
                    <canvas id=""myBarChart"" width=""100"" height=""50""></canvas>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <div class=""card mb-3"">
                <div class=""card-header"">
                    <i class=""fas fa-chart-pie""></i>
                    Itens Mais Descartados
                </div>
                <div class=""card-body"">
                    <canvas id=""myPieChart"" width=""100"" height=""100""></canvas>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
#line 47 "C:\Users\Pichau\Desktop\TCC ENTRA21\TurnItGreener-Front-End-ASP2\BatteryCollectionViews\Views\Perfil\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1434, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1454, 226, true);
                WriteLiteral("\r\n    <script src=\"vendor/chart.js/Chart.min.js\"></script>\r\n    <script src=\"js/demo/chart-area-demo.js\"></script>\r\n    <script src=\"js/demo/chart-bar-demo.js\"></script>\r\n    <script src=\"js/demo/chart-pie-demo.js\"></script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
