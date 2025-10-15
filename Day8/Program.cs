using Microsoft.EntityFrameworkCore;
using WebApp_Day8.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EShopV10>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EShopV10")));


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<EShopV10>();
    context.Database.EnsureCreated();
    WebApp_Day8.Data.EShopInitializer.Seed(context);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
