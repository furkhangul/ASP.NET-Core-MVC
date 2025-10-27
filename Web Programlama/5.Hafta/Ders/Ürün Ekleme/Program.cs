var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.MapControllerRoute("main", "{controller=Home}/{action=Index}/{id?}");
app.Run();