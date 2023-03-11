using Microsoft.AspNetCore.Mvc;

namespace HoangAnhHuyBTH.Controllers;

    public class StudentController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
        //viet code cac action
        [HttpPost]
        public IActionResult Index(string Fullname)
        {
            string strReturn = "Hello, " + Fullname;
            //gui du lieu ve view
            ViewBag.abc = strReturn;
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }