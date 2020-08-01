using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
namespace StudentRegistration
{
    public partial class password : System.Web.UI.Page 
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       static string cnstrng = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(cnstrng);
        // SqlConnection con = new SqlConnection(@"data source=DESKTOP-JIQGBAC\SQLEXPRESS;integrated security=true;initial catalog=revisionDB");
        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 cs = new Class1();
            string uname = TextBox1.Text;
            string password = cs.encryptpass(TextBox2.Text);
            string emailmsg = cs.pwdcheckemail(uname);
            if (emailmsg == "exist")
            {
                Label1.Text = "this email id has already created password";
            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into studpassword(password,emailid)values(@pass,@email)", con);
                    cmd.Parameters.AddWithValue("@email", uname);
                    cmd.Parameters.AddWithValue("@pass", password);
                    // cmd.ExecuteNonQuery();
                    //Label1.Text = "password created successfully";
                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {
                        Label1.Text = "password created successfully";
                        //Label1.ForeColor = System.Drawing.Color.ForestGreen;
                    }
                    else
                    {
                        Label1.Text = "Error while password creating";
                        //Label1.ForeColor = System.Drawing.Color.Red;
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
        }
       
    }
    
}