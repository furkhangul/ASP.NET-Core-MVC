using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    public class User : Controller
    {
        private static List<Users> UserList = new List<Users>()
        {
            new Users(1,"furkan@gmail.com","furoftheweak","furkanbaba005456"),
            new Users(2,"leyla@gmail.com","leylasirdas","lelyladolk"),
            new Users(3,"keramusnd@gmial.com","keramasiks","643546fdkj"),
            new Users(4,"anka7375@hotmail.com","adnan7375","hkbfd543dsfbhk")
        };
        public IActionResult List()
        {
            return View(UserList);
        }
        public IActionResult SignUp()
        {
            Users bos = new Users();
            return View(bos);
        }
        [HttpPost]
        public IActionResult SignUp(Users user)
        {
            UserList.Add(user);
            return View(user);
        }
        public IActionResult Design(int id)
        {
            Users? willbedesign = UserList.FirstOrDefault(all => all.Id == id);
            return View(willbedesign);
        }
        [HttpPost]
        public IActionResult Design(Users user)
        {
            Users? designed = UserList.FirstOrDefault(all => all.Id == user.Id);
            designed.Email = user.Email;
            designed.Username = user.Username;
            designed.Password = user.Password;
            return View(designed);
        }
        public IActionResult Delete(int id)
        {
            Users? Del = UserList.FirstOrDefault(all => all.Id == id);
            UserList.Remove(Del);
            return RedirectToAction("List");
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(Users user)
        {

            Users? login = UserList.FirstOrDefault(all => all.Username == user.Username);
            if (login.Password == user.Password)
            {
                return RedirectToAction("List");
            }
            else
            {
                return View(user);
            }
        }
    }
}
