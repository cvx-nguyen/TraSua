using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TraSua.Client;
using TraSua.Shared;
using Blazored.Toast;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Notifications;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<IMenuService, HardCodeMenuService>();
builder.Services.AddTransient<IOrderService, ConsoleOrderService>();
//builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
builder.Services.AddBlazoredToast();

await builder.Build().RunAsync();
