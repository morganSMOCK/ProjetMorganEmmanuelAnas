using BlazorApp1.Components;
using BlazorApp1.Services;  // Assure-toi d'avoir cette directive
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Enregistrer le service MongoDB en tant que singleton
builder.Services.AddSingleton<MongoDBService>();

// Enregistrement des autres services nécessaires pour Blazor
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

// Configuration du pipeline HTTP
app.UseStaticFiles();
app.UseAntiforgery();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
