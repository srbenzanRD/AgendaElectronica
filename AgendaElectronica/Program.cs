using AgendaElectronica.Data;
using AgendaElectronica.Data.Context;
using AgendaElectronica.Data.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<AgendaElectronicaDbContext>();
builder.Services.AddScoped<IAgendaElectronicaDbContext, AgendaElectronicaDbContext>();
builder.Services.AddScoped<IContactoServices, ContactoServices>();
builder.Services.AddScoped<ICiudadesServices, CiudadesServices>();
builder.Services.AddScoped<IFacturaServices,FacturaServices> ();
builder.Services.AddScoped<IProductoServices, ProductoServices> ();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

using (var serviceScope =  app.Services.GetService<IServiceScopeFactory>()!.CreateScope())
{
    var dbContext = serviceScope.ServiceProvider
        .GetRequiredService<AgendaElectronicaDbContext>();
    dbContext.Database.Migrate();
    await AgendaElectronicaDbContextSeeder.Inicializar(dbContext);
}

    app.Run();
