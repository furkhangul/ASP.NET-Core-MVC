namespace Basic.Controllers;

using Basic.Models;
using Microsoft.AspNetCore.Mvc;

public class Veri : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult TempDataPage()
    {
        User u = new User
        {
            UserId = 1,
            UserName = "Furkan",
            UserEmail = "gl56frkn@gmail.com",
            UserPassword = "1685410"
        };
        TempData["yeni"] = u;
        return View();
    }

}