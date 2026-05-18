using BalzorInventory.database_01.Data;
using BalzorInventory.database_01.Services;
using BalzorInventory.Presentation.Components;
using BalzorInventory.usecases.ServiceInterfaces;
using BalzorInventory.usecases.UseCases.Inventories.InventoriesUseCase;
using BalzorInventory.usecases.UseCases.Inventories.InventoriesUseCaseInterface;
using BalzorInventory.usecases.UseCases.Quotes;
using BalzorInventory.usecases.UseCases.Quotes.QuotesInterfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbcontext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IQuoteService, QuoteService>();
builder.Services.AddScoped<IViewAllQuotesUseCase,ViewAllQuotesUseCase>();

builder.Services.AddScoped<IInventoryService, InventoryService>();
builder.Services.AddScoped<IViewInventoriesUseCase,ViewInventoriesUseCase>();
builder.Services.AddTransient<ICreateInventoryUseCase, CreateInventoryUseCase>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
