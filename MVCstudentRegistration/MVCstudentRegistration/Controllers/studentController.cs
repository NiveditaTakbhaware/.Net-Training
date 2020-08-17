using MVCstudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Internal;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;

namespace MVCstudentRegistration.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        //display all list
        static string cnstrng = ConfigurationManager.ConnectionStrings["mvcConstring"].ConnectionString;
        SqlConnection con = new SqlConnection(cnstrng);
        public ActionResult Index()
        {
            ViewBag.msg = "students list";
            DBhandler d = new DBhandler();
            //ModelState.Clear();
            return View(d.stdlist());
        }

        //insert

        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(stregistration rg)
        {
           
            
            //string msg = string.Empty;
            if (ModelState.IsValid)
                {
                
                    DBhandler d = new DBhandler();
                    string b =d.insert(rg);
                    if(b== "inserted")
                    {

                    ViewBag.msg = "registration done!";
                        ModelState.Clear();
                    }
                }
          
            return View();
        }

        //update

        [HttpGet]
        public ActionResult edit(int id)
        {
            DBhandler d = new DBhandler();
            return View(d.stdlist().Find(stmodel=>stmodel.Id==id));
        }
        [HttpPost]

        public ActionResult edit(int id, stregistration rg)
        {
            if (ModelState.IsValid)
            {
                DBhandler d = new DBhandler();
                string b = d.update(id,rg);
                if (b == "updated")
                {
                    ViewBag.msg = "data updated";
                    ModelState.Clear();
                }
            }
            return View();

            /* try
             {

                 DBhandler d = new DBhandler();
                 return RedirectToAction("Index");
             }
             catch 
             {
                 return View(); 
             }*/
        }

        //delete
       
        public ActionResult Delete(string em)
        {
                try
                {
                    DBhandler d = new DBhandler();
                    if (d.Delete(em))
                    {
                        ViewBag.msg = "Item Deleted Successfully";
                    }
                    return RedirectToAction("Index");
                }
                catch 
                { 
                return View();
                }
        }


        /*public ActionResult Alldetails(int id)
        {
            DBhandler d = new DBhandler();

            return View(d.stdlist().Find(m=>m.Id==id));
        }*/

        /*[HttpPost]
        public ActionResult checklogin1(string em,string pas)
        {
            ViewBag.email = em;
            ViewBag.pwd = pas;
            DBhandler d = new DBhandler();
            d.dash(em, pas);
            ModelState.Clear();
            return View();
           
        }*/
        [HttpGet]
        public ActionResult checklogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(stregistration sg)
        {
            //ViewBag.email = em;
            //ViewBag.pwd = pas;
            // DBhandler d = new DBhandler();
            //DataSet dtt= d.dash(em, pas);
            con.Open();
            string qr = "select * from MVCstReg where email='" + sg.email + "' and password='" + sg.password+ "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            //da.Fill(dt, "info");
            da.Fill(dt,"info");
            foreach (DataRow dr in dt.Tables["info"].Rows)
            {
                ViewData["id"] = Convert.ToInt32(dr["Id"]);
                ViewData["fname"] = dr["fisrtname"].ToString();
                ViewData["mname"] = dr["middlename"].ToString();
                ViewData["lname"] = dr["lastname"].ToString();
                ViewData["eml"] = dr["email"].ToString();
                ViewData["mob"] = dr["mobile"].ToString();
                ViewData["gen"] = dr["gender"].ToString();
                ViewData["add"]= dr["address"].ToString();
                ViewData["cr"] = dr["course"].ToString();
                ViewData["str"] = dr["stream"].ToString();
                ViewData["ps"] = dr["password"].ToString();
            }
            con.Close();
            ViewBag.email = sg.email;
            //ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ActionResult changepwd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult pwd(stregistration sg)
        {
            string e= sg.email;
            string p = sg.password;
            DBhandler d = new DBhandler();
            string msg = d.changepassword(p,e);
            if(msg== "password changed")
            {
                ViewBag.msg = "password changed";
            }
            return View();
        }

    }
}