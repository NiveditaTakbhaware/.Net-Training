using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCpcForm.Models
{
    public class PcModel
    {
        public int id { get; set; }
        public bd brandname { get; set; }
        public string category { get; set; }
        public string screensize { get; set; }
        public string memory { get; set; }
        public OS os { get; set; }
        public string color { get; set; }
        public HttpPostedFileBase img { get; set; }
        public string name { get; set; }
    }
    public enum bd
    {
        hp, samsung, DELL, sony, LG
    }
    public enum OS
    {
        windows, linux, dos
    }
}
