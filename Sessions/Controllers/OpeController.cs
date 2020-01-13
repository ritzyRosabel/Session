using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sessions.Controllers
{
    public class OpeController : Controller
    {
        // GET: Ope
        public ActionResult Index()
        {
            var con = Session["ope"] as string;
            //ViewBag["ans"] = con;
            return View();
        }
    }
}