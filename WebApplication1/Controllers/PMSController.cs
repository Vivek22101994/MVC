using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PMSController : Controller
    {
        // GET: PMS
        public ActionResult Index()
        {
            ViewBag.test = "Abc";
            ViewBag.Adding = "fff";
            return View();
        }


    }
}