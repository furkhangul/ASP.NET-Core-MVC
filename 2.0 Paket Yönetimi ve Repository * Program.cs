var builder = WebApplication.CreateBuilder(args);


//MVC İÇİN GEREKLİ VİEWS,CONTROLLERS VE MODEL YAPISINI İMPORT ETTİK
//Bu 3 klasörü kendimiz elle ekliyoruz.
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseHttpsRedirection();

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
app.Run();

//Elimdeki NUget paket yöneticisini düzenlemek için :
//dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 10.0.0-rc.1.25451.107
//kodunu terminale giriyorum.

//ardından paketleri göstermek için:
//dotnet list package diyoruz.
//hemen ardından eklemek için
//dotnet add package Microsoft.EntityFrameworkCore diyerek şablona yüklüyoruz.
//dotnet list package diyoruz ve eklediğimiz diğer paketi de görüyoruz.
//Ayrıca dosyalar bölümünde storeapp.csproj adındaki dosyada da mevcut bilgiler bulunuyor.


