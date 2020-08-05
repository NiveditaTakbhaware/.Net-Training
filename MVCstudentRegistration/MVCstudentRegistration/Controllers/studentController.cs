using MVCstudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace MVCstudentRegistration.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        //display all list
       
        public ActionResult Index()
        {
            ViewBag.stlist = "students list";
            DBhandler d = new DBhandler();
            ModelState.Clear();
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
              if(ModelState.IsValid)
                {
                    DBhandler d = new DBhandler();
                    string b =d.insert(rg);
                    if(b== "inserted")
                    {
                        ViewBag.mesg = "data inserted";
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
                string b = d.update(rg);
                if (b == "updated")
                {
                    ViewBag.mesg = "data updated";
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
                        ViewBag.AlertMsg = "Item Deleted Successfully";
                    }
                    return RedirectToAction("Index");
                }
                catch 
                { 
                return View();
                }
        }

        
        public ActionResult Alldetails(int id)
        {
            DBhandler d = new DBhandler();

            return View(d.stdlist().Find(m=>m.Id==id));
        }

    }
}