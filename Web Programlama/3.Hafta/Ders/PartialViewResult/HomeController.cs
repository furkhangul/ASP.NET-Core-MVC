
using Microsoft.AspNetCore.Mvc;
namespace Hafta3.Controllers;

public class HomeController : Controller
{   
    public PartialViewResult Index()
    {
        return PartialView();
    }

}
