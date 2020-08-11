using MVCEmployeeForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace MVCEmployeeForm.Controllers
{
    public class empController : Controller
    {
        empDBHandler ed = new empDBHandler();
        // GET: emp
        public ActionResult List()
        {
            ViewBag.msg = "employee list";
            //empDBHandler ed = new empDBHandler();
            ModelState.Clear();
            return View(ed.emplist());
        }

        //insert
        [HttpGet]
        public ActionResult insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult insert(empmodel em)
        {
            if(ModelState.IsValid)
            {
               // empDBHandler ed = new empDBHandler();
                string b = ed.insert(em);
                if(b=="inserted")
                {
                    ViewBag.Imsg = "registration done";
                    ModelState.Clear();
                }
            }
            return View();
        }

        //update
        [HttpGet]
        public ActionResult update(int eid)
        {
            empDBHandler emd = new empDBHandler();
            return View(emd.emplist().Find(m=>m.empid==eid));
        }
        [HttpPost]
        public ActionResult update(empmodel em)
        {
            if(ModelState.IsValid)
            {
                // empDBHandler ed = new empDBHandler(); 
                string b = ed.update(em);
                if(b== "updated")
                {
                    ViewBag.Umsg = "data updated";
                    ModelState.Clear();
                }
            }
            return View();
        }

        //delete
    
        public ActionResult delete(string eml)
        {
            
            if(ed.Delete(eml))
            {
                ViewBag.Dmsg = "deletion done";
                return RedirectToAction("List");
            }
           
            else
            {
                return View();
            }
        }
        

    }
}