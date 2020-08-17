using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace MVCstudentRegistration.Models
{
    public class stregistration
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "first name required")]
        [DisplayName("first name")]
        [StringLength(20,MinimumLength =2)]
        public string fisrtname { get; set; }
        [Required(ErrorMessage ="middle name required")]
        [DisplayName("middle name")]
        [StringLength(20,MinimumLength =2)]
        public string middlename { get; set; }
        [Required(ErrorMessage ="last name required")]
        [DisplayName("last name")]
        [StringLength(30,MinimumLength =2)]
        public string lastname { get; set; }
        [Required(ErrorMessage ="email required")]
        [DisplayName("email")]
        //[RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",ErrorMessage ="email id is incorrect")]
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage ="mobile number is required")]
        [DisplayName("mobile number")]
        [StringLength(10,ErrorMessage ="number must be of 10 digit",MinimumLength =10)]
        public string mobile { get; set; }
        [Required(ErrorMessage ="select gender")]
        [DisplayName("gender")]
        public string gender { get; set; }
        [Required(ErrorMessage ="enter address")]
        [DisplayName("address")]
        public string address { get; set; }
        [Required(ErrorMessage ="select course")]
        [DisplayName("course")]
        public string course { get; set; }
        //public List<string> course { get; set; }
        [Required(ErrorMessage ="select stream")]
        [DisplayName("stream")]
        public string stream { get; set; }
       /* public bool java { get; set; }
        public bool dotnet { get; set; }
        public bool python{ get; set; }*/
        [Required(ErrorMessage ="enter password")]
        [DisplayName("password")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",ErrorMessage ="password must contains one uppercase,lowercase,number and special character")]
        public string password { get; set; }
       // public string Course { get; set; }
       public string imagename { get; set; }
       public HttpPostedFileBase img { get;set; }
    }
 

}