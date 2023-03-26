using Microsoft.AspNetCore.Mvc;
using HoangAnhHuyBTH.Models;

namespace HoangAnhHuyBTH.Controllers;

    public class StudentController : Controller
        {
            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Create(Student std)
            {
                string kq = std.StudentCode + "-" + std.Fullname + "-" + std.Address;
                ViewBag.abc = kq;
                return View();
            }
        //     public IActionResult Index()
        //     {
        //         return View();
        //     }
        // //viet code cac action
        // [HttpPost]
        // public IActionResult Index(string Fullname, string PhoneNumber)
        // {
        //     string strReturn = "Hello, " + Fullname +"-" + PhoneNumber;
        //     //gui du lieu ve view
        //     ViewBag.abc = strReturn;
        //     return View();
        // }
        // public IActionResult About()
        // {
        //     return View();
        // }
    }