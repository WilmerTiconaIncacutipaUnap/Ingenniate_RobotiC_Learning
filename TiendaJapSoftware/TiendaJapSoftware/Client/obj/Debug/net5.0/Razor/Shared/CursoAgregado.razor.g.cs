#pragma checksum "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Shared\CursoAgregado.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22d093f97d991abcd6144d713bf8ab6f7c47b587"
// <auto-generated/>
#pragma warning disable 1591
namespace TiendaJapSoftware.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using TiendaJapSoftware.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using TiendaJapSoftware.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using TiendaJapSoftware.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using TiendaJapSoftware.Client.Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    public partial class CursoAgregado : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "elementoCarrito");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Shared\CursoAgregado.razor"
                 OnBorrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", "borrarElemento");
            __builder.AddContent(5, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "texto");
#nullable restore
#line 3 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Shared\CursoAgregado.razor"
__builder.AddContent(9, Curso.NombreCurso);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, " : \n    ");
            __builder.OpenElement(11, "strong");
#nullable restore
#line 4 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Shared\CursoAgregado.razor"
__builder.AddContent(12, Curso.Precio.PrecioVenta.ToString());

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, " €");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Shared\CursoAgregado.razor"
        
    [Parameter] public Curso Curso { get; set; }
    [Parameter] public EventCallback OnBorrar { get; set; } 
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
