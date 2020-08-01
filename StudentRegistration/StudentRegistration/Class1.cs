using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Configuration;
namespace StudentRegistration
{
    public class Class1
    {
        static string cnstrng = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(cnstrng);
        //SqlConnection con = new SqlConnection(@"data source=DESKTOP-JIQGBAC\SQLEXPRESS;integrated security=true;initial catalog=revisionDB");
        public string checkemail(string email)
        {
            
            string msg = null;
            try
            {
                con.Open();
                string qr = "select count(*) from StudentRegistration where emailid='" + email + "'";
                SqlCommand cmd = new SqlCommand(qr, con);
                int r = Convert.ToInt32(cmd.ExecuteScalar());
                if (r == 1)
                {
                    msg = "exist";
                }
                else
                {
                    msg = "not";
                }
            }
            catch (Exception ee)
            {
                ee.ToString();
            }
            finally
            {
                con.Close();
            }
            return msg;
        }
        public string pwdcheckemail(string email)
        {

            string msg = null;
            try
            {
                con.Open();
                string qr = "select count(*) from studpassword where emailid='" + email + "'";
                SqlCommand cmd = new SqlCommand(qr, con);
                int r = Convert.ToInt32(cmd.ExecuteScalar());
                if (r == 1)
                {
                    msg = "exist";
                }
                else
                {
                    msg = "not";
                }
            }
            catch (Exception ee)
            {
                ee.ToString();
            }
            finally
            {
                con.Close();
            }
            return msg;
        }
        public string encryptpass(string password)
        {
            string msg = "";
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            msg = Convert.ToBase64String(encode);
            return msg;
        }
        public DataSet profile(string eml)
        {
           
                       
                string qr = "select FisrtName,MiddleName,LastName,mobile,emailid,course,stream,photoname,pcontenttype,photo from StudentRegistration where emailid='" + eml + "'";
                SqlCommand cmd = new SqlCommand(qr, con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sd.Fill(ds);
                return ds;
           
           
        }
    }
}