
using System.Web.Mvc;

namespace Sessions.Controllers
{
    public class OpeController : Controller
    {
        // GET: Ope
        public ActionResult Index()
        {
            var con = Session["ope"] as string;
         
            return View();
        }
    }
}