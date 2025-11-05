using Microsoft.AspNetCore.Mvc;
using Basic.Models;

namespace Basic.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult RouteValues(int id)
    {
        var url = Request.RouteValues;
        foreach (var parca in url)
        {
            var key = parca.Key;
            var value = parca.Value;
        }
        return View("Index");
    }
    public IActionResult RouteValues2(string ad, string soyad)
    {
        var url = Request.RouteValues;
        foreach (var parca in url)
        {
            var key = parca.Key;
            var value = parca.Value;
        }
        //Değer almak için ?ad=furkan&soyad=gul yazılabilir
        return View("Index");
    }
}
