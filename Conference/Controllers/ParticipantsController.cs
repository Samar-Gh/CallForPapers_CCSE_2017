using Conference.Models;
using Demo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class ParticipantsController : Controller
    {
        // GET: Participants
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Participants()
        {
            XMLReader readXML = new XMLReader();
            var data = readXML.ReturnListOfUsers();
            if (data == null)
            {
                return View();
            }
            else
            {
                Participants p = new Participants();
                int c = data.Count;
                int se = 0;
                for (int i = 0; i < c; i++)
                {
                    if (data[i].SocialEvents == "Yes")
                    {
                        se = se + 1;
                    }
                }
                p.Nr = c;
                p.SocialEvents = se;
                List<Participants> part = new List<Participants>();
                part.Add(p);
                return View(part);
            }
        }
    }
}