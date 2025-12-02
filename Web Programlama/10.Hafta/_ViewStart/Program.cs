var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles(new StaticFileOptions()
{
    RequestPath = "/wwwroot"
});
app.MapControllerRoute("main", "{controller=Home}/{action=Index}/{id?}");
app.Run();