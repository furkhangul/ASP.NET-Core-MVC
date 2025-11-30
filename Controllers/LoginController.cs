using FurOfTheWeak.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurOfTheWeak.Controllers
{
    public class Login : Controller
    {
        public static Data Admin = new Data()
        {
            ID = 1,
            Username = "admin",
            Email = "admin@gmail.com",
            Password = "the.lord01"
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Data());
        }

        [HttpPost]
        //Güvenliği sağlaması için kullandım. 
        [ValidateAntiForgeryToken]
        public IActionResult Index(Data data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }

            if (Admin.Username != data.Username || Admin.Password != data.Password)
            {
                return View();
            }

            return View("Redirect");
        }
    }
}
