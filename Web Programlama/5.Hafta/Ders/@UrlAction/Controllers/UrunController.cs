using Microsoft.AspNetCore.Mvc;

namespace Deneme.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
