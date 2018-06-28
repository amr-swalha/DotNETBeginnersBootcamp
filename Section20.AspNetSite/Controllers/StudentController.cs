using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Section20.AspNetSite.Models;

namespace Section20.AspNetSite.Controllers
{
    [Route("StudentData")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("AllClasses")]
        public IActionResult Class()
        {
            List<ClassData> classes = new List<ClassData>
            {
                new ClassData
                {
                    ClassName = "CS 101",
                    StartDate = DateTime.Now.AddDays(60),
                    StudentEnrolled = new List<string>
                    {
                        "Joe",
                        "David"
                    }
                },
                new ClassData
                {
                    ClassName = "Math 101",
                    StartDate = DateTime.Now.AddDays(60),
                    StudentEnrolled = new List<string>
                    {
                        "Joe",
                        "David"
                    }
                }

            };

            return View(classes);
        }
       
        public IActionResult Test()
        {
            return Content("Hello World!");
        }     
    }
}