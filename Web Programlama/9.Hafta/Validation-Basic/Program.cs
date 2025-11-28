var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddApplicationInsightsTelemetry();

var app = builder.Build();
app.MapControllerRoute("main","{controller=Home}/{action=Index}/{id?}");


app.UseStaticFiles(new StaticFileOptions()
{
    RequestPath = "/wwwroot"
});
app.Run();