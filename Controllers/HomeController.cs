using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Martin_MIS4200_940.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A Little Bit About Lauren Martin";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Email: Lm739314@ohio.edu";

            return View();
        }
    }
}