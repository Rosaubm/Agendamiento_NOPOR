#pragma checksum "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Convenios/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42403bf8c4228c33bc3fc5524d72d3f080d23d0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AgendamientoIPS.App.Frontend.Pages.Convenios.Pages_Convenios_Details), @"mvc.1.0.razor-page", @"/Pages/Convenios/Details.cshtml")]
namespace AgendamientoIPS.App.Frontend.Pages.Convenios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/_ViewImports.cshtml"
using AgendamientoIPS.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42403bf8c4228c33bc3fc5524d72d3f080d23d0c", @"/Pages/Convenios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685192e0f80cf74fb7f7a798cd8cbff867f390d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Convenios_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 3 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Convenios/Details.cshtml"
  
    ViewData["Title"] = "Detalles del Convenio";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n<h1>Detalles del Convenio</h1>\n<table class=\"table table-borderless table-secondary\">\n    <tr>\n        <th scope=\"col\">Convenio</th>\n        <td>");
#nullable restore
#line 11 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Convenios/Details.cshtml"
       Write(Model.convenio.NumConvenio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th scope=\"col\">EPS</th>\n        <td>");
#nullable restore
#line 15 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Convenios/Details.cshtml"
       Write(Model.convenio.EPS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th scope=\"col\">Descuento</th>\n        <td>");
#nullable restore
#line 19 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Convenios/Details.cshtml"
       Write(Model.convenio.Descuento);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\n    </tr>\n</table>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42403bf8c4228c33bc3fc5524d72d3f080d23d0c5107", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgendamientoIPS.App.Frontend.Pages.Convenios.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AgendamientoIPS.App.Frontend.Pages.Convenios.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AgendamientoIPS.App.Frontend.Pages.Convenios.DetailsModel>)PageContext?.ViewData;
        public AgendamientoIPS.App.Frontend.Pages.Convenios.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
