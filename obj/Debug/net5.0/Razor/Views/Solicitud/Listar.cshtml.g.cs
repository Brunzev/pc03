#pragma checksum "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd9666ad3e17ad42ec4e90f58000115963eff390"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Solicitud_Listar), @"mvc.1.0.view", @"/Views/Solicitud/Listar.cshtml")]
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
#line 1 "C:\PROGRAMACIÓN I\pc03\Views\_ViewImports.cshtml"
using pc03;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROGRAMACIÓN I\pc03\Views\_ViewImports.cshtml"
using pc03.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd9666ad3e17ad42ec4e90f58000115963eff390", @"/Views/Solicitud/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea5d2ec802b9f5328fe3cdbb845ebcb4b3437e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Solicitud_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Solicitud>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
  
    Layout = "_Solicitud";
    ViewData["Tittle"] = "LISTA";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">LISTA DE PRODUCTOS</h1>\r\n    \r\n");
#nullable restore
#line 10 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
     if (Model.Count == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>NO HAY PRODUCTOS REGISTRADOS</p>\r\n");
#nullable restore
#line 12 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n  <div class=\"container\">\r\n    <h1>");
#nullable restore
#line 15 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"row\">\r\n      <div class=\"col\">\r\n        <div id=\"products\" class=\"mb-3\">\r\n          <div class=\"row\">\r\n");
#nullable restore
#line 20 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
             foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-4\">\r\n              <div class=\"card mb-3\">\r\n                <div class=\"card-body\">\r\n                  <div class=\"card-img-actions\">\r\n                    <img class=\"img-responsive\" width=\"96\" height=\"150\"");
            BeginWriteAttribute("src", "\r\n                       src=\"", 730, "\"", 770, 1);
#nullable restore
#line 26 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
WriteAttributeValue("", 760, item.foto, 760, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Icono\"  />\r\n                  </div>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                  <h5 class=\"card-title\">");
#nullable restore
#line 30 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 31 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 32 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 33 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 34 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.lugar));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 35 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 36 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.categoria.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  \r\n                </div>\r\n              </div>\r\n            </div>\r\n");
#nullable restore
#line 41 "C:\PROGRAMACIÓN I\pc03\Views\Solicitud\Listar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("         </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Solicitud>> Html { get; private set; }
    }
}
#pragma warning restore 1591
