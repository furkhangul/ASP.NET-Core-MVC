using Microsoft.AspNetCore.Mvc;
using Basic.Models;
namespace Basic.Models
{

    public class AppController : Controller
    {

        public IActionResult Topic()
        {
            string[] Konular = new String[]
            {
                "Toplum Ahlakı",
                "Keşif ve Yapılandırma",
                "Emeller ve Kazançlar",
                "Kötülük Problemi",
                "Sağlığın Litaratürü",
                "Karşıt Fikir",
                "Tanrı Kavramı",
                "Devlet Üzerine"
            };
            return View("Topic", Konular);
        }

        public IActionResult Users()
        {
            var users = new List<App>
            {
                new App(){FirstName="Furkan",LastName="Gül", Age=20, Departmant="Software Engeener" },
                new App(){FirstName="Kemal", LastName="Yelim", Age=30, Departmant="Departmant Cheff"},
                new App(){FirstName="Ayşe", LastName="Kara", Age=25, Departmant="HR Specialist"},
                new App(){FirstName="Mehmet", LastName="Yılmaz", Age=28, Departmant="Finance Analyst"},
                new App(){FirstName="Zeynep", LastName="Demir", Age=32, Departmant="Marketing Manager"},
                new App(){FirstName="Ali", LastName="Çelik", Age=22, Departmant="Intern"},
                new App(){FirstName="Elif", LastName="Şahin", Age=27, Departmant="Product Designer"},
                new App(){FirstName="Burak", LastName="Kaya", Age=35, Departmant="Operations Lead"}
            };
            return View("Users",users);
        }

        public IActionResult About()
        {
            return View("About");
        }
    }
}
