using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MachineRound3NIVI
{
    public partial class dashboard : System.Web.UI.Page
    {
        DBmethods d = new DBmethods();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Email"] = Request.QueryString["email"];
            string em = Session["Email"].ToString();
            Response.Write("welcome.. " +Session["Email"]+"</br>");

            DataSet dt = d.profile(em);
            /*foreach(DataRow dr in dt.Tables[0].Rows)
            {
                Response.Write(dr["id"]+"</br>");
                string fn = dr["firstname"].ToString();
                string mn = dr["middlename"].ToString();
                string ln = dr["lastname"].ToString();
                StringBuilder sb = new StringBuilder();
                sb.Append(fn+"\t");
                sb.Append(mn+"\t");
                sb.Append(ln+"\t");
                Response.Write(sb+"</br>");
                Response.Write(dr["mobile"]+ "</br>");
                Response.Write(dr["email"]+ "</br>");
                Response.Write(dr["gender"]+ "</br>");
                Response.Write(dr["dateOfbirth"]+ "</br>");
                byte[]p=(byte[])dr["photo"];
                string pic = Convert.ToBase64String(p,0,p.Length);
               Image1.ImageUrl="data:image/jpg;base64,"+pic;
            }*/
            Response.Write("<h1 align=center><b>student profile</b></h1><hr>");
            Response.Write("<table width=70% border=1 align=center>");
            Response.Write("<th>first name</th>");
            Response.Write("<th>middle name</th>");
            Response.Write("<th>last name</th>");
            Response.Write("<th>mobile</th>");
            Response.Write("<th>email</th>");
            Response.Write("<th>gender</th>");
            Response.Write("<th>date of birth</th>");
            Response.Write("<th>photo</th>");
            foreach (DataRow dr in dt.Tables[0].Rows)
            {
                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["firstname"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["middlename"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["lastname"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["mobile"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["email"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["gender"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["dateOfbirth"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                byte[] pic = (byte[])dr["photo"];
                string ph = Convert.ToBase64String(pic, 0, pic.Length);
                string pho = "data:image/jpg;base64," + ph;
                Response.Write("<center><img src="+pho+" width=100 height=60 </center>");
                Response.Write("</td>");
                Response.Write("</tr>");
            }
            Response.Write("</table>");
        }
    }
}