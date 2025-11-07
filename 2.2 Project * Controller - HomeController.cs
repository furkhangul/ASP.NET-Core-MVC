using Microsoft.AspNetCore.Mvc;
using Basic.Models;

namespace Basic.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
