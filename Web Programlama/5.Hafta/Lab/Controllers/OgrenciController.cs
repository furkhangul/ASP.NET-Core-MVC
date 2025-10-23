using Microsoft.AspNetCore.Mvc;
using Basic.Models;
using System.Text.Json.Serialization;
namespace Basic.Controllers
{
    public class Ogrenci : Controller
    {

        public IActionResult ContentOrnek()
        {
            return View();
        }
        public JsonResult JsonOrnek()
        {

            List<Data> ogrenci = new List<Data>()
        {
            new Data{Ad="Kerem", No= 1, Bolum="Yazılım Mühendisliği"},
        };
            return Json(ogrenci);
        }

    }
}