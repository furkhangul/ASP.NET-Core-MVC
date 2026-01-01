using FurOfTheWeak.DbContext;
using FurOfTheWeak.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurOfTheWeak.Controllers
{
    public class UserController : Controller
    {
        ProjectContext _db;

        public UserController(ProjectContext db)
        {
            _db = db;
        }
        public IActionResult Add()
        {
            UserDatum user = new UserDatum();
            return View(user);
        }
        [HttpPost]
        public IActionResult Add(UserDatum user)
        {
            _db.UserData.Add(user);
            _db.SaveChanges();
            return RedirectToAction("List", "Home");
        }

        public IActionResult Delete(int id)
        {
            var del = _db.UserData.FirstOrDefault(a => a.Id == id);
            _db.UserData.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("List", "Home");
        }
        public IActionResult Edit(int id)
        {
            UserDatum? edituser = _db.UserData.FirstOrDefault(a => a.Id == id);
            return View(edituser);
        }
        [HttpPost]
        public IActionResult Edit(UserDatum user)
        {
            UserDatum? edituser = _db.UserData.FirstOrDefault(a => a.Id == user.Id);
            edituser.Username = user.Username;
            edituser.Email = user.Email;
            edituser.Pass = user.Pass;
            _db.UserData.Update(edituser);
            _db.SaveChanges();
            return RedirectToAction("List","Home");
        }

    }
}
