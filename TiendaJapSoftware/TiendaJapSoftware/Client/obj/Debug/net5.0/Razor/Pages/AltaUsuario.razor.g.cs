#pragma checksum "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20391198338ca14b19f87ccd46a9b3b562df5ef0"
// <auto-generated/>
#pragma warning disable 1591
namespace TiendaJapSoftware.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/AltaUsuario")]
    public partial class AltaUsuario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "main");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                      nuevoUsuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                                                   HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<h3>Alta Usuario</h3>\r\n        <hr>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group row");
                __builder2.AddMarkupContent(14, "<label for=\"Nombre\" class=\"col-sm-2 col-form-label\">\r\n                Nombre\r\n            </label>\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "id", "Nombre");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "placeholder", "Nombre");
                __builder2.AddAttribute(21, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                                        nuevoUsuario.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nuevoUsuario.Nombre = __value, nuevoUsuario.Nombre))));
                __builder2.AddAttribute(23, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nuevoUsuario.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __Blazor.TiendaJapSoftware.Client.Pages.AltaUsuario.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 22 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                                          () => nuevoUsuario.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group row");
                __builder2.AddMarkupContent(30, "<label for=\"Apellido\" class=\"col-sm-2 col-form-label\">\r\n                Apellido\r\n            </label>\r\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "id", "Apellido");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "placeholder", "Apellido");
                __builder2.AddAttribute(37, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                                        nuevoUsuario.Apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nuevoUsuario.Apellido = __value, nuevoUsuario.Apellido))));
                __builder2.AddAttribute(39, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nuevoUsuario.Apellido));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __Blazor.TiendaJapSoftware.Client.Pages.AltaUsuario.TypeInference.CreateValidationMessage_1(__builder2, 41, 42, 
#nullable restore
#line 32 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                                          () => nuevoUsuario.Apellido

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group row");
                __builder2.AddMarkupContent(46, "<label for=\"Email\" class=\"col-sm-2 col-form-label\">\r\n                Email\r\n            </label>\r\n            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "id", "Email");
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "placeholder", "Email");
                __builder2.AddAttribute(53, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                                        nuevoUsuario.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nuevoUsuario.Email = __value, nuevoUsuario.Email))));
                __builder2.AddAttribute(55, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nuevoUsuario.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n                ");
                __Blazor.TiendaJapSoftware.Client.Pages.AltaUsuario.TypeInference.CreateValidationMessage_2(__builder2, 57, 58, 
#nullable restore
#line 42 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                                          () => nuevoUsuario.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group row");
                __builder2.AddMarkupContent(62, "<label for=\"Password\" class=\"col-sm-2 col-form-label\">\r\n                Password\r\n            </label>\r\n            ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(65);
                __builder2.AddAttribute(66, "type", "password");
                __builder2.AddAttribute(67, "id", "password");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "placeholder", "Password");
                __builder2.AddAttribute(70, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                                        nuevoUsuario.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nuevoUsuario.Password = __value, nuevoUsuario.Password))));
                __builder2.AddAttribute(72, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nuevoUsuario.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                ");
                __Blazor.TiendaJapSoftware.Client.Pages.AltaUsuario.TypeInference.CreateValidationMessage_3(__builder2, 74, 75, 
#nullable restore
#line 52 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                                          () => nuevoUsuario.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "row content");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "col-md-1");
                __builder2.OpenElement(81, "input");
                __builder2.AddAttribute(82, "type", "submit");
                __builder2.AddAttribute(83, "class", "btn btn-primary");
                __builder2.AddAttribute(84, "value", "Guardar");
                __builder2.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                                                                                       NuevaAlta

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "col-md-2");
                __builder2.OpenElement(89, "input");
                __builder2.AddAttribute(90, "type", "button");
                __builder2.AddAttribute(91, "value", "Cancelar");
                __builder2.AddAttribute(92, "class", "btn btn-danger");
                __builder2.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                                                                                       Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(94, "\r\n    ");
#nullable restore
#line 65 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
__builder.AddContent(95, urlResultado);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 69 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
 if (mostrarError)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TiendaJapSoftware.Client.Shared.DetallesError>(96);
            __builder.AddAttribute(97, "OnCerrar", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 71 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                               () => cerrarCapa()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(98, "TextoError", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
                                                                 mensajeError

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 72 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "D:\Videos\Ejemplos codigo\TiendaJapSoftware\TiendaJapSoftware\Client\Pages\AltaUsuario.razor"
       
    Usuario nuevoUsuario = new Usuario();
    Boolean mostrarError = false;
    String mensajeError = String.Empty;
    String urlResultado = String.Empty;

    public void HandleValidSubmit()
    {
        Console.WriteLine("OnValidSubmit");
    }

 
    async protected void NuevaAlta()
    {
        try
        {

            if (nuevoUsuario.Email != null && nuevoUsuario.Password != null &&
                nuevoUsuario.Nombre != null && nuevoUsuario.Apellido != null)
            {
                urlResultado = await servicioTienda.AltaUsuario(nuevoUsuario);
            }
        }
        catch (Exception ex)
        {
            l.LogError("Se produjo un error: " + ex.ToString());
            mostrarError = true;
            mensajeError = ex.Message;

        }
        finally
        {
            StateHasChanged();
        }

    }

    protected void Cancelar()
    {
        navigationManager.NavigateTo("/");
    }

    private void cerrarCapa()
    {
        mostrarError = false;
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicesTienda servicioTienda { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<AltaUsuario> l { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient ClienteHttp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.TiendaJapSoftware.Client.Pages.AltaUsuario
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
