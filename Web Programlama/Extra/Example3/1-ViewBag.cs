using Basic.Models;
using Microsoft.AspNetCore.Mvc;



namespace Basic.Controllers
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
    public class Home : Controller
    {
        public IActionResult Index()
        {
            User users = new User()
            {
                Id = 1,
                Name = "Furkan"
            };
            ViewBag.User = users;
            return View(users);
        }
    }
}
