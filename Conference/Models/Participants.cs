using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web;

namespace Conference.Models
{
    public class Participants
    {
        public int Nr { get; set; }

        public int SocialEvents { get; set; }
    }
}