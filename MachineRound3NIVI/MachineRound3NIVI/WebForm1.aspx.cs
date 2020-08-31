using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.IO;
using System.Diagnostics.CodeAnalysis;

namespace MachineRound3NIVI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static string cn = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;
        SqlConnection con = new SqlConnection(cn);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            //DBmethods d = new DBmethods();
            string email = txtemail.Text;
            string pass = txtpwd.Text;
            string msg =pwdenc(pass);
            byte[] pic;
            BinaryReader br = new BinaryReader(fileuploadphoto.PostedFile.InputStream);
            pic = br.ReadBytes(fileuploadphoto.PostedFile.ContentLength);
            string ph = Convert.ToBase64String(pic, 0, pic.Length);
            userImage.ImageUrl = "data:image/jpg;base64," + ph;
            try
            {
                con.Open();
                string q = "insert into pwdtable(email,password,photo)values(@e,@p,@pic)";
                SqlCommand cmd = new SqlCommand(q,con);
                cmd.Parameters.AddWithValue("@e",email);
                cmd.Parameters.AddWithValue("@p",msg);
                cmd.Parameters.AddWithValue("@pic",pic);
                int i=Convert.ToInt32(cmd.ExecuteNonQuery());
                if (i == 1)
                {
                    lblstatus.Text = "registartion done";
                }
                con.Close();
            }
            catch(Exception ee)
            {
                lblstatus.Text = ee.ToString();
            }
          
        }
        public string pwdenc(string p)
        {
            string msg = "";
            byte[] enc = new byte[p.Length];
            enc = Encoding.UTF8.GetBytes(p);
            msg = Convert.ToBase64String(enc);
            return msg;
        }
    }
}