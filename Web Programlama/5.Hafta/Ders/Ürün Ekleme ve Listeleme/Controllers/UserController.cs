using Hafta6.Controllers;
using Microsoft.AspNetCore.Mvc;
using Hafta6.Models;
using System.Security.Cryptography.X509Certificates;
public class User : Controller
{
    public static List<Data> Users = new List<Data>()
    {
        new Data("gl56frkn@gmail.com", "furkhangul", "thelord01"),
        new Data("lolollol5656@gmail.com", "lolasle", "loalses5564"),
        new Data("kerimaslan@hotmail.com", "kerimaslans", "kerimaskan5623"),
        new Data("saffetdogan@gmail.com", "saffetcandogan", "fb1907."),
        new Data("firdevsyesily@gmail.com","firdevs_yesilyurt","6545firdevs")
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

}
