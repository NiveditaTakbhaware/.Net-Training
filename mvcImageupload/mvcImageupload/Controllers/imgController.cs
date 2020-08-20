using mvcImageupload.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Data;

namespace mvcImageupload.Controllers
{
    public class imgController : Controller
    {
        static string cnstrng = ConfigurationManager.ConnectionStrings["mvcConstring"].ConnectionString;
        SqlConnection con = new SqlConnection(cnstrng);
        // GET: img
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(imgModel i)
        {

                if (i.img.FileName != null)

                {

                    Stream fs = i.img.InputStream;

                    BinaryReader br = new BinaryReader(fs);

                byte[] bytes = br.ReadBytes((Int32)fs.Length);                  

                    SqlCommand cmd = new SqlCommand("Insert into image(img,name) values(@img,@name)", con);

                    cmd.Parameters.AddWithValue("@img", bytes);

                    cmd.Parameters.AddWithValue("@name", i.name);


                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            
           
            return View();

        }
       
        public ActionResult list(imgModel im)
        {
            //con.Open();
            string q = "select img,name from image";
            SqlCommand cmd = new SqlCommand(q,con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sd.Fill(ds,"info");
            //con.Close();
            foreach(DataRow dr in ds.Tables["info"].Rows)
            {
                byte[] pic = (byte[])dr["img"];
                string p = Convert.ToBase64String(pic,0,pic.Length);
               string pi="data:image/png;base64," + p;
                ViewBag.imge = pi;
                im.name = dr["name"].ToString();
                ViewBag.name = im.name;
            }
            return View();
        }
    }
}