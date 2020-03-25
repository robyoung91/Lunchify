using Lunchify.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lunchify.Web.Controllers
{
    public class HomeController : Controller
    {
        IAppData db;

        public HomeController(IAppData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            var model = db.GetAllUsers();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}