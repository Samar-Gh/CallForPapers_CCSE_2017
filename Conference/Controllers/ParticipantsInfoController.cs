using Conference.Models;
using Demo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class ParticipantsInfoController : Controller
    {
        // GET: ParticipantsInfo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ParticipantsInfo()
        {
            XMLReader readXML = new XMLReader();
            var data = readXML.ReturnListOfUsers();
            if (data == null)
            {
                return View();
            }
            else
            {
                return View(data.ToList());
            }
        }
    }
}