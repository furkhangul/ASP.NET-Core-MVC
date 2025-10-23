var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.MapControllerRoute("main", "{action=Index}/{controller=Home}/{id?}");
app.Run();
