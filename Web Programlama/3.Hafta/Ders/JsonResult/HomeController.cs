using Hafta3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hafta3.Controllers;

public class HomeController : Controller
{
    public JsonResult Index()
    {
        Urun u = new Urun()
        {
            Id = 1,
            Ad = "Kalem",
            Fiyat = 15.5,
        };
        return Json(u);
    }

}

