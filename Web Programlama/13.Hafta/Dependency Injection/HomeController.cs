using Microsoft.AspNetCore.Mvc;
using FurOfTheWeak.Services;
namespace FurOfTheWeak.Controllers
{
    public class HomeController : Controller
    {
        ILog _log;
        public HomeController(ILog log)
        {
            this._log = log;
        }
        public IActionResult Index()
        {
            _log.Log();
            return View();
        }
    }
}
