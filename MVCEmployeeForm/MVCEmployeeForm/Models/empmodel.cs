using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCEmployeeForm.Models
{
    public class empmodel
    {
        public int empid { get; set; }
        [Required(ErrorMessage = "name required")]
        [DisplayName("full name")]
        [StringLength(40, MinimumLength = 10)]
        public string name { get; set; }
        [Required(ErrorMessage = "select city")]
        [DisplayName("city")]
        public City city { get; set; }
        [Required(ErrorMessage = "enter profession")]
        [DisplayName("profession")]

        public string profession { get; set; }
       
        [Required(ErrorMessage ="select knowledge")]
        [DisplayName("knowledge")]
        public List<string> knowledge { get; set; }
        [Required(ErrorMessage = "enter experience")]
        [DisplayName("experience")]
        public int exprience { get; set; }
        [Required(ErrorMessage = "select department")]
        [DisplayName("department")]
        public string department { get; set; }
        [Required(ErrorMessage = "enter date")]
        [DisplayName("hired date")]
        [DataType(DataType.Date)]
        public string hiredDate { get; set; }
        [Required(ErrorMessage = "enter email id")]
        [DisplayName("email id")]
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage = "please enter password")]
        [DisplayName("password")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",ErrorMessage = "password must contains one uppercase,lowercase,number and special character")]
        public string password { get; set; }
        [Required(ErrorMessage ="please confirm your password ")]
        [DisplayName("confirm password")]
        [Compare("password",ErrorMessage ="password does not match")]
        public string confirm_password {get;set;}
    }
    public enum City
    {
        Nagpur,Pune,Mumbai,Kolhapur,Nashik,Akola
    }

  
}