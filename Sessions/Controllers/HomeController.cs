
using System.Web.Mvc;

namespace Sessions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["ope"] = "i am here";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}