using EjemploModelado.Web;
using EjemploModelado.Web.Domain.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


/*builder.Services.AddSingleton<ApiServiceComponente>();
builder.Services.AddSingleton<ApiServiceComputadora>();*/

ApiServiceComputadora.Singleton();
ApiServiceComponente.Singleton();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


await builder.Build().RunAsync();


