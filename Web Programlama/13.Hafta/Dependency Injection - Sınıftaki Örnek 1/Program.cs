using FurOfTheWeak.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ILog, ConsoleLog>();
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();