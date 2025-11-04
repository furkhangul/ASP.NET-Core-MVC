using Microsoft.AspNetCore.Mvc;
using Basic.Models;

namespace Basic.Controllers;

public class HomeController : Controller
{
    public string Index(int Id)
    {
        return "Sayfa No: " + Id;
    }

    public string Page(int id)
    {
        //ID bölümü Model Binding kısmında yani Router yaparken pattern: "{controller=Home}/{action=Index}/{id?}"
        //sırasında belirtiliyor fakat name belirtilmediği için bizim eklememiz gerekiyor.
        var name = Request.Query["name"];
        return "Page Id: " + id + " Name: " + name;
    }

    //Gorsel ifadesi manuel url girme işleminin yerine kullanılıyor. Bunun için bir View oluşturduk get ile girilen veriyi okuyoruz.
    //Burada Search s ifadesi formdan gelen bilgileri Id ve Name üzürine atanmasını sağlar.
    public IActionResult Gorsel(Search s)
    {
        //Burada boş ise s hata almamak için nesne oluşturuyoruz.
        if (s is null)
        {
            s = new Search();
        }

        //Request.QueryString ifadesi adres çubuğunda ? ifadesinden sonra gelen kısımları almamızı sağlıyor. 
        //Ornek
        //https://localhost:5001/Home/Gorsel?Id=5&Name=Ali
        //qs: ?Id=5&Name=Ali
        var qs = Request.QueryString;


        //Request.Query.Keys ifadesi sorgudaki tüm isimleri yani ID, Name ifadelerini döndürmeye yarar.
        //Request.Query[] ifadesi ise o keyin value yani girdisini bize döndürüyor.
        foreach (var anahtar in Request.Query.Keys)
        {
            var value = Request.Query[anahtar];
        }
        return View(s);
    }
    

    

}
