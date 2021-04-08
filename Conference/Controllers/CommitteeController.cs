using Conference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class CommitteeController : Controller
    {
        // GET: Committees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Committee()
        {
            // COMMITTEE

            Committee cm01 = new Committee();
            cm01.CommitteeId = 01;
            cm01.FirstName = "Olga";
            cm01.LastName = "Strizhko";
            cm01.Function = "General Chair";
            cm01.Info = "";
            cm01.Country = "";

            Committee cm02 = new Committee();
            cm02.CommitteeId = 02;
            cm02.FirstName = "Olga";
            cm02.LastName = "Tikhonova";
            cm02.Function = "General Co-Chair";
            cm02.Info = "";
            cm02.Country = "";

            Committee cm03 = new Committee();
            cm03.CommitteeId = 03;
            cm03.FirstName = "Michael";
            cm03.LastName = "Sommer";
            cm03.Function = "Program Committee Chair";
            cm03.Info = "";
            cm03.Country = "";

            Committee cm04 = new Committee();
            cm04.CommitteeId = 04;
            cm04.FirstName = "Shalini";
            cm04.LastName = "Gupta";
            cm04.Function = "Program Committee Co-Chair";
            cm04.Info = "";
            cm04.Country = "";

            Committee cm05 = new Committee();
            cm05.CommitteeId = 05;
            cm05.FirstName = "Samaneh";
            cm05.LastName = "Nazari Dastjerdi";
            cm05.Function = "Publication Chair";
            cm05.Info = "";
            cm05.Country = "";

            Committee cm06 = new Committee();
            cm06.CommitteeId = 06;
            cm06.FirstName = "Mohammed";
            cm06.LastName = "Marzonk Hassana Sayed";
            cm06.Function = "Publication Co-Chair";
            cm06.Info = "";
            cm06.Country = "";

            Committee cm07 = new Committee();
            cm07.CommitteeId = 07;
            cm07.FirstName = "Ila";
            cm07.LastName = "Gupta";
            cm07.Function = "Publicity Chair";
            cm07.Info = "";
            cm07.Country = "";

            Committee cm08 = new Committee();
            cm08.CommitteeId = 08;
            cm08.FirstName = "Samar";
            cm08.LastName = "Shahabi Ghahfarokhi";
            cm08.Function = "Publicity Co-Chair";
            cm08.Info = "";
            cm08.Country = "";

            Committee cm09 = new Committee();
            cm09.CommitteeId = 09;
            cm09.FirstName = "Ali";
            cm09.LastName = "Karaki";
            cm09.Function = "Local Arrangement Chair";
            cm09.Info = "";
            cm09.Country = "";

            Committee cm10 = new Committee();
            cm10.CommitteeId = 10;
            cm10.FirstName = "Syed";
            cm10.LastName = "Mohammed Ali Azher";
            cm10.Function = "Local Arrangement Co-Chair";
            cm10.Info = "";
            cm10.Country = "";

            Committee cm11 = new Committee();
            cm11.CommitteeId = 11;
            cm11.FirstName = "Aliia";
            cm11.LastName = "Zaliareva";
            cm11.Function = "Finance Chair";
            cm11.Info = "";
            cm11.Country = "";

            Committee cm12 = new Committee();
            cm12.CommitteeId = 12;
            cm12.FirstName = "Alisa";
            cm12.LastName = "Makhmutova";
            cm12.Function = "Finance Co-Chair";
            cm12.Info = "";
            cm12.Country = "";

            List<Committee> committee = new List<Committee>();
            committee.Add(cm01);
            committee.Add(cm02);
            committee.Add(cm03);
            committee.Add(cm04);
            committee.Add(cm05);
            committee.Add(cm06);
            committee.Add(cm07);
            committee.Add(cm08);
            committee.Add(cm09);
            committee.Add(cm10);
            committee.Add(cm11);
            committee.Add(cm12);

            return View(committee);
        }
    }
}