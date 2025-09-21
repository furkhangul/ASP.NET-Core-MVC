using Microsoft.AspNetCore.Mvc;

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
    }
}
