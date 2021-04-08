using Conference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class ScheduleController : Controller
    {
        // GET: Schedule
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Schedule()
        {
            // SCHEDULE

            Schedule s01 = new Schedule();
            s01.ScheduleId = 01;
            s01.Info = "Paper submission until:";
            s01.ScheduleDate = new DateTime(2016, 12, 18);

            Schedule s02 = new Schedule();
            s02.ScheduleId = 01;
            s02.Info = "Paper review process until:";
            s02.ScheduleDate = new DateTime(2017, 1, 9);

            Schedule s03 = new Schedule();
            s03.ScheduleId = 01;
            s03.Info = "Registration deadline:";
            s03.ScheduleDate = new DateTime(2017, 1, 15);

            Schedule s04 = new Schedule();
            s04.ScheduleId = 01;
            s04.Info = "Author feedback until:";
            s04.ScheduleDate = new DateTime(2017, 1, 16);

            Schedule s05 = new Schedule();
            s05.ScheduleId = 01;
            s05.Info = "Camera-ready submission until:";
            s05.ScheduleDate = new DateTime(2017, 1, 23);

            Schedule s06 = new Schedule();
            s06.ScheduleId = 01;
            s06.Info = "Conference date:";
            s06.ScheduleDate = new DateTime(2017, 1, 30);

            List<Schedule> sc = new List<Schedule>();
            sc.Add(s01);
            sc.Add(s02);
            sc.Add(s03);
            sc.Add(s04);
            sc.Add(s05);
            sc.Add(s06);

            return View(sc);
        }
    }
}