using Microsoft.AspNetCore.Mvc;



namespace Basic.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

/*
Acion (Controller içindeki fonksiyon)
    Controller içerisindeki her bir method Action'dır.
    Actionlar Url ile çağrılır. /User/About
    
    Görevi:
    Belirli bir isteğe karşılık işlem yapıp sonuç döndürmek.

    Action Sonucu View olmak zorunda değildir.
    View() -> Sayfa döndürür.
    Redirect() -> Sayfaya yönlendirir.
    Json() -> Json döndürür.
    File() -> Dosya döndürür.
    Content() -> Düz text döndürür.
    String() -> Düz text döndürür.
*/
