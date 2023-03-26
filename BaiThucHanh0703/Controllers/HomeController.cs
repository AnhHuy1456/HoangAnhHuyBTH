using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;
using BaiThucHanh0703.Models.Process;

namespace BaiThucHanh0703.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    GiaiPhuongTrinhBac1 GPT = new GiaiPhuongTrinhBac1();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GiaiPTB1()
    {
        return View();
    }

    [HttpPost]

     public IActionResult GiaiPTB1(string hesoA, string hesoB)
    {
        double a = 0, b = 0;
        string ketqua = GPT.GPTB1(a,b);
        if(!string.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
        if(!string.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
        if(a == 0){
            ketqua = "Khong phai phuong trinh bac nhat";
        }
        else{
            ketqua = GPT.GPTB1(a,b) ;
        }
        ViewBag.Thongbao = ketqua;

        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
