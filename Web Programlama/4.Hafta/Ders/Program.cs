var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();


//App adındaki yapımızı default olarak hangi sayfaya yönlendirileceğini bildidiyoruz.
app.MapControllerRoute("default",  "{controller=AnaSayfa}/{action=Index}/{id?}");


//Uygulamayı ayağa kaldırır.
app.Run();
