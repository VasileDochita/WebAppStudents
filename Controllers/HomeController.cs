using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppStudents;
using WebAppStudents.Models;

namespace WebAppStudents.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentsData studentsData;

        public HomeController()
        {
            this.studentsData = new StudentsData();
        }

        public ActionResult Index()
        {
            var students = this.studentsData.GetStudents();

            return this.View(students);

        }

        public ActionResult ById(int id)
        {
            var student = this.studentsData.GetStudents(id);

            return this.View(student);
        }
    }
}