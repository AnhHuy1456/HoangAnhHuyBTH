using Microsoft.AspNetCore.Mvc;

namespace BaiThucHanh0703.Controllers;

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
            string strReturn = "Xin chào, " + Fullname;
            //gui du lieu ve view
            ViewBag.huy = strReturn;
            return View();
        }

        public IActionResult GiaiPT()
            {
                return View();
            }
        //viet code cac action
        [HttpPost]
        public IActionResult GiaiPT(string hesoA, string hesoB, string hesoC)
        {
            //khai bao bien
            double delta, x1, x2, a = 0, b = 0, c = 0;
            string ketqua;
            // giai phuong trinh bac 2
            if(!String.IsNullOrEmpty(hesoA) ) a = Convert.ToDouble(hesoA);
            if(!String.IsNullOrEmpty(hesoB) ) b = Convert.ToDouble(hesoB);
            if(!String.IsNullOrEmpty(hesoC) ) c = Convert.ToDouble(hesoC);

            if(a == 0 ) ketqua = "Không phải pt bậc 2";
            else
            {
                //Tính delta
                delta = Math.Pow(b,2) -4 * a * c;
                //Giải PT
                if(delta < 0 ) ketqua = "Phương trình vô nghiệm";
                else if (delta == 0){
                    x1 = (-b)/(2*a); 
                    ketqua = "Phương trình có nghiệm kép = " +x1; 
                }
                else{
                    x1 = (-b + Math.Sqrt(delta))/(2*a);
                    x2 = (-b - Math.Sqrt(delta))/(2*a);
                    ketqua = "Phương trình có 2 nghiệm phân biệt x1 = " + x1  + ", và x2 = " + x2; 

                } 
            }

            ViewBag.message = ketqua;
            return View();
        }

        
        public IActionResult About()
        {
            return View();
        }
    }