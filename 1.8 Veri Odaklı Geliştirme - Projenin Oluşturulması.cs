var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/furkan", () => "Furkan Gül");

app.Run();

//Solutian oluşturmak için öncelikle cmd komut satırına  
//dotnet new sln -o Store şeklinde kodu girip sln kodunu oluşturuyoruz.
//Projeyi solution aeklemek için:
//dotnet sln MySolution.sln add Store/StoreApp yapıyoruz.
//# projeyi doğrudan çalıştırmak için:
/*# projeyi doğrudan çalıştırmak için:
dotnet run --project MyWebApp/MyWebApp.csproj

# veya proje klasörüne girip çalıştır:
cd MyWebApp
dotnet run
*/

