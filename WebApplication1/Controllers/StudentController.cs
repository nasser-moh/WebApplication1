using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetStudentName()
        {
            Student student1 = new Student();
            
            student1.Id = 1117004;
            student1.studentName = "Muhammad Nasser";
            return View(student1);
        }
    }
}
