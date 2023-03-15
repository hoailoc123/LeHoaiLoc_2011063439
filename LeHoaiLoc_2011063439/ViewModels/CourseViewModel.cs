using LeHoaiLoc_2011063439.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeHoaiLoc_2011063439.ViewModels
{
    public class CourseViewModel
    {
        public string Place{ get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime() 
        { 
            return DateTime.Parse(String.Format("{0} {1}", Date, Time)); 
        }
    }
}