
using Microsoft.AspNetCore.Mvc;
namespace Hafta6.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }


}
