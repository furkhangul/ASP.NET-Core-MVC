using FurOfTheWeak.Models;
using Microsoft.AspNetCore.Mvc;
namespace FurOfTheWeak.Controllers
{
    public class HomeController : Controller
    {
        ILog _log;
        public HomeController(ILog log) 
        {
            _log = log;
        }
        public IActionResult Index()
        {
            _log.LogYaz();
            return View();
        }
    }
}
