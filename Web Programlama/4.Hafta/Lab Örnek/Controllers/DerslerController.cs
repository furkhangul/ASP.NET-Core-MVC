using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers;

public class Dersler : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Listele()
    {
        List<string> dersler = new List<string>
        {
            "Algoritma Analizi",
            "Mühendisliğe Giriş",
            "Veritabanı Yönetimi",
            "Siber Güvenlik"
        };
        return View("Listele",dersler);
    }
}
