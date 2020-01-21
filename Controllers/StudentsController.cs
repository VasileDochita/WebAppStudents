namespace WebAppStudents.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Models;

    public class StudentsController : Controller
    {
        private readonly StudentsData userData;

        public StudentsController()
        {
            this.userData = new StudentsData();
        }

        //users/index
        public ActionResult Index()
        {
            List<Students> users = this.userData.GetStudents();

            return this.View(users);
        }

        public ActionResult ById(int id)
        {
            var u = this.userData.GetStudents(id);

            return this.View(u);
        }
    }
}
