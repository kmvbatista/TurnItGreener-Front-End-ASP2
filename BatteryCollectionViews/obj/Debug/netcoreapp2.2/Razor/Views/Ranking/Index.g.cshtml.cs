#pragma checksum "C:\Users\Pichau\Desktop\TCC ENTRA21\TurnItGreener-Front-End-ASP2\BatteryCollectionViews\Views\Ranking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad11cdfdfc3353c270089f4004dbd4a3af53f50c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ranking_Index), @"mvc.1.0.view", @"/Views/Ranking/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ranking/Index.cshtml", typeof(AspNetCore.Views_Ranking_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad11cdfdfc3353c270089f4004dbd4a3af53f50c", @"/Views/Ranking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d54da6e7bf3fdb08bb60db08b2e15a44921879", @"/Views/_ViewImports.cshtml")]
    public class Views_Ranking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Pichau\Desktop\TCC ENTRA21\TurnItGreener-Front-End-ASP2\BatteryCollectionViews\Views\Ranking\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(32, 104, true);
            WriteLiteral("    <!-- Breadcrumbs-->\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">\r\n            ");
            EndContext();
            BeginContext(136, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad11cdfdfc3353c270089f4004dbd4a3af53f50c4317", async() => {
                BeginContext(180, 6, true);
                WriteLiteral("Início");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(190, 85, true);
            WriteLiteral("\r\n        </li>\r\n        <li class=\"breadcrumb-item active\">Ranking</li>\r\n    </ol>\r\n");
            EndContext();
            BeginContext(277, 2357, true);
            WriteLiteral(@"    <!-- DataTables Example -->
    <div class=""card mb-3"">
        <div class=""card-header"">
            <i class=""fas fa-fw fa-chart-bar""></i>
            Ranking de Blumenau
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Nome</th>
                            <th>Pontos</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                        </tr");
            WriteLiteral(@">
                        <tr>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                        </tr>
                    </tbody>
                    <tfoot>
                        <tr>
                            <th>Nome</th>
                            <th>Pontos</th>
                        </tr>
                    </tfoot>
                </table>
            </div>
        </div>
    </div>
    <!-- Area ");
            WriteLiteral(@"Chart Example-->
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
            BeginContext(2636, 858, true);
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
#line 106 "C:\Users\Pichau\Desktop\TCC ENTRA21\TurnItGreener-Front-End-ASP2\BatteryCollectionViews\Views\Ranking\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3497, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3517, 406, true);
                WriteLiteral(@"
    <script src=""vendor/chart.js/Chart.min.js""></script>
    <script src=""js/demo/datatables-demo.js""></script>
    <script src=""js/demo/chart-bar-demo.js""></script>
    <script src=""js/demo/chart-pie-demo.js""></script>

    <script type=""text/javascript"">

        function GetJSON_Simple() {
            var resp = [];
            $.ajax({
                type: ""GET"",
                url: '");
                EndContext();
                BeginContext(3924, 41, false);
#line 120 "C:\Users\Pichau\Desktop\TCC ENTRA21\TurnItGreener-Front-End-ASP2\BatteryCollectionViews\Views\Ranking\Index.cshtml"
                 Write(Url.Action("OnGetRankingLine", "Ranking"));

#line default
#line hidden
                EndContext();
                BeginContext(3965, 2506, true);
                WriteLiteral(@"',
                async: false,
                contentType: ""application/json"",
                success: function (data) {
                    resp.push(data);
                },
                error: function (req, status, error) {
                    // do something with error
                    console.log(""error"");
                    console.log(req);
                    console.log(status);
                    console.log(error);
                    alert(""error"");
                }
            });

            return resp;
        }

        var simpleData = GetJSON_Simple();

        // Set new default font family and font color to mimic Bootstrap's default styling
        Chart.defaults.global.defaultFontFamily = '-apple-system,system-ui,BlinkMacSystemFont,""Segoe UI"",Roboto,""Helvetica Neue"",Arial,sans-serif';
        Chart.defaults.global.defaultFontColor = '#292b2c';

        // Area Chart Example
        var ctx = document.getElementById(""myAreaChart"");
        var my");
                WriteLiteral(@"LineChart = new Chart(ctx, {
          type: 'line',
          data: {
            labels: [""Domingo"", ""Segunda"", ""Terça"", ""Quarta"", ""Quinta"", ""Sexta"", ""Sábado""],
            datasets: [{
              label: ""Sessions"",
              lineTension: 0.3,
              backgroundColor: ""rgba(2,117,216,0.2)"",
              borderColor: ""rgba(2,117,216,1)"",
              pointRadius: 5,
              pointBackgroundColor: ""rgba(2,117,216,1)"",
              pointBorderColor: ""rgba(255,255,255,0.8)"",
              pointHoverRadius: 5,
              pointHoverBackgroundColor: ""rgba(2,117,216,1)"",
              pointHitRadius: 50,
              pointBorderWidth: 2,
              data: simpleData[0].myCount,
            }],
          },
          options: {
            scales: {
              xAxes: [{
                time: {
                  unit: 'date'
                },
                gridLines: {
                  display: false
                },
                ticks: {
           ");
                WriteLiteral(@"       maxTicksLimit: 7
                }
              }],
              yAxes: [{
                ticks: {
                  min: 0,
                  max: 1000,
                  maxTicksLimit: 5
                },
                gridLines: {
                  color: ""rgba(0, 0, 0, .125)"",
                }
              }],
            },
            legend: {
              display: false
            }
          }
        });


");
                EndContext();
                BeginContext(6943, 15, true);
                WriteLiteral("    </script>\r\n");
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
