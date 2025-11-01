using Microsoft.AspNetCore.Mvc;

namespace Hafta3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            switch (id)
            {
                case 1:
                    return View();
                case 2:
                    return PartialView();
                case 3:
                    return Json("{id:30}");
                case 4:
                    return Content("<h1>Hello World !</h1>");
                case 5:
                    return new EmptyResult();
                case 6:
                    return ViewComponent("");
                default:
                    return View();

            }
        }
    }
}
