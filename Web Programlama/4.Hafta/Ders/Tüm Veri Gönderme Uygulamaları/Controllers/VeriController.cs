namespace Basic.Controllers;

using Basic.Models;
using Microsoft.AspNetCore.Mvc;

public class Veri : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult TumVeriGondermeUygulamalari()
    {
        List<User> user = new List<User>()
        {
            new User(1,"Furkan","gl56frkn@gmail.com","655631"),
            new User(2,"Kerem", "kerasm@gmail.com","6853213"),
            new User(3,"Sedat", "sedatkdl@gmail.com", "693563155"),
            new User(4, "Şahin", "sahinsal@gmail.com", "9856168350")

        };
        //ViewBag için kullanım.
        ViewBag.User = user;

        //ViewData için kullanım.
        ViewData["kullanici"] = user;

        //TempData için kullanım.
        TempData["kullanici"] = user;
        return View(user);
    }

}