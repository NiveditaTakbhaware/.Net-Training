using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Net.Http.Headers;
using WebGrease.Css.Ast.Selectors;
using System.Data;

namespace MVCstudentRegistration.Models
{
    public class DBhandler
    {

        static string cnstrng = ConfigurationManager.ConnectionStrings["mvcConstring"].ConnectionString;
            SqlConnection con = new SqlConnection(cnstrng);
        

        //insert query
        public string insert(stregistration rg)
        {
            con.Open();
            string qr = "insert into MVCstReg values('" + rg.fisrtname + "','" + rg.middlename + "','" + rg.lastname + "','" + rg.email + "','" + rg.mobile + "','" + rg.gender + "','" + rg.address + "','" + rg.course + "','" + rg.stream + "','" + rg.password + "','" + rg.photo + "')";
            SqlCommand cmd = new SqlCommand(qr,con);
          int i=Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            if(i==1)
            {
                return "inserted";

            }
            else
            {
                return "not inserted";
            }
        }

        //update query
        public string update(stregistration rg)
        {
            con.Open();
            string qr = "update  MVCstReg set fisrtname='"+rg.fisrtname+ "', middlename='"+rg.middlename+ "', lastname='"+rg.lastname+"', mobile='"+rg.mobile+"', address='"+rg.address+"', password='"+rg.password+"' where email= '"+rg.email+"'";
            SqlCommand cmd = new SqlCommand(qr,con);
           int i=Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            if(i==1)
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
            string qr = "delete from MVCstReg where email='"+eml+"'";
            SqlCommand cmd = new SqlCommand(qr,con);
            int i=Convert.ToInt32(cmd.ExecuteNonQuery());
            con.Close();
            if(i==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //select and display all list
        public List<stregistration> stdlist()
        {
            
            List<stregistration> srg = new List<stregistration>();
            string qr = "select * from MVCstReg";
            SqlCommand cmd = new SqlCommand(qr,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                srg.Add(new stregistration
                {
                    Id =Convert.ToInt32(dr["Id"]),
                    fisrtname=Convert.ToString(dr["fisrtname"]),
                    middlename =Convert.ToString(dr["middlename"]),
                    lastname =Convert.ToString(dr["lastname"]),
                    email =Convert.ToString(dr["email"]),
                    mobile =Convert.ToString(dr["mobile"]),
                    gender = Convert.ToString(dr["gender"]),
                    address =Convert.ToString(dr["address"]),
                    course = Convert.ToString(dr["course"]),                   
                    stream = Convert.ToString(dr["stream"]),
                    password = Convert.ToString(dr["password"]),
                    photo = Convert.ToString(dr["photo"]),

                }) ;
            }
            return srg;
        }
    }
}