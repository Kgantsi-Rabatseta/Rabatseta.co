using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rabatseta.co.Controllers.Files
{
    public class ClientFilesController : Controller
    {
        // GET: ClientFiles
        public ActionResult DownloadsHome()
        {
            ViewBag.Title = "Downloads";
            return View();
        }
    }
}