using EPTabletopApp.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EPTabletopApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<FetchService>();
            builder.Services.AddScoped<StatBlockTemplateService>();
            builder.Services.AddScoped<EPDataService>();
            builder.Services.AddScoped<DiscordWebhookService>();

            await builder.Build().RunAsync();
        }
    }
}
