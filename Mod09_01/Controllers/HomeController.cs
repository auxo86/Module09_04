using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod09_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Index2
        public ActionResult Index2()
        {
            return View();
        }

        // GET: Home/SelectorDemo
        public ActionResult SelectorDemo()
        {
            return View();
        }

        // GET: Home/HoverDemo
        public ActionResult HoverDemo()
        {
            return View();
        }


    }
}