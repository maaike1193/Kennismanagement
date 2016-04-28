using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorQitService.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string industry { get; set; }
        public string specialties { get; set; }
        public string positions { get; set; }
        public string interests { get; set; }
        public string languages { get; set; }
        public string skills { get; set; }
        public string educations { get; set; }
        public string volunteer { get; set; }
        public DateTime dpb { get; set; }
        public string location { get; set; }
        public int hours { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}