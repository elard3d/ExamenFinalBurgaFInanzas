#pragma checksum "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\Finanzas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3a6569e9b874dffe4bc66348fcac29e676ee5aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finanzas_Index), @"mvc.1.0.view", @"/Views/Finanzas/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\_ViewImports.cshtml"
using ExamenFinalBurgaFInanzas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\_ViewImports.cshtml"
using ExamenFinalBurgaFInanzas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3a6569e9b874dffe4bc66348fcac29e676ee5aa", @"/Views/Finanzas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a39582d88f90f46f1979a7befe8ad8a0cace29fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Finanzas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<a href=""/Finanzas/RegistroCuentaI"">Crear cuenta</a>

<table class=""table table-dark"">

    <tr>

        
        <th>Nombre</th>
        <th>Categoria</th>

        <th>SaldoTotal</th>

        <th>SaldoInicial</th>

        <th>Moneda</th>
        
        <th>Ver detalle</th>
        
      


    </tr>
");
#nullable restore
#line 23 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\Finanzas\Index.cshtml"
     foreach (var item1 in ViewBag.listaDeCuentas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>");
#nullable restore
#line 27 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\Finanzas\Index.cshtml"
           Write(item1.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\Finanzas\Index.cshtml"
           Write(item1.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            \r\n\r\n            <td>");
#nullable restore
#line 32 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\Finanzas\Index.cshtml"
           Write(item1.SaldoTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 33 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\Finanzas\Index.cshtml"
             if (item1.Categoria == "Propia")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Debito</td>\r\n");
#nullable restore
#line 36 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\Finanzas\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 39 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\Finanzas\Index.cshtml"
               Write(item1.SaldoInicial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 40 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\Finanzas\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 41 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\Finanzas\Index.cshtml"
           Write(item1.Moneda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n   \r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 802, "\"", 851, 2);
            WriteAttributeValue("", 809, "/Finanzas/DetalleCuenta?IdCuenta=", 809, 33, true);
#nullable restore
#line 43 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\Finanzas\Index.cshtml"
WriteAttributeValue("", 842, item1.Id, 842, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\USUARIO\RiderProjects\ExamenFinalBurgaFInanzas\ExamenFinalBurgaFInanzas\Views\Finanzas\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
