using FurOfTheWeak.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();



//Otomatik olarak singleton olarak kaydeder.
//builder.Services.Add(new ServiceDescriptor(typeof(FurOfTheWeak.Services.TextLogs), new FurOfTheWeak.Services.TextLogs()));
//builder.Services.Add(new ServiceDescriptor(typeof(FurOfTheWeak.Services.ConsoleLog), new FurOfTheWeak.Services.ConsoleLog()));



//Kendimiz deðiþtirmek istediðimizde ise aþaðýdaki gibi yaparýz.
// builder.Services.Add(new ServiceDescriptor(typeof(FurOfTheWeak.Services.TextLogs), new FurOfTheWeak.Services.TextLogs(),ServiceLifetime.Transient ));



//Bu kadar karmaþýk yapmak yerine aþaðýdaki gibi de yapabiliriz.
//builder.Services.AddTransient<ConsoleLog>();




//Fakat eðer bu sýnýflar parametreli constructora sahipse aþaðýdaki gibi yaparýz.
/*
builder.Services.AddTransient<TextLog>(p => new TextLog(5));

*/


//Biz kendi arayüzümüzü ve sýnýfýmýzý kullanarak da yapabiliriz.
builder.Services.AddTransient<ILog, TextLog>();
var app = builder.Build();
app.UseStaticFiles();

app.MapDefaultControllerRoute();
app.Run();
