#pragma checksum "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Shared\RecordarPass.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cf9359a0364b1ca42aac638597e10bcf2f7e9b9"
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
    public partial class RecordarPass : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal bg-secondary");
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "style", "display:block;");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog modal-dialog-scrollable modal-lg ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-content ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-header");
            __builder.AddMarkupContent(11, "<h2>Recordar Password</h2>\r\n                ");
            __builder.OpenElement(12, "buton");
            __builder.AddAttribute(13, "class", "btn btn-danger");
            __builder.AddAttribute(14, "style", "cursor:pointer");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Shared\RecordarPass.razor"
                                                                               OnCerrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "X");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "pedido-contenido");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "class", "form-control col-12");
            __builder.AddAttribute(25, "placeholder", "Email");
            __builder.AddAttribute(26, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Shared\RecordarPass.razor"
                                     OnValueChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Shared\RecordarPass.razor"
                                               valorActual

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => valorActual = __value, valorActual));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "pedido-contenido");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "submit");
            __builder.AddAttribute(36, "class", "form-control col-12 btn btn-primary");
            __builder.AddAttribute(37, "value", "Cambiar Password");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Shared\RecordarPass.razor"
                                                                                                                        OnCambiarPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "pedido-contenido");
#nullable restore
#line 21 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Shared\RecordarPass.razor"
__builder.AddContent(44, url);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Shared\RecordarPass.razor"
       
    [Parameter] public EventCallback OnCerrar { get; set; }
    [Parameter] public EventCallback OnCambiarPassword { get; set; }
    [Parameter] public string valorActual { get; set; }
    [Parameter] public EventCallback<String> CambioTexto { get; set; }
    [Parameter] public string url { get; set; }


    private Task OnValueChanged(ChangeEventArgs e)
    {
        valorActual = e.Value.ToString();
        return CambioTexto.InvokeAsync(valorActual);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
