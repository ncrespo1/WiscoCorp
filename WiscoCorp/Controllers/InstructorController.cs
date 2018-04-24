using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WiscoCorp.Controllers
{
    public class InstructorController : Controller
    {
        // GET: Instructor
        public ActionResult Account()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }
    }
}