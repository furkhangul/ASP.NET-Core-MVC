using Microsoft.AspNetCore.Mvc;
using Project.Models;
namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ekle()
        {
            Data bos = new Data();
            return View(bos);
        }
        [HttpPost]
        public IActionResult Ekle(Data data)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Correct Operation ! ";
            }
            else
            {
                ViewBag.Message = "Noncorrect Operation ! ";
            }
            return View(data);
        }
    }
}
