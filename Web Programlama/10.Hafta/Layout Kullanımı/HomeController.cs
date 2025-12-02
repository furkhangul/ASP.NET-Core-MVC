using Microsoft.AspNetCore.Mvc;
using Basic.Models;
namespace Basic.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Data data)
        {
            ViewBag.User = data.Name + data.Surname;
            return View(data);
        }
    }
}
