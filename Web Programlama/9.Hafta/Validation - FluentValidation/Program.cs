using FluentValidation;
using FluentValidation.AspNetCore;
using Project.Models.Validators;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddApplicationInsightsTelemetry();



//FluentValidation iþlemini indirdikten sonra FluentValidation’ýn çalýþmasý için Program.cs
//içine bu kodlarý yazmamýzýn temel nedeni, doðrulama (validation) kurallarýnýn otomatik olarak bulunmasý,
//kaydedilmesi ve uygulamaya entegre edilmesidir.


//Bu kod sýnýf istenilen sýnýf içindeki ve alt sýnýflardaki tüm doðrulayýcýlarý (validator) otomatik olarak bulur ve kaydeder.
builder.Services.AddValidatorsFromAssemblyContaining<DataValidator>();
//Bu kod , FluentValidation’ýn ASP.NET Core ile entegrasyonunu saðlar ve doðrulama iþlemlerinin otomatik olarak gerçekleþtirilmesini mümkün kýlar.
builder.Services.AddFluentValidationClientsideAdapters();
//Bu kod eski MVC pipeline içindi, minimal API’de gerekli deðil.
builder.Services.AddFluentValidationAutoValidation();





var app = builder.Build();
app.MapControllerRoute("main","{controller=Home}/{action=Index}/{id?}");


app.UseStaticFiles(new StaticFileOptions()
{
    RequestPath = "/wwwroot"
});
app.Run();