using MemeMatch.Data;
using Microsoft.EntityFrameworkCore;
using MemeMatch.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(option =>
option.UseSqlite("Data Source=memematch.db"));

builder.Services.AddControllersWithViews();

builder.Services.AddSession();

builder.Services.AddScoped<GameService>();

var app = builder.Build();

app.UseStaticFiles();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
