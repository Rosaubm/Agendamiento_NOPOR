#pragma checksum "D:\USUARIO\Desktop\agendamiento\Agendamiento_NOPOR\AgendamientoIPS.App.Frontend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5333b9fde46909163f879427b0dcf375955a49fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AgendamientoIPS.App.Frontend.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AgendamientoIPS.App.Frontend.Pages
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
#line 1 "D:\USUARIO\Desktop\agendamiento\Agendamiento_NOPOR\AgendamientoIPS.App.Frontend\Pages\_ViewImports.cshtml"
using AgendamientoIPS.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5333b9fde46909163f879427b0dcf375955a49fb", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6d5b14522a5be8baebeb1b387fba721ec52fcd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\USUARIO\Desktop\agendamiento\Agendamiento_NOPOR\AgendamientoIPS.App.Frontend\Pages\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br>
<div class=""text-center"">
    <h1 class=""display-4"">AgendamientoIPS</h1>
    <h5>Proyecto MINTIC2022, Grupo 32 Ciclo 3<br>Desarrollo de Software, Equipo 1<br><a
            href=""https://github.com/Rosaubm/Agendamiento_NOPOR.git"">Github AgendamientoIPS.App</a></h5><br>
</div>

<div class=""text-center"">
    <img src=""/images/AgendamientoIPS.png"" width=""20%""");
            BeginWriteAttribute("alt", " alt=\"", 441, "\"", 447, 0);
            EndWriteAttribute();
            WriteLiteral(@">
</div>

<hr>
<h2 class=""text-primary"">Construido con</h2>
<ul>
    <li><a href=""https://code.visualstudio.com/"" rel=""nofollow"">Visual Code Studio</a> - Editor de código fuente
        desarrollado.</li>
    <li><a href=""https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15""
            rel=""nofollow"">SQL Server Managment Studio</a> - Ambiente integrado para la administración de la base de
        datos SQL en Windows.</li>
    <li><a href=""https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15""
            rel=""nofollow"">Azure Data Studio</a> - Ambiente integrado para la administración de la base de datos SQL en
        Linux.</li>
</ul>
<hr>
<h2 class=""text-primary"">Autores</h2>
<ul>
    <li><strong>Neyla Villamizar</strong> - <em>Líder de Grupo</em> - <a
            href=""https://github.com/NeylaVillamizar"">NeylaVillamizar</a></li>
    <li><strong>Octavio Caraballo</strong> - <em>Diseñ");
            WriteLiteral(@"ador UI</em> - <a href=""https://github.com/OECA"">OECA</a></li>
    <li><strong>Oscar Guerrero</strong> - <em>Administrador de la Configuración</em> - <a
            href=""https://github.com/oscarjavierg"">oscarjavierg</a></li>
    <li><strong>Patricia Torres</strong> - <em>Diseñador de Software</em> - <a
            href=""https://github.com/Yepato"">Yepato</a></li>
    <li><strong>Rosa Ubaque</strong> - <em>Tester</em> - <a href=""https://github.com/Rosaubm"">Rosaubm</a></li>
    <li><strong>Heri Londoño Salgado </strong> - <em>Docente</em> - <a href=""https://github.com/herilon"">herilon</a>
    </li>
</ul>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
