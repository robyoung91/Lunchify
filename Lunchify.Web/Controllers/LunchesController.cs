using Lunchify.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lunchify.Web.Controllers
{
    public class LunchesController : Controller
    {
        IAppData db;

        public LunchesController(IAppData db)
        {
            this.db = db;
        }
        // GET: Lunches
        public ActionResult Index()
        {
            var model = db.GetAllLunches();
            return View(model);
        }
    }
}