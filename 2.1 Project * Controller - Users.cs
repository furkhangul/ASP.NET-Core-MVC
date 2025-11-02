using Basic.Models;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace Basic.Controllers
{
    public class Users : Controller
    {

        public static List<Data> UsersList = new List<Data>()
        {
        new Data(1, "furkhangul","gl56frkn@gmail.com", "thelord01"),
        new Data(2, "lolasle","lolollol5656@gmail.com", "loalses5564"),
        new Data(3, "kerimaslans","kerimaslan@hotmail.com", "kerimaskan5623"),
        new Data(4, "saffetcandogan","saffetdogan@gmail.com", "fb1907."),
        new Data(5,"firdevs_yesilyurt","firdevsyesily@gmail.com","6545firdevs")
        };
        public IActionResult List()
        {
            return View(UsersList);
        }


        [HttpGet]
        public IActionResult Add()
        {
            Data bosveri = new Data();
            return View(bosveri);
        }
        [HttpPost]
        public IActionResult Add(Data user)
        {
            UsersList.Add(user);
            return View(user);
        }

        [HttpGet]
        public IActionResult Design(int id)
        {
            Data? willbedesign = UsersList.FirstOrDefault(all => all.Id == id);
            return View(willbedesign);
        }
        [HttpPost]
        public IActionResult Design(Data user)
        {
            Data? designed = UsersList.FirstOrDefault(all => all.Id == user.Id);
            designed.Id = user.Id;
            designed.Username = user.Username;
            designed.Email = user.Email;
            designed.Password = user.Password;

            return View(designed);
        }

        public IActionResult Delete(int id)
        {
            Data? del = UsersList.FirstOrDefault(all => all.Id == id);
            UsersList.Remove(del);
            return RedirectToAction("List");
        }
    }
}
