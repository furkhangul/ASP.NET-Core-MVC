using Microsoft.AspNetCore.Mvc;
using Basic.Models;


namespace Basic.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Product pro = new Product()
        {
            Id = 1,
            Name = "Furkan"
        };
        ViewBag.Product = pro;
        ViewData["user"] = pro;
        TempData["user"] = pro;
        return View(pro);   
    }

}
