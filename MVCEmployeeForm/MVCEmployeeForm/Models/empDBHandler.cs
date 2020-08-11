using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace MVCEmployeeForm.Models
{
    public class empDBHandler
    {
        static string connstrng = ConfigurationManager.ConnectionStrings["empstrng"].ConnectionString;
        SqlConnection con = new SqlConnection(connstrng);

        //insert query
        public string insert(empmodel em)
        {
            string kn = string.Empty;
            foreach(var k in em.knowledge)
            {
                kn = kn +" "+k.ToString();
            }
            con.Open();
            string qr = "insert into EmpReg values('" + em.name + "','" + em.city + "','" + em.profession + "','" + kn + "','" + em.exprience + "','" + em.department + "','" + em.hiredDate + "','" + em.email + "','" + em.password + "')";
            SqlCommand cmd = new SqlCommand(qr, con);
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            if (i == 1)
            {
                return "inserted";

            }
            else
            {
                return "not inserted";
            }
        }

        //update query
        public string update(empmodel em)
        {
            con.Open();
            string qr = "update  EmpReg set name='" + em.name + "',city='" + em.city + "', profession='" + em.profession + "', exprience='" + em.exprience + "', department='" + em.department + "', hiredDate='" + em.hiredDate + "', password='" + em.password + "' where email= '" + em.email + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            if (i == 1)
            {
                return "updated";
            }
            else
            {
                return "not updated";
            }
        }

        //delete query
        public bool Delete(string eml)
        {
            con.Open();
            string qr = "delete from EmpReg where email='" + eml + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //select and display all list
        public List<empmodel> emplist()
        {

            List<empmodel> emp = new List<empmodel>();
            string qr = "select empid,name,profession,exprience,department,hiredDate,email,password from EmpReg";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                emp.Add(new empmodel
                {
                    empid = Convert.ToInt32(dr["empid"]),
                    name = Convert.ToString(dr["name"]),
                    //city = (City)dr["city"],
                    profession = Convert.ToString(dr["profession"]),
                    //knowledge = dr["knowledge"],
                    exprience = Convert.ToInt32(dr["exprience"]),
                    department = Convert.ToString(dr["department"]),
                    hiredDate = Convert.ToString(dr["hiredDate"]),
                    email = Convert.ToString(dr["email"]),                    
                    password = Convert.ToString(dr["password"]),
                });
            }
            return emp;
        }
    }
}