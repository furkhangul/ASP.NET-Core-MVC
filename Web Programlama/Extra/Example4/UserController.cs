using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    public class UserController : Controller
    {
        private static List<User> Kullanicilar = new List<User>()
        {
            new User(1,"Furkan","gl56frkn@gmail.com","48651356"),
            new User(2,"Süleyman","suleyman@gmail.com","465463541"),
            new User(3,"Kerem", "keremoerda@gmail.com","2968465"),
            new User(4,"Salih","saligode@gmail.com","5684563")
        };

        public IActionResult Listele()
        {
            return View(Kullanicilar);
        }

        public IActionResult Detay(int id)
        {
            User? detay = Kullanicilar.FirstOrDefault(tum => tum.Id == id);
            return View(detay);
        }
    }
}
