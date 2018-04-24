using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WiscoCorp.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Courses()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}