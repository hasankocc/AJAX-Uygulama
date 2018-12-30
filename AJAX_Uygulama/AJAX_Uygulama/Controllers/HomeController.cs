using AJAX_Uygulama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAX_Uygulama.Controllers
{
    public class HomeController : Controller
    {
        studentGradeEntities db = new studentGradeEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult All() 
        {
            List<Student> model = db.Students.ToList();
            return PartialView("_Student",model);
        }

        public PartialViewResult Top3()
        {
            List<Student> model = db.Students.OrderByDescending(x => x.grade).Take(3).ToList();
            return PartialView("_Student" , model);
        }

        public PartialViewResult Bottom3()
        {
            List<Student> model = db.Students.OrderBy(x => x.grade).Take(3).ToList();
            return PartialView("_Student", model);
        }

    }
}
