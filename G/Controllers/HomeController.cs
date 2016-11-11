using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace G.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Shop()
        {
            ViewBag.Title = "Pictures";
            ViewBag.Message = "Look at your first pictures";
            ViewBag.Images = Directory.EnumerateFiles(Server.MapPath("~/Images/Shop")).Select(fn => "~/Images/Shop/" + Path.GetFileName(fn));
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