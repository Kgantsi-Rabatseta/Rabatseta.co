using System.Linq;
using System.Web.Mvc;
using Builders.ObjectBuilders;
using Rabatseta.co.Models;

namespace Rabatseta.co.Controllers.Home
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
           
            ViewBag.Title = "Home";
            return View();
        }



        public ActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }

    }
}