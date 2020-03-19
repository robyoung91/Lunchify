using Lunchify.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lunchify.Web.Controllers
{
    public class UsersController : Controller
    {
        IAppData db;

        public UsersController(IAppData db)
        {
            this.db = db;
        }
        // GET: Users
        public ActionResult Index()
        {
            var model = db.GetAllUsers();
            return View(model);
        }
    }
}