#pragma checksum "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d84ce157291897834faebc2cad2081dcbc97d21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AgendamientoIPS.App.Frontend.Pages.Citas.Pages_Citas_Details), @"mvc.1.0.razor-page", @"/Pages/Citas/Details.cshtml")]
namespace AgendamientoIPS.App.Frontend.Pages.Citas
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d84ce157291897834faebc2cad2081dcbc97d21", @"/Pages/Citas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685192e0f80cf74fb7f7a798cd8cbff867f390d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Citas_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddMedico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddPaciente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddSede", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
  
    ViewData["Title"] = "Detalles de Cita";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n<h1>Detalles de Cita</h1>\n<table class=\"table table-borderless table-secondary\">\n    <tr>\n        <th scope=\"col\">Número de Cita</th>\n        <td>");
#nullable restore
#line 11 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
       Write(Model.cita.NumCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th scope=\"col\">Tipo de Cita</th>\n        <td>");
#nullable restore
#line 15 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
       Write(Model.cita.TipoCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th scope=\"col\">Especialidad</th>\n        <td>");
#nullable restore
#line 19 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
       Write(Model.cita.Especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th scope=\"col\">Fecha de la Cita</th>\n        <td>");
#nullable restore
#line 23 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
       Write(Model.cita.Fecha.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th scope=\"col\">Hora de la Cita</th>\n        <td>");
#nullable restore
#line 27 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
       Write(Model.cita.Hora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th scope=\"col\">Médico Asignado</th>\n");
#nullable restore
#line 31 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
         if (Model.cita.IdMedico == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d84ce157291897834faebc2cad2081dcbc97d217415", async() => {
                WriteLiteral("Asignar Médico");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
                                                                    WriteLiteral(Model.cita.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n");
#nullable restore
#line 36 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 39 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
           Write(Model.cita.IdMedico.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 40 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n        <th scope=\"col\">Médico Primer Apellido</th>\n");
#nullable restore
#line 44 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
         if (Model.cita.IdMedico == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td></td>\n");
#nullable restore
#line 47 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 50 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
           Write(Model.cita.IdMedico.PrimerApellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 51 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n        <th scope=\"col\">Médico Segundo Apellido</th>\n");
#nullable restore
#line 55 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
         if (Model.cita.IdMedico == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td></td>\n");
#nullable restore
#line 58 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 61 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
           Write(Model.cita.IdMedico.SegundoApellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 62 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n        <th scope=\"col\">Especialidad del Médico</th>\n");
#nullable restore
#line 66 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
         if (Model.cita.IdMedico == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td></td>\n");
#nullable restore
#line 69 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 72 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
           Write(Model.cita.IdMedico.Especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 73 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n        <th scope=\"col\">Tarjeta Profesional</th>\n");
#nullable restore
#line 77 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
         if (Model.cita.IdMedico == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td></td>\n");
#nullable restore
#line 80 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 83 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
           Write(Model.cita.IdMedico.TarjetaProfesional);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 84 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n        <th scope=\"col\">Paciente</th>\n");
#nullable restore
#line 88 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
         if (Model.cita.IdPaciente == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d84ce157291897834faebc2cad2081dcbc97d2115687", async() => {
                WriteLiteral("Asignar Paciente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
                                                                      WriteLiteral(Model.cita.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n");
#nullable restore
#line 93 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 96 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
           Write(Model.cita.IdPaciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 97 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n        <th scope=\"col\">Paciente Primer Apellido</th>\n");
#nullable restore
#line 101 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
         if (Model.cita.IdPaciente == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td></td>\n");
#nullable restore
#line 104 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 107 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
           Write(Model.cita.IdPaciente.PrimerApellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 108 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n        <th scope=\"col\">Paciente Segundo Apellido</th>\n");
#nullable restore
#line 112 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
         if (Model.cita.IdPaciente == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td></td>\n");
#nullable restore
#line 115 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 118 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
           Write(Model.cita.IdPaciente.SegundoApellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 119 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n        <th scope=\"col\">Dirección</th>\n");
#nullable restore
#line 123 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
         if (Model.cita.IdPaciente == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td></td>\n");
#nullable restore
#line 126 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 129 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
           Write(Model.cita.IdPaciente.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 130 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n        <th scope=\"col\">Teléfono</th>\n");
#nullable restore
#line 134 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
         if (Model.cita.IdPaciente == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td></td>\n");
#nullable restore
#line 137 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 140 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
           Write(Model.cita.IdPaciente.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 141 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n        <th scope=\"col\">Correo Electrónico</th>\n");
#nullable restore
#line 145 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
         if (Model.cita.IdPaciente == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td></td>\n");
#nullable restore
#line 148 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 151 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
           Write(Model.cita.IdPaciente.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 152 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n        <th scope=\"col\">Sede</th>\n");
#nullable restore
#line 156 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
         if (Model.cita.IdSede == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d84ce157291897834faebc2cad2081dcbc97d2125148", async() => {
                WriteLiteral("Asignar Sede");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 159 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
                                                                  WriteLiteral(Model.cita.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td> \n");
#nullable restore
#line 161 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 164 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
           Write(Model.cita.IdSede.NombreSede);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 164 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
                                         Write(Model.cita.IdSede.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 165 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Citas/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n</table>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d84ce157291897834faebc2cad2081dcbc97d2128589", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgendamientoIPS.App.Frontend.Pages.Citas.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AgendamientoIPS.App.Frontend.Pages.Citas.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AgendamientoIPS.App.Frontend.Pages.Citas.DetailsModel>)PageContext?.ViewData;
        public AgendamientoIPS.App.Frontend.Pages.Citas.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
