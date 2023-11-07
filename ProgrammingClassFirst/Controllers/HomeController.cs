using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using NuGet.Packaging;
using ProgrammingClassFirst.Models;
using System.Diagnostics;

namespace ProgrammingClassFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //کد ارسالی از درگاه پرداخت
            //int code = 150;

            //string message;

            //if (age > 20 && age <= 30 && age != 0)
            //{
            //    message = "age is between 20 and 30";
            //}
            //else if (age > 30 && age <= 40)
            //{
            //    message = "age is between 30 and 40";
            //}
            //else if (age != 50)
            //{
            //    message = "age is not in 50";
            //}
            //else
            //{
            //    message = "age is not in the range";
            //}

            //switch (code)
            //{
            //    case 10:
            //        message = "تراکنش توسط کاربر لغو گردید";
            //        break;
            //    case 11:
            //        message = "کارت منقضی است";
            //        break;
            //    case 12:
            //        message = "موجودی ناکافی است";
            //        break;

            //    case 13:
            //        message = "مبلغ نا معتبر است";
            //        break;

            //    default:
            //        message = "تراکنش موفقیت آمیز بود";
            //        break;
            //}

            int a = 10;
            int b = 20;
            int c = 30;
            int d = 40;

            int f = SumNumbers(a,b,c,d);

            ViewBag.message = SomeText(a,b);
            return View();
        }

        public int SumNumbers(int ali, int mohammd,int reza,int karim)
        {
            return reza+ali+mohammd+karim;
        }

        public string SomeText(int i, int m)
        {
            return i + "کمتر از" + m +"است";
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
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
}