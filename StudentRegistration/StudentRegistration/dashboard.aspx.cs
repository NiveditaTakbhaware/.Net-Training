using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace StudentRegistration
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string em = Request.QueryString["email"].ToString();
            //Response.Write(em);
            //string pass = Request.QueryString["pass"].ToString();
            Class1 cs = new Class1();
            DataSet ds = cs.profile(em);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string fn = dr["FisrtName"].ToString();
                string mn = dr["MiddleName"].ToString();
                string ln = dr["LastName"].ToString();
                StringBuilder sb = new StringBuilder();
                sb.Append(fn + "\t");
                sb.Append(mn + "\t");
                sb.Append(ln);
                Label1.Text = sb.ToString();
                Label2.Text = dr["emailid"].ToString();
                Label3.Text = dr["mobile"].ToString();
                Label4.Text = dr["course"].ToString();
                Label5.Text = dr["stream"].ToString();                                 
                byte[] bytes = (byte[])dr["photo"];
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                Image1.ImageUrl = "data:image/jpg;base64," + base64String;                   
                Response.Write("Welcome "+Label1.Text+" !");
            }        
        }
    }
}