<<<<<<< HEAD
#pragma checksum "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba"
=======
<<<<<<< HEAD
#pragma checksum "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Deportista.Pages_Deportista_IndexDepor), @"mvc.1.0.razor-page", @"/Pages/Deportista/IndexDepor.cshtml")]
namespace Frontend.Pages.Deportista
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
#line 1 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba", @"/Pages/Deportista/IndexDepor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e204b5447433fc29832fde3d015c2ce34c8ad9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Deportista_IndexDepor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateDepor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditDepor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DeleteDepor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DetailsDepor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
  
    ViewData["Title"]= "IndexDepor";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Lista de Deportistas</h1>\r\n<p> \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba4515", async() => {
                WriteLiteral(" Crear Deportista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>

<table class=""table"">
    <thead>
        <tr>
            <th> Id </th>   
            <th> Documento </th>  
            <th> Nombre </th> 
            <th> Apellidos </th>
            <th> Disciplina </th>   
            <th> EquipoId </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
         foreach (var depor in Model.Deportistas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td> ");
#nullable restore
#line 26 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
            Write(depor.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>   \r\n            <td> ");
#nullable restore
#line 27 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
            Write(depor.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 28 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
            Write(depor.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>   \r\n            <td> ");
#nullable restore
#line 29 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
            Write(depor.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 30 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
            Write(depor.Disciplina);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>   \r\n            <td> ");
#nullable restore
#line 31 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
            Write(depor.EquipoId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba8090", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
                                            WriteLiteral(depor.Id);

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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba10297", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
                                             WriteLiteral(depor.Id);

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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba12508", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
                                              WriteLiteral(depor.Id);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\57301\Downloads\Repositorio Github\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.Pages.IndexDeporModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.IndexDeporModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.IndexDeporModel>)PageContext?.ViewData;
        public Frontend.Pages.IndexDeporModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
=======
<<<<<<< HEAD
#pragma checksum "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 5\TorneosMunicipales-1\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba"
=======
#pragma checksum "C:\Users\CRIST\Documents\TorneosMunicipales\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba"
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Deportista.Pages_Deportista_IndexDepor), @"mvc.1.0.razor-page", @"/Pages/Deportista/IndexDepor.cshtml")]
namespace Frontend.Pages.Deportista
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
<<<<<<< HEAD
#line 1 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\_ViewImports.cshtml"
=======
<<<<<<< HEAD
#line 1 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 5\TorneosMunicipales-1\Aplicacion\Frontend\Pages\_ViewImports.cshtml"
=======
#line 1 "C:\Users\CRIST\Documents\TorneosMunicipales\Aplicacion\Frontend\Pages\_ViewImports.cshtml"
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba", @"/Pages/Deportista/IndexDepor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e204b5447433fc29832fde3d015c2ce34c8ad9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Deportista_IndexDepor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateDepor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditDepor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DeleteDepor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DetailsDepor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<<<<<<< HEAD
#line 3 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
<<<<<<< HEAD
#line 3 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 5\TorneosMunicipales-1\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
#line 3 "C:\Users\CRIST\Documents\TorneosMunicipales\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
  
    ViewData["Title"]= "IndexDepor";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Lista de Deportistas</h1>\r\n<p> \r\n    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba4572", async() => {
=======
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba4578", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba4458", async() => {
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
                WriteLiteral(" Crear Deportista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>

<table class=""table"">
    <thead>
        <tr>
            <th> Id </th>   
            <th> Documento </th>  
            <th> Nombre </th> 
            <th> Apellidos </th>
            <th> Disciplina </th>   
            <th> EquipoId </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
<<<<<<< HEAD
#line 23 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
<<<<<<< HEAD
#line 23 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 5\TorneosMunicipales-1\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
#line 23 "C:\Users\CRIST\Documents\TorneosMunicipales\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
         foreach (var depor in Model.Deportistas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td> ");
#nullable restore
<<<<<<< HEAD
#line 26 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
<<<<<<< HEAD
#line 26 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 5\TorneosMunicipales-1\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
#line 26 "C:\Users\CRIST\Documents\TorneosMunicipales\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
            Write(depor.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>   \r\n            <td> ");
#nullable restore
#line 27 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
            Write(depor.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 28 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
            Write(depor.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>   \r\n            <td> ");
#nullable restore
#line 29 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
            Write(depor.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
<<<<<<< HEAD
#line 30 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
<<<<<<< HEAD
#line 30 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 5\TorneosMunicipales-1\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
#line 30 "C:\Users\CRIST\Documents\TorneosMunicipales\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
            Write(depor.Disciplina);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>   \r\n            <td> ");
#nullable restore
#line 31 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
            Write(depor.EquipoId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba8280", async() => {
=======
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba8300", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba7900", async() => {
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 33 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
<<<<<<< HEAD
#line 33 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 5\TorneosMunicipales-1\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
#line 33 "C:\Users\CRIST\Documents\TorneosMunicipales\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
                                            WriteLiteral(depor.Id);

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
            WriteLiteral("\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba10506", async() => {
=======
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba10528", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba10088", async() => {
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 34 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
<<<<<<< HEAD
#line 34 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 5\TorneosMunicipales-1\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
#line 34 "C:\Users\CRIST\Documents\TorneosMunicipales\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
                                             WriteLiteral(depor.Id);

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
            WriteLiteral("\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba12736", async() => {
=======
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba12760", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503372c0a2b4a4cbecc52b9fc24b5b2fcc82baba12280", async() => {
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 35 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
<<<<<<< HEAD
#line 35 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 5\TorneosMunicipales-1\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
#line 35 "C:\Users\CRIST\Documents\TorneosMunicipales\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
                                              WriteLiteral(depor.Id);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 38 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 6\Repositorio Github\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
<<<<<<< HEAD
#line 38 "D:\Users\JOAN ANDRES\Desktop\Tic.Ucaldas\Ciclo 3\DS_3\Modulo 5\TorneosMunicipales-1\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
=======
#line 38 "C:\Users\CRIST\Documents\TorneosMunicipales\Aplicacion\Frontend\Pages\Deportista\IndexDepor.cshtml"
>>>>>>> 48e8ca12956641008b493fbc4a8ce8509091362a
>>>>>>> 4b16e537cec700cdc435a1ba8473f60cf4c36360
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.Pages.IndexDeporModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.IndexDeporModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.IndexDeporModel>)PageContext?.ViewData;
        public Frontend.Pages.IndexDeporModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
>>>>>>> 7bc6be9045b1734bdfca64fb388802360600aa9b
