using Microsoft.AspNetCore.Mvc;

namespace HoangAnhHuyBTH.Controllers;

    public class StudentController : Controller
    
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }