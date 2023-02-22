using Microsoft.AspNetCore.Mvc;

namespace AnhHuy2001.Controllers;

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