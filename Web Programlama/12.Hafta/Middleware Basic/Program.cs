var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.Use(async (context, next) =>
{
    Console.WriteLine("1.Use Middleware Çalýþýyor.");
    await next.Invoke();
    Console.WriteLine("1.Use Middleware Durdu.");
});
app.Use(async (context, next) =>
{
    Console.WriteLine("2.Use Middleware Çalýþýyor.");
    await next.Invoke();
    Console.WriteLine("2.Use Middleware Durdu.");
});
app.Use(async (context, next) =>
{
    Console.WriteLine("3.Use Middleware Çalýþýyor.");
    await next.Invoke();
    Console.WriteLine("3.Use Middleware Durdu.");
});
app.Run(async (context) =>
{
    Console.WriteLine("Run Middleware Çalýþýyor.");
});
app.Run();
