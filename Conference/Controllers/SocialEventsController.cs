using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class SocialEventsController : Controller
    {
        // GET: SocialEvents
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SocialEvents()
        {
            return View();
        }
    }
}