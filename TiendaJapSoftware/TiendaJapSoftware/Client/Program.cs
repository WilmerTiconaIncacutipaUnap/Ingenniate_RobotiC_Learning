using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TiendaJapSoftware.Client.Servicios;


namespace TiendaJapSoftware.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            
           
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddBlazoredSessionStorage();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, Autenticacion>();
            builder.Services.AddScoped<IServicesTienda, ServiciosTienda>();
            await builder.Build().RunAsync();
        }

    }
}
