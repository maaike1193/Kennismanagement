using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorQitService.Models
{
    public class Employer
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int employeeCount { get; set; }
        public string location { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}