using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using G.Models;

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
            List<ShopInfo> shopInfo = new List<ShopInfo> {
                new ShopInfo("~/Images/Shop/Dice.jpg", "Dice","Why use boring white dice? Add color to make any game "
                                + "with dice more intersting.", "$15.00", 1),
                new ShopInfo("~/Images/Shop/Mario.jpg", "Mario", "Mario is a collectors item. There were only 20 created "
                                + "and we only have 10 left.", "$5.08", 10),
                new ShopInfo("~/Images/Shop/APenguin.jpg","Penguin", "Penguins are the perfect gift for any kid. "
                                + "Check out the adorable penguin", "$1.99", 50)
            };

            //List<ShopInfo> shopInfo = new ShopInfo();
            //shopInfo.Add

            ViewBag.ShopInfo = shopInfo;
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