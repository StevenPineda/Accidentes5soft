#pragma checksum "C:\ProyectoAccidentes\Accidentes5soft\AccidenteTransito.App\AccidenteTransito.App.Frontend\Pages\Accidentes\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc05e552d87d7d46bfc96a04dee4900657b143fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AccidenteTransito.App.Frontend.Pages.Accidentes.Pages_Accidentes_Detalle), @"mvc.1.0.razor-page", @"/Pages/Accidentes/Detalle.cshtml")]
namespace AccidenteTransito.App.Frontend.Pages.Accidentes
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
#line 1 "C:\ProyectoAccidentes\Accidentes5soft\AccidenteTransito.App\AccidenteTransito.App.Frontend\Pages\_ViewImports.cshtml"
using AccidenteTransito.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc05e552d87d7d46bfc96a04dee4900657b143fc", @"/Pages/Accidentes/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f14937e245165627f93eaede5acdbcce5dc00e3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Accidentes_Detalle : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Accidente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #19284C; color: white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\ProyectoAccidentes\Accidentes5soft\AccidenteTransito.App\AccidenteTransito.App.Frontend\Pages\Accidentes\Detalle.cshtml"
  
ViewData["Title"] = "Detalle de Accidente";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-8 offset-2"">
            <h2 style=""color: #19284C;"">Detalle de Accidente: Html.DisplayFor(m => m.Accidente.Id)</h2>
            <ul class=""list-group"">
                <li class=""list-group-item"">ID: Html.DisplayFor(m => m.Accidente.Id)</li>
                <li class=""list-group-item"">Dirección: Html.DisplayFor(m => m.Accidente.Direccion)</li>
                <li class=""list-group-item"">Latitud: Html.DisplayFor(m => m.Accidente.Latitud)</li>
                <li class=""list-group-item"">Longitud: Html.DisplayFor(m => m.Accidente.Longitud)</li>
                <li class=""list-group-item"">Barrio: Html.DisplayFor(m => m.Accidente.Barrio)</li>
                <li class=""list-group-item"">Fecha: Html.DisplayFor(m => m.Accidente.Fecha)</li>
                <li class=""list-group-item"">Hora: Html.DisplayFor(m => m.Accidente.Hora)</li>
                <li class=""list-group-item"">Tipo de Accidente: Html.DisplayFor(m => m.Accidente.TipoAcc");
            WriteLiteral(@"idente)</li>
                <li class=""list-group-item"">Agente de Tránsito: Html.DisplayFor(m => m.Accidente.AgenteTransito.Nombre)</li>
                <li class=""list-group-item"">Usuario: Html.DisplayFor(m => m.Accidente.Involucrado.Nombre)</li>
                <li class=""list-group-item"">Vehículo: Html.DisplayFor(m => m.Accidente.Vehiculo.Placa)</li>
                <li class=""list-group-item"">Descripción: Html.DisplayFor(m => m.Accidente.Descripcion)</li>
            </ul>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-6"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc05e552d87d7d46bfc96a04dee4900657b143fc6040", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccidenteTransito.App.Frontend.Pages.DetalleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccidenteTransito.App.Frontend.Pages.DetalleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccidenteTransito.App.Frontend.Pages.DetalleModel>)PageContext?.ViewData;
        public AccidenteTransito.App.Frontend.Pages.DetalleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
