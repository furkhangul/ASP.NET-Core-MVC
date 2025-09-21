using Microsoft.AspNetCore.Mvc;
using Basic.Models;
namespace Basic.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Tarih: {DateTime.Now.ToString()} ";
            return View("Index1", message);
        }

        public ViewResult Index2()
        {
            string[] names = new string[]
            {
                "Furkan",
                "Ahmet",
                "Can",
                "Kerem",
                "Salih"
            };
                
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1, FirstName="Furkan", LastName="Gül", Age=24},
                new Employee(){Id=2, FirstName="Ahmet", LastName="Yılmaz", Age=30},
                new Employee(){Id=3, FirstName="Can", LastName="Demir", Age=28},
                new Employee(){Id=4, FirstName="Kerem", LastName="Şahin", Age=35},
                new Employee(){Id=5, FirstName="Salih", LastName="Çelik", Age=40}
            };
            return View("Index3", list);
        }
    }

}
