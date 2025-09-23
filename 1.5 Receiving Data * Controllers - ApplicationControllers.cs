using Microsoft.AspNetCore.Mvc;
using Basic.Models;
namespace Basic.Controllers
{
    public class Application : Controller
    {
        public IActionResult Index()
        {

            var model = Repostory.Application;
            return View(model);
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
            Repostory.Add(model);
            return View("Feedback",model);
        }
    }
}
