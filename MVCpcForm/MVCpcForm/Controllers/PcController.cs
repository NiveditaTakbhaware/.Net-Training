using MVCpcForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace MVCpcForm.Controllers
{
    public class PcController : Controller
    {
        static string cnstrng = ConfigurationManager.ConnectionStrings["mvcConstring"].ConnectionString;
        SqlConnection con = new SqlConnection(cnstrng);
        // GET: Pc
       
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(PcModel p)
        {
            if (p.img!= null)

            {
                Stream fs = p.img.InputStream;

                BinaryReader br = new BinaryReader(fs);

                byte[] bytes = br.ReadBytes((Int32)fs.Length);

                SqlCommand cmd = new SqlCommand("Insert into pcform(brandname,category,screensize,memory,os,color,img,name)values(@bd,@cat,@sc,@mem,@os,@col,@img,@name)", con);
                cmd.Parameters.AddWithValue("@bd", p.brandname);
                cmd.Parameters.AddWithValue("@cat", p.category);
                cmd.Parameters.AddWithValue("@sc", p.screensize);
                cmd.Parameters.AddWithValue("@mem", p.memory);
                cmd.Parameters.AddWithValue("@os", p.os);
                cmd.Parameters.AddWithValue("@col", p.color);
                cmd.Parameters.AddWithValue("@img", bytes);
                cmd.Parameters.AddWithValue("@name", p.name);

                con.Open();

                int i=Convert.ToInt32(cmd.ExecuteNonQuery());
                con.Close();
                if(i==1)
                {
                    ViewBag.msg = "inserted done !";
                }
            }

            return View();
        }
        public ActionResult list(PcModel pc)
        {
            //con.Open();
            string q = "select id,brandname,category,screensize,memory,os,color,img,name from pcform";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sd.Fill(ds, "info");
            //con.Close();
            foreach (DataRow dr in ds.Tables["info"].Rows)
            {
                pc.id = Convert.ToInt32(dr["id"]);
                pc.brandname =(bd)dr["brandname"];
                pc.category = dr["category"].ToString();
                pc.screensize = dr["screensize"].ToString();
                pc.memory = dr["memory"].ToString();
                pc.os = (OS)dr["os"];
                pc.color = dr["color"].ToString();
                byte[] pic = (byte[])dr["img"];
                string p = Convert.ToBase64String(pic, 0, pic.Length);
                string pi = "data:image/png;base64," + p;
                ViewBag.imge = pi;
                pc.name = dr["name"].ToString();
                //ViewBag.name = pc.name;
            }
            return View();
        }
    }
}
