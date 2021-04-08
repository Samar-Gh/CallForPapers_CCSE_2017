using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public string Info { get; set; }
        public DateTime ScheduleDate { get; set; }
    }
}