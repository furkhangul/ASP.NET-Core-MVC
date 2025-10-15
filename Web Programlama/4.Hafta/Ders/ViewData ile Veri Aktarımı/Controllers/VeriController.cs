namespace Basic.Controllers;

using Basic.Models;
using Microsoft.AspNetCore.Mvc;

public class Veri : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ViewDataPage()
    {
        User u = new User
        {
            UserId = 1,
            UserName = "Furkan",
            UserEmail = "gl56frkn@gmail.com",
            UserPassword = "1685410"
        };
        ViewData["ekle"] = u;
        return View();
    }

}