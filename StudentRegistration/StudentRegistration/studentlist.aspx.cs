using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.WebSockets;
using System.Data;
using System.Configuration;

namespace StudentRegistration
{
    public partial class studentlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cnstrng = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(cnstrng);
            //SqlConnection con = new SqlConnection(@"data source=DESKTOP-JIQGBAC\SQLEXPRESS;integrated security=true;initial catalog=revisionDB");
            string qr = "select * from StudentRegistration";
            SqlDataAdapter da = new SqlDataAdapter(qr,con);
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentRegistration");
            Response.Write("<h1 align=center> Details of student </h1><hr>");
            Response.Write("<table width=70% border=1 align=center>");
            Response.Write("<th>First name</th>");
            Response.Write("<th>Middle name</th>");
            Response.Write("<th>Last name</th>");
            Response.Write("<th>Mobile number</th>");
            Response.Write("<th>course</th>");
            Response.Write("<th>Stream</th>");
            Response.Write("<th>Photo</th>");
            foreach(DataRow dr in ds.Tables["StudentRegistration"].Rows)
            {
                Response.Write("<tr>");
                Response.Write("<td>");
                
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["FisrtName"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["MiddleName"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["LastName"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["mobile"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["course"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["stream"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                byte[] pic = (byte[])dr["photo"];
                string base64String = Convert.ToBase64String(pic, 0, pic.Length);
                string p= "data:image/jpg;base64," + base64String;
                Response.Write("<center> <img src="+p+ " width=100 height=60 /></center>");
                Response.Write("</td>");
                Response.Write("</tr>");
            }
            Response.Write("</table>");
        }
    }
}