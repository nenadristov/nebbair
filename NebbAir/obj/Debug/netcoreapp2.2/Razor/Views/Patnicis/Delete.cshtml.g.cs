#pragma checksum "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76ddff9b5cb4a5bf75e146f86a52cc0c0aac9f91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patnicis_Delete), @"mvc.1.0.view", @"/Views/Patnicis/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patnicis/Delete.cshtml", typeof(AspNetCore.Views_Patnicis_Delete))]
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
#line 1 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\_ViewImports.cshtml"
using NebbAir;

#line default
#line hidden
#line 2 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\_ViewImports.cshtml"
using NebbAir.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76ddff9b5cb4a5bf75e146f86a52cc0c0aac9f91", @"/Views/Patnicis/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d0ceb8b3d782f89bfe80987ec492bb1dbda3416", @"/Views/_ViewImports.cshtml")]
    public class Views_Patnicis_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NebbAir.Models.Patnici>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(75, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Patnici</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(253, 39, false);
#line 15 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ime));

#line default
#line hidden
            EndContext();
            BeginContext(292, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(356, 35, false);
#line 18 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ime));

#line default
#line hidden
            EndContext();
            BeginContext(391, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(454, 43, false);
#line 21 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prezime));

#line default
#line hidden
            EndContext();
            BeginContext(497, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(561, 39, false);
#line 24 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prezime));

#line default
#line hidden
            EndContext();
            BeginContext(600, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(663, 50, false);
#line 27 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataNaRagjanje));

#line default
#line hidden
            EndContext();
            BeginContext(713, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(777, 46, false);
#line 30 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataNaRagjanje));

#line default
#line hidden
            EndContext();
            BeginContext(823, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(886, 45, false);
#line 33 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PassporNo));

#line default
#line hidden
            EndContext();
            BeginContext(931, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(995, 41, false);
#line 36 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PassporNo));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1099, 44, false);
#line 39 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FlightNo));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1207, 40, false);
#line 42 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FlightNo));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1310, 42, false);
#line 45 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1416, 38, false);
#line 48 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1517, 47, false);
#line 51 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1628, 43, false);
#line 54 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1734, 45, false);
#line 57 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(1779, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1843, 41, false);
#line 60 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(1884, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1947, 42, false);
#line 63 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Return));

#line default
#line hidden
            EndContext();
            BeginContext(1989, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2053, 38, false);
#line 66 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Return));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2154, 43, false);
#line 69 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CarryOn));

#line default
#line hidden
            EndContext();
            BeginContext(2197, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2261, 39, false);
#line 72 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CarryOn));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2363, 43, false);
#line 75 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Trolley));

#line default
#line hidden
            EndContext();
            BeginContext(2406, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2470, 39, false);
#line 78 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Trolley));

#line default
#line hidden
            EndContext();
            BeginContext(2509, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2572, 43, false);
#line 81 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(2615, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2679, 39, false);
#line 84 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(2718, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2756, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76ddff9b5cb4a5bf75e146f86a52cc0c0aac9f9114921", async() => {
                BeginContext(2782, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2792, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76ddff9b5cb4a5bf75e146f86a52cc0c0aac9f9115314", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 89 "C:\Users\risto\source\repos\NebbAir\NebbAir\Views\Patnicis\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PatnikID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2834, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2917, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76ddff9b5cb4a5bf75e146f86a52cc0c0aac9f9117219", async() => {
                    BeginContext(2939, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2955, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2968, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NebbAir.Models.Patnici> Html { get; private set; }
    }
}
#pragma warning restore 1591