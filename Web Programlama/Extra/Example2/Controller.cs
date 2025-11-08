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
Controlller (İstek Yöneticis)
    Controller, kullanıcı -> sunucu isteği geldiğinde çalışır.
    Model ile veriyi toplar
    View ile gönderir.

Rolü:
    İstekleri karşılar.
    Gerekirse Model için veriyi işler.
    Sonuçları View'a yollar.
*/
