using Microsoft.AspNetCore.Mvc;
using WebApplication1.DbContext;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class DepartmanController : Controller
    {
        FurOfTheWeakContext _db;
        public DepartmanController(FurOfTheWeakContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ekle()
        {
            Departman DEP = new Departman()
            {
                DeptName = "Yeni Departman",
                DeptCapasity = 50

            };
            _db.Departmen.Add(DEP);
            _db.SaveChanges();
            return View();
        }
        public IActionResult Sil()
        {
            Departman? dep = _db.Departmen.FirstOrDefault(a => a.DeptId == 2);
            _db.Departmen.Remove(dep);
            _db.SaveChanges();
            return View();
        }

        public IActionResult Duzenle()
        {
            Departman? dept = _db.Departmen.FirstOrDefault(a => a.DeptId == 3);
            dept.DeptName = "Guncellenmis Departman";
            _db.Departmen.Update(dept);
            _db.SaveChanges();
            return View();
        }

    }
}
