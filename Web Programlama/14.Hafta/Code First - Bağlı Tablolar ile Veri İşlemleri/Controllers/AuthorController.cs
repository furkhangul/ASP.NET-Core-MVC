using Code_First.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Code_First.Controllers
{
    public class AuthorController : Controller
    {
        DataDbContext _db;
        public AuthorController(DataDbContext db)
        {
            _db = db;
        }
        public IActionResult List()
        {
            
            var liste = _db.Authors.ToList();
            return View(liste);
        }
    }
}
