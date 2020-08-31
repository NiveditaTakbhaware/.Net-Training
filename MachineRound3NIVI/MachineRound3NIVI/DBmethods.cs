using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace MachineRound3NIVI
{
    public class DBmethods
    {
        static string cnst = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;
        SqlConnection con = new SqlConnection(cnst);

        public string insert(string fname,string mname,string lname,string mobile,string email,string password, string gender, DateTime dob, int age, string coadd, string pradd, string exp, string dep, string profile, string knowledge, byte[] photo)
        {
            try
            {
                con.Open();
                string q = "insert into niviTable(firstname,middlename,lastname,mobile,email,password,gender,dateOfbirth,age,coresspondingAddress,parmanentAddress,experience,department,profile,knowledge,photo)values(@fn,@mn,@ln,@mob,@email,@pwd,@gen,@dob,@age,@cadd,@padd,@exp,@dep,@pro,@kn,@ph)";
                SqlCommand cmd = new SqlCommand(q,con);
                cmd.Parameters.AddWithValue("@fn",fname);
                cmd.Parameters.AddWithValue("@mn",mname);
                cmd.Parameters.AddWithValue("@ln",lname);
                cmd.Parameters.AddWithValue("@mob",mobile);
                cmd.Parameters.AddWithValue("@email",email);
                cmd.Parameters.AddWithValue("@pwd", password);
                cmd.Parameters.AddWithValue("@gen",gender);
                cmd.Parameters.AddWithValue("@dob",dob);
                cmd.Parameters.AddWithValue("@age",age);
                cmd.Parameters.AddWithValue("@cadd",coadd);
                cmd.Parameters.AddWithValue("@padd",pradd);
                cmd.Parameters.AddWithValue("@exp",exp);
                cmd.Parameters.AddWithValue("@dep",dep);
                cmd.Parameters.AddWithValue("@pro",profile);
                cmd.Parameters.AddWithValue("@kn",knowledge);
                cmd.Parameters.AddWithValue("@ph",photo);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                e.ToString();
            }
            finally
            {
                con.Close();
            }
            return "alert(Registration successful);";
            
        }
        public string encryptpwd(string pwd)
        {
            string ecnpwd = null;
            byte[] encode = new byte[pwd.Length];
            encode = Encoding.UTF8.GetBytes(pwd);
            ecnpwd = Convert.ToBase64String(encode);
            return ecnpwd;
        }
        public string encryptpass(string password)
        {
            string msg = "";
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            msg = Convert.ToBase64String(encode);
            return msg;
        }
        public int getage(DateTime db)
        {
            int age = DateTime.Now.Subtract(db).Days;
            age = age / 365;
            return age;
        }

        public string  userlogin(string email,string pwd)
        {
            string res = null;
            con.Open();
            string q = "select count(*) from niviTable where email='"+email+"' and password='"+pwd+"'";
            SqlCommand cmd = new SqlCommand(q,con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if(i==1)
            {
                res = "exist";
            }
            else
            {
                res = "not";
            }
            return res;

        }
        public DataSet profile(string email)
        {
            string q = "select id,firstname,middlename,lastname,mobile,email,gender,dateOfbirth,photo from niviTable where email='" + email + "'";
            SqlCommand cmd = new SqlCommand(q,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }
}