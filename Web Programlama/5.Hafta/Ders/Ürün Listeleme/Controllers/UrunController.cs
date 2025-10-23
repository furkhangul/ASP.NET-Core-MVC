using Microsoft.AspNetCore.Mvc;
using Deneme.Models;
namespace Deneme.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            List<Urun> urunler = new List<Urun>
            {
                new Urun(1, "Laptop", "Yüksek performanslı laptop", 7500.5),
                new Urun(2, "Akıllı Telefon", "Son model akıllı telefon", 4500.6),
                new Urun(3, "Tablet", "Taşınabilir tablet cihazı", 3000.5),
                new Urun(4, "Akıllı Saat", "Fitness takip özellikli akıllı saat", 1500.8)
            };

            return View("Index", urunler);
        }

    }
}
