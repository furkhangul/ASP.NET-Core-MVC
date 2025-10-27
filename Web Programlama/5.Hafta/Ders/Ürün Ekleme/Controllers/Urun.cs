using Microsoft.AspNetCore.Mvc;
using Basic.Models;
namespace Basic.Controllers
{
    public class Urun : Controller
    {
        public IActionResult Index()
        {
            List<UrunView> yeniurun = new List<UrunView>
            {
                new UrunView(1,"Bilgisayar","32GB Ram",15575.99,true),
                new UrunView(2,"Table", "Kalem Hediyeli", 5646.90,false),
                new UrunView(3,"Telefon","Özel 5G çekim hızı.",9000.99,true),
                new UrunView(4, "Akıllı Saat", "Fitness takip özellikli akıllı saat", 1500.89,true)
            };
            return View("Index", yeniurun);
        }
        
        public IActionResult Ekle()
        {
            return View();
        }
    }
}