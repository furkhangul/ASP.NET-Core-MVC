using Microsoft.AspNetCore.Mvc;

namespace Hafta3.Controllers
{
    public class HomeController : Controller
    {
        public ContentResult ContentSayfa()
        {
            return Content("<h1>Content Sayfası</h1>", "text/html");
        }
    }
}
