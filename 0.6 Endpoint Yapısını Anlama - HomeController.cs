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
    //Burada Index action'ı, varsayılan olarak çağrılacak action'dır.
    //Eğer URL'de action belirtilmemişse varsayılan olarak Index action'
    
    public IActionResult Index()
    {
        return View();
    }
    //Burada Privacy action'ı, URL'de /Home/Privacy şeklinde çağrılabilir.
    //Eğer URL'de controller belirtilmemişse varsayılan olarak Home controller'
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
