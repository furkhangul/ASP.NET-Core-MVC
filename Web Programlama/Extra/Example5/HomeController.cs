using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Basic.Models;

namespace Basic.Controllers;

public class HomeController : Controller
{
    private static List<UserModel> UserList = new List<UserModel>()
    {
        new UserModel(1,"Furkan"),
        new UserModel(2,"Kerem")
    };
    public IActionResult Index()
    {

        return View(UserList);
    }
    public IActionResult Ekle()
    {
        UserModel bos = new UserModel();
        return View(bos);
    }
    [HttpPost]
    public IActionResult Ekle(UserModel model)
    {
        UserList.Add(model);
        return View(model);
    }
}
