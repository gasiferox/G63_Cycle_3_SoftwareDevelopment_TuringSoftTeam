using System.ComponentModel.Design;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProyPeliculas.Client.Services;

namespace ProyPeliculas.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            /* Llamamos la función, pasando la variable builder.Services */
            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }

        /* 
        1. Creamos un meétodo para configurar los servicios de nuestro proyecto
        2. Agregamos servicios para que funcionen de manera independiente, ingresando 
        como parámetro <interfas, implementación>
        3. Llamamos el método dentro del main con configureServices(builder.Services)
        3.1. Tenemos diferentes métodos (addSingleton, addScope, addTransient (No es tan usado))
        */
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IServiceMovie, ServiceMovie>();
            services.AddSingleton<IServiceActor, ServiceActor>();
        }
    }
}
