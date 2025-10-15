namespace Basic.Controllers;

using Basic.Models;
using Microsoft.AspNetCore.Mvc;

public class Veri : Controller
{
    public IActionResult Index()
    {
        return View();
    }
        public IActionResult Model()
    {
        User v = new User
        {
            UserId = 1,
            UserName = "Furkan",
            UserEmail = "gl56frkn@gmail.com",
            UserPassword = "65364685"

        };
        return View("Model",v);
    }

}