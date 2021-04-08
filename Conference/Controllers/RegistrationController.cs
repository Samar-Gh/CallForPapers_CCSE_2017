using Conference.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Reflection;
using System.Web.Hosting;
using Demo.Helper;

namespace Conference.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        //public ActionResult Registration(FormCollection collection)
        public ActionResult Registration(Users model)
        {
            string duplicate = "The email adress is already registered!";
            string success = "Registration complete.";
            XMLReader readXML = new XMLReader();
            var data = readXML.ReturnListOfUsers();
            int exists = 1;
            if (data == null)
            {
                exists = 0;
            }
            else
            {
                int count = data.Count;
                for (int i = 0; i < count; i++)
                {
                    if (data[i].Email == model.Email)
                    {
                        exists = 1;
                        break;
                    }
                    else
                    {
                        exists = 0;
                    }
                }
            }
            if (exists == 1)
            {
                ViewBag.result = duplicate;
            }
            else
            {
                ViewBag.result = success;
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("FirstName", model.FirstName);
                dict.Add("LastName", model.LastName);
                dict.Add("Institution", model.Institution);
                dict.Add("Country", model.Country);
                dict.Add("SocialEvents", model.SocialEvents);
                dict.Add("Email", model.Email);
                SaveData(dict);
            }
            return View();
        }

       
        public void SaveData(Dictionary<string, string> dict)
        {
            XMLReader readXML = new XMLReader();
            readXML.InsertData(dict);
        }
    }
}