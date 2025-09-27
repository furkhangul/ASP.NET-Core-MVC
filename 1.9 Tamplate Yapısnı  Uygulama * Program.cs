var builder = WebApplication.CreateBuilder(args);

//MVC İÇİN GEREKLİ VİEWS,CONTROLLERS VE MODEL YAPISINI İMPORT ETTİK
//Bu 3 klasörü kendimiz elle ekliyoruz.
builder.Services.AddControllersWithViews();
var app = builder.Build();

/*
app.MapGet("/", () => "Hello World!");
app.MapGet("/furkan", () => "Furkan Gül");

Bu şekilde sürekli program.cs üzerinden yükleme yapmamız karışıklık
yaratacağından dolayı kendimiz ekliyoruz.
Controller Route ile bunu tek bi bölgeye bağlayacağız.
ayırca uygulamanın routing mekanizmasına da sahip olmasını isteriz.
Ve https çözümü için de tanımlama yapmaktayız.
*/
app.UseHttpsRedirection();

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
app.Run();
