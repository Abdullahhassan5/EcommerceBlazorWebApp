using ECommerceWebApp;
using ECommerceWebApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7102/") }); // Your API base URL
builder.Services.AddSingleton<CartService>();
builder.Services.AddScoped<ProductService>();

await builder.Build().RunAsync();
