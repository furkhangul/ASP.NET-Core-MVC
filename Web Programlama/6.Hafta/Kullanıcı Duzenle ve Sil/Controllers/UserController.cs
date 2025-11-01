using Hafta6.Controllers;
using Microsoft.AspNetCore.Mvc;
using Hafta6.Models;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Components.Routing;
public class User : Controller
{
    public static List<Data> Users = new List<Data>()
    {
        new Data(1,"gl56frkn@gmail.com", "furkhangul", "thelord01"),
        new Data(2,"lolollol5656@gmail.com", "lolasle", "loalses5564"),
        new Data(3,"kerimaslan@hotmail.com", "kerimaslans", "kerimaskan5623"),
        new Data(4,"saffetdogan@gmail.com", "saffetcandogan", "fb1907."),
        new Data(5,"firdevsyesily@gmail.com","firdevs_yesilyurt","6545firdevs")
    };
    public IActionResult Listele()
    {
        return View(Users);
    }

    public IActionResult Ekle()
    {
        Data bosveri = new Data();
        return View(bosveri);
    }
    [HttpPost]
    public IActionResult Ekle(Data user)
    {
        Users.Add(user);
        return View(user);
    }
    [HttpGet]
    public IActionResult Duzenle(int id)
    {
        Data? duzenlenecekuser = Users.FirstOrDefault(tum => tum.Id == id);
        return View(duzenlenecekuser);
    }
    [HttpPost]
    public IActionResult Duzenle(Data user)
    {
        Data? duzenlenmisUser = Users.FirstOrDefault(tum => tum.Id == user.Id);
        duzenlenmisUser.Id = user.Id;
        duzenlenmisUser.Email = user.Email;
        duzenlenmisUser.Username = user.Username;
        duzenlenmisUser.Password = user.Password;
        return View(duzenlenmisUser);
    }

    public IActionResult Sil(int id)
    {
        Data? Sil = Users.FirstOrDefault(tum => tum.Id == id);
        Users.Remove(Sil);
        return RedirectToAction("Listele");
    }


}
