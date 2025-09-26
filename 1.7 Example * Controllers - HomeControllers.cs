using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Basic.Models;

namespace Basic.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]

    public IActionResult Register([FromForm] Data model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        bool added = Log.Add(model);
        if (!added)
        {
            ModelState.AddModelError("Email", "Bu email adresiyle zaten kayıt yapılmış!");
            return View(model);
        }
        return View("Feedback", model);
    }


    public IActionResult Members()
    {
        var user = Log.Register();
        return View("Members", user);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
