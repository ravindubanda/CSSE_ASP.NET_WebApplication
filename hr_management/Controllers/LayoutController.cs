using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hr_management.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        public ActionResult HRdivision()
        {
            return View("HRdivision", "_Layout2");
        }
        public ActionResult Index()
        {
            return View("Index","_Layout2");
        }
    }
}