
using System.Web.Mvc;

namespace Sessions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["ope"] = " My name is Opemipo Olugbenga. I am a back-end developer.";
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