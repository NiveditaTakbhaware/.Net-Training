using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCstudentRegistration.Models
{
    public class stregistration
    {
        public int Id { get; set; }
        public string fisrtname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string course { get; set; }
        public string stream { get; set; }
        public string password { get; set; }
        public string photo { get; set; }
    }
}