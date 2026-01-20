using FurOfTheWeak.DbContext;
using FurOfTheWeak.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurOfTheWeak.Controllers
{
    public class UserController : Controller
    {
        UserDatum _db;
        public UserController(UserDatum db)
        {
            _db = db;
        }
        public IActionResult List()
        {
            var liste = _db.User.ToList();
            return View(liste);
        }
        public IActionResult Add()
        {
            Data user = new Data();
            return View(user);
        }
        [HttpPost]
        public IActionResult Add(Data u)
        {

            _db.User.Add(u);
            _db.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Manage()
        {
            var list = _db.User.ToList();
            return View(list);
        }
        public IActionResult Delete(int id)
        {
            Data? delete = _db.User.FirstOrDefault(x => x.Id == id);
            _db.User.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Manage");
        }
        public IActionResult Edit(int id)
        {
            Data? user = _db.User.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(Data user)
        {
            Data? edit = _db.User.Find(user.Id);
            edit.Username = user.Username;
            edit.Name = user.Name;
            edit.Surname = user.Surname;
            edit.Birthday = user.Birthday;
            edit.Email = user.Email;
            edit.Password = user.Password;

            _db.User.Update(edit);
            _db.SaveChanges();
            return RedirectToAction("Manage");
        }
    }
}
