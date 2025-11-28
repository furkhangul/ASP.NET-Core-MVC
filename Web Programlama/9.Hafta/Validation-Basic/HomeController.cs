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
            Data bos = new Data();
            return View(bos);
        }
        [HttpPost]
        public IActionResult Ekle(Data data)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Correct Operation !";
            }
            else
            {
                ViewBag.Message = "İncorrect Operation !";
            }
            return View(data);
        }
    }
}
