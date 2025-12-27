using Project.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(new StaticFileOptions
{
    RequestPath = "/wwwroot"
});
app.UseFurkan();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();

