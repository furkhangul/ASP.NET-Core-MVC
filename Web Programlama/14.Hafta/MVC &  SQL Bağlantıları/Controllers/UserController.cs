using Microsoft.AspNetCore.Mvc;
using WebApplication1.DbContext;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        FurOfTheWeakContext _db;
        public UserController(FurOfTheWeakContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ekle()
        {
            User u = new User()
            {
                Username = "newuser",
                Email = "gl56frkn@gmail.com",
                Code = 12345,
                DeptId = 1
            };
            _db.Users.Add(u);
            _db.SaveChanges();
            return View();
        }

    }
}
