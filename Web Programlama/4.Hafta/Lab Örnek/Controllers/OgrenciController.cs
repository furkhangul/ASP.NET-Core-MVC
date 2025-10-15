using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers;


public class Ogrenci : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Listele()
    {
        List<string> ogrenci = new List<string>
        {
            "Ali Varol",
            "Kenan Şen",
            "Kemal Yön",
            "Sabri Güvenlik"
        };
        return View("Listele", ogrenci);
    }
}