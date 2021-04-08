using Conference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class CallsController : Controller
    {
        // GET: Conference
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calls()
        {
            // Calls

            //Calls c01 = new Calls();
            //c01.CallsId = 01;
            //c01.TopicName = "Computer Science";

            Calls c02 = new Calls();
            c02.CallsId = 02;
            c02.TopicName = "Network engineering";

            Calls c03 = new Calls();
            c03.CallsId = 03;
            c03.TopicName = "Embedded system";

            Calls c04 = new Calls();
            c04.CallsId = 04;
            c04.TopicName = "Security engineering";

            Calls c05 = new Calls();
            c05.CallsId = 05;
            c05.TopicName = "Automated systems";

            Calls c06 = new Calls();
            c06.CallsId = 06;
            c06.TopicName = "System engineering";

            Calls c07 = new Calls();
            c07.CallsId = 07;
            c07.TopicName = "Software engineering";

            Calls c08 = new Calls();
            c08.CallsId = 08;
            c08.TopicName = "Control engineering";

            Calls c09 = new Calls();
            c09.CallsId = 09;
            c09.TopicName = "Automated intelligence systems";

            Calls c10 = new Calls();
            c10.CallsId = 10;
            c10.TopicName = "Virtual / augmented reality";

            Calls c11 = new Calls();
            c11.CallsId = 11;
            c11.TopicName = "Computer vision";

            List<Calls> lc = new List<Calls>();
            //lc.Add(c01);
            lc.Add(c02);
            lc.Add(c03);
            lc.Add(c04);
            lc.Add(c05);
            lc.Add(c06);
            lc.Add(c07);
            lc.Add(c08);
            lc.Add(c09);
            lc.Add(c10);
            lc.Add(c11);

            return View(lc);
        }
    }
}