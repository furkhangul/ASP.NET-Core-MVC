namespace Basic.Controllers;

using Basic.Models;
using Microsoft.AspNetCore.Mvc;

public class Veri : Controller
{
    public IActionResult Index()
    {
        return View();
    }






    /*
    Model ile ViewBag :


    Model asıl verilerin tutulduğu yer yani oyuncak kutusu olarak düşünebiliriz. 
    Bütün veriler bu oyuncak kutusunun içinde bilgileri ile tutumaktadır.
    Viewbag ise küçük notların tutulduğu post-it gibi düşünebiliriz bunu. Bazen hızlıca bir şey söylemek isteriz
    ama koca kutuyu yani modeli taşımak gerekmez iken kullanırız.
    Mesela bir veriyi görmek değilde sadece saklamak için çekmek istediğimizde tüm verilere ihtiyacımız yokken kullanabiliriz.
    Yani ViewBag küçük , geçici ve hızlı verileri taşımak için kullanılır.
    */
    public IActionResult ViewBagPage()
    {
        User u = new User
        {
            UserId = 1,
            UserName = "Furkan",
            UserEmail = "gl56frkn@gmail.com",
            UserPassword = "1685410"
        };
        ViewBag.User = u;
        return View();
    }

}