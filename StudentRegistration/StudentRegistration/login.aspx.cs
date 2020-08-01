using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace StudentRegistration
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
       static string cnstrng = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(cnstrng);
        // SqlConnection con = new SqlConnection(@"data source=DESKTOP-JIQGBAC\SQLEXPRESS;integrated security=true;initial catalog=revisionDB");
        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 cs = new Class1();
            string email = TextBox1.Text;
            string pwd = cs.encryptpass(TextBox2.Text);
            try
            {
                con.Open();
                string qr = "select count(*) from studpassword where emailid='" + email + "'and password='" + pwd + "'";
                SqlCommand cmd = new SqlCommand(qr,con);
                int r = Convert.ToInt32(cmd.ExecuteScalar());
                if(r==1)
                {
                    Response.Redirect("dashboard.aspx?email="+email);
                }
                else 
                {
                    Label1.Text = "invalid credential";                
                }
            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally
            {
                con.Close();
            }
                
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}