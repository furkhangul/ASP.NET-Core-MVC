using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    public class EmployeeController : Controller
    {
        public String Index()
        {
            return "Merhabalar Ben Furkan !";
        }

        public ViewResult Giris()
        {
            return View("index");
        }

        public IActionResult Index3()
        {
            return Content("Bu sayfa gelismektedir.");
        }
    }

}
