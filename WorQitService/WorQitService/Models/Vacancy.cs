using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorQitService.Models
{
    public class Vacancy
    {
        public int ID { get; set; }
        public int employerID { get; set; }
        public string function { get; set; }
        public string description { get; set; }
        public int salary { get; set; }
        public int hours { get; set; }
        public string requirements { get; set; }
        public string tags { get; set; }
    }
}