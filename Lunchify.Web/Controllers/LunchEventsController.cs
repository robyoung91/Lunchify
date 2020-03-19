using Lunchify.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lunchify.Web.Controllers
{
    public class LunchEventsController : Controller
    {
        IAppData db;

        public LunchEventsController(IAppData db)
        {
            this.db = db;
        }
        // GET: LunchEvents
        public ActionResult Index()
        {
            var model = db.GetAllLunchEvents();
            return View(model);
        }
    }
}