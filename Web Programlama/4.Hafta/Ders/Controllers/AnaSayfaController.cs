using Microsoft.AspNetCore.Mvc;

namespace Ders.Controllers{
  public class AnaSayfa : Controller{
      public IActionResult Index(){
          return View();
      }
  }
}

//Burada Mcv uygulamasını kullanacağımızı bildirip. AnaSayfa adındaki Controller'i açıp bu controlleri
//Index'e bağladık. yani açılan ilk sayfa Index sayfası olacak.
