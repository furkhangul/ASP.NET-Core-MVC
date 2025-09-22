using Microsoft.AspNetCore.Mvc;
using Basic.Models;
namespace Basic.Controllers
{
    public class Application : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        //Doğrulama Mekanizması
        [ValidateAntiForgeryToken]
        
        //Formdan geldiğini belirtip Model bölümündeki Candidate Yapısına Aktardık
        public IActionResult Apply([FromForm] Candidate model)
        {
            return View();
        }
    }
}
