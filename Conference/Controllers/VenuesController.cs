using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class VenuesController : Controller
    {
        // GET: Venues
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Venues()
        {
            return View();
        }
    }
}