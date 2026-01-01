using FurOfTheWeak.DbContext;
using Microsoft.AspNetCore.Mvc;

namespace FurOfTheWeak.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext _db;
        public HomeController(ProjectContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            var liste = _db.UserData.ToList();
            return View(liste);
        }
        public IActionResult PostList()
        {
            var liste = _db.PostData.ToList();
            return View(liste);
        }
    }
}
