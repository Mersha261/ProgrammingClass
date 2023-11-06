using Microsoft.AspNetCore.Mvc;
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
            int age = 10;

            string name = "Ali";

            bool isAliSingle = false;

            DateTime dt = DateTime.Now;

            var aliInfo = "نام:" + name + "سن:" + age + "وضعیت تاهل:" + isAliSingle + "تاریخ تولد:" + dt;

            char theFirstAlphabetLetter = 'a';

            int a = 1, b = 2, c = 3;

            const string successAlert = "عضویت شما با موفیقت انجام گرفت";


            //لیست نمرات دانش آموزان کلاس برنامه نویسی 
            int[] score = { 17, 18, 19, 16, 17, 18, 15, 13, 20, 19 };

            //لیست اسامی دانش آموزان کلاس برنامه نویسی 
            string[] studentsName = { "ali", "mohmmad", "reza", "mahtab", "yasi", "fateme", "amir", "iman", "yekta", "farnaz" };

            string studentsScore = "";

            for (int i = 0; i <= 9; i++)
            {
                studentsScore = studentsScore + ", نام دانش آموز " + studentsName[i] + "نمره دانش آموز: " + score[i];
            }

            foreach (var item in studentsName)
            {
                studentsScore = studentsScore + item;
            }
            foreach (var item in score)
            {
                studentsScore = studentsScore + "," + item;
            }


            int j = 0;
            while (j < 10)
            {
                studentsScore = studentsScore + ", نام دانش آموز " + studentsName[j] + "نمره دانش آموز: " + score[j];
                j++;
            }
            //جلسه امروز 
            //if, else, switch case
            //method

            if (age == 20)
            {
                studentsScore = "age= 20";
            }
            else
            {
                studentsScore = "age is not 20";
            }

            ViewBag.student = studentsScore;




            return View();
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