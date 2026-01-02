using Code_First.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DataDbContext, DataDbContext>();
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();