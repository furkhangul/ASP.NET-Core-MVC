using Microsoft.AspNetCore.Mvc;
using Basic.Models;

namespace Basic.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Headers()
    {
        var header = Request.Headers;
        List<string> liste = new List<string>();
        foreach (var tut in header)
        {
            var key = header.Keys;
            var value = header.Values;
        }
        return View("Index");
    }
    
    public IActionResult Headers2()
    {
        var header = Request.Headers;
        List<string> liste2 = new List<string>();
        foreach(var tum in header)
        {
            var key = tum.Key;
            var value = tum.Value;
        }
        return View("Index");
    }
}
