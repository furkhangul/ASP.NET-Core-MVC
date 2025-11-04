using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Basic.Models;

namespace Basic.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Tupple()
    {
        UserData user = new UserData()
        {
            Id = 1,
            Name = "Furkan",
            Department = "Software"
        };
        ProductData product = new ProductData()
        {

            IDSN = 1,
            Name = "Table",
            Price = 169.99
        };
        var tupple = (user, product);
        return View(tupple);
    }

    [HttpPost]
    public IActionResult Tupple([Bind(Prefix ="Item1")]UserData user,[Bind(Prefix ="Item2")]ProductData product)
    {
        var tupple = (user, product);
        return View(tupple);
    }
}
