using FurOfTheWeak.DbContext;
using FurOfTheWeak.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurOfTheWeak.Controllers
{
    public class PostController : Controller
    {
        ProjectContext _db;

        public PostController(ProjectContext db)
        {
            _db = db;
        }
        public IActionResult Add()
        {
            PostDatum post = new PostDatum();
            return View(post);
        }
        [HttpPost]
        public IActionResult Add(PostDatum post)
        {
            _db.PostData.Add(post);
            _db.SaveChanges();
            return RedirectToAction("PostList", "Home");
        }

        public IActionResult Delete(int id)
        {
            var del = _db.PostData.FirstOrDefault(a => a.Id == id);
            _db.PostData.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("PostList", "Home");
        }

        public IActionResult Edit(int id)
        {
            PostDatum? editpost = _db.PostData.FirstOrDefault(a => a.Id == id);
            return View(editpost);
        }
        [HttpPost]
        public IActionResult Edit(PostDatum post)
        {
            PostDatum? editpost = _db.PostData.FirstOrDefault(a => a.PostId == post.PostId);
            editpost.PostDate = post.PostDate;
            editpost.Id = post.Id;
            _db.PostData.Update(editpost);
            _db.SaveChanges();
            return RedirectToAction("PostList","Home");
        }

    }
}
