using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Controllers
{
    public class HomeController : Controller
    {
        /*public String Index()
        {
            return "Hello Bok !";
        }
        yerine artık kullanacağımız tabir ise 
         */
        public IActionResult Index()
        {
            return View();
         } 
    }
}
