using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.ViewComponents
{
    public class PersonellerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Personel> personel = new List<Personel>()
            {
                new Personel(){Ad="Ahmet",Soyad="Yılmaz",Departman="Yazılım"},
                new Personel(){Ad="Mehmet",Soyad="Kara", Departman="Güvenlik"},
                new Personel(){Ad="Ayşe",Soyad="Demir", Departman="Direktör"},
                new Personel(){Ad="Fatma",Soyad="Şahin", Departman="Reklam"},
            };

            return View(personel);
        }
    }
}
