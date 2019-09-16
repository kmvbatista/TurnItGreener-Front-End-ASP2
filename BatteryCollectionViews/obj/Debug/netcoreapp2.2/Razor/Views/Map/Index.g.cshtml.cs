#pragma checksum "C:\Users\moc\Desktop\Turn IT Greener\BatteryCollectionViews\Views\Map\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a98a92367e760964c8f2a1eec73f17e27bbff6ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Map_Index), @"mvc.1.0.view", @"/Views/Map/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Map/Index.cshtml", typeof(AspNetCore.Views_Map_Index))]
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
#line 1 "C:\Users\moc\Desktop\Turn IT Greener\BatteryCollectionViews\Views\_ViewImports.cshtml"
using BatteryCollectionViews;

#line default
#line hidden
#line 2 "C:\Users\moc\Desktop\Turn IT Greener\BatteryCollectionViews\Views\_ViewImports.cshtml"
using BatteryCollectionViews.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a98a92367e760964c8f2a1eec73f17e27bbff6ef", @"/Views/Map/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d54da6e7bf3fdb08bb60db08b2e15a44921879", @"/Views/_ViewImports.cshtml")]
    public class Views_Map_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\moc\Desktop\Turn IT Greener\BatteryCollectionViews\Views\Map\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(54, 344, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a98a92367e760964c8f2a1eec73f17e27bbff6ef3529", async() => {
                BeginContext(60, 331, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title> Turn IT Greener </title>
    <link rel=""icon"" href=""img/battery logo.png"" type=""image/x-icon"">
    <style>
        #map {
            height: 100%;
        }

        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(398, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(400, 2274, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a98a92367e760964c8f2a1eec73f17e27bbff6ef5048", async() => {
                BeginContext(406, 2261, true);
                WriteLiteral(@"
    <div id=""map""></div>
    <script>

        var marker;

        function initMap() {
            var map = new google.maps.Map(document.getElementById('map'), {
                zoom: 14,
                center: { lat: -26.886795, lng: -49.074723 }
            });

            marker = new google.maps.Marker({
                map: map,
                draggable: true,
                animation: google.maps.Animation.DROP,
                position: { lat: -26.913908, lng: -49.069138 },
                label: {
                    text: ""Prefeitura"",
                    color: '#000',
                    fontSize: '25px'
                }
            });

            marker1 = new google.maps.Marker({
                map: map,
                draggable: true,
                animation: google.maps.Animation.DROP,
                position: { lat: -26.863587, lng: -49.090257 },
                label: {
                    text: ""Atacadão"",
                    color: '#000',
   ");
                WriteLiteral(@"                 fontSize: '25px'
                }
            });

            marker2 = new google.maps.Marker({
                map: map,
                draggable: true,
                animation: google.maps.Animation.DROP,
                position: { lat: -26.867379, lng: -49.061928 },
                label: {
                    text: ""Galegão"",
                    color: '#000',
                    fontSize: '25px'
                }
            });

            marker3 = new google.maps.Marker({
                map: map,
                draggable: true,
                animation: google.maps.Animation.DROP,
                position: { lat: -26.886647, lng: -49.099737 },
                label: {
                    text: ""Samae"",
                    color: '#000',
                    fontSize: '25px'
                }
            });

            marker.setDraggable(false);
            marker1.setDraggable(false);
            marker2.setDraggable(false);
            mark");
                WriteLiteral("er3.setDraggable(false);\r\n        }\r\n    </script>\r\n    <script async defer\r\n            src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyA3wA5Sjsuv-acrwFO5wG71UODgpJ5d0wY&callback=initMap\">\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2674, 9, true);
            WriteLiteral("\r\n</html>");
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
