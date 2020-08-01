using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Net.Configuration;
using System.Configuration;
namespace StudentRegistration
{
    public partial class Registration : System.Web.UI.Page
    
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox9.Text = "Maharashtra";
        }

        protected void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }
        static string cnstrng = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(cnstrng);
        //SqlConnection con = new SqlConnection(@"data source=DESKTOP-JIQGBAC\SQLEXPRESS;integrated security=true;initial catalog=revisionDB");
        protected void Button1_Click(object sender, EventArgs e)
        {
            string gender;
            string ParAdd;
            string course=null;
            string stream=null;
            //string fn1=null;
            string fname = TextBox1.Text;
            string mname = TextBox2.Text;
            string lname = TextBox3.Text;
            string mobile = TextBox4.Text;
            string email = TextBox11.Text;
            if(RadioButton1.Checked)
            {
                gender=RadioButton1.Text;
            }
            else if(RadioButton2.Checked)
            {
                gender = RadioButton2.Text;
            }
            else
            {
                gender = RadioButton3.Text;
            }
            string dob = TextBox5.Text;
            string coressAdd = TextBox7.Text;
            if (CheckBox1.Checked)
            {
                TextBox8.Text = TextBox7.Text;
                // ParAdd = TextBox7.Text;
            }
            else
            {
                ParAdd = TextBox8.Text;
            }
            string city = DropDownList1.Text;                                
            string state = TextBox9.Text;
            string pincode = TextBox10.Text;
           // StringBuilder sb = new StringBuilder();
            foreach(ListItem li in CheckBoxList1.Items)
            {
                if(li.Selected)
                {
                    course = li.Value;
                }
            }
            foreach (ListItem li2 in RadioButtonList1.Items)
            {
                if (li2.Selected)
                {
                    stream = li2.Value;
                }
            }
            string folderPath = Server.MapPath("~/photo/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);

            }

            //Save the File to the Directory (Folder).

            string photoname = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(folderPath + photoname);
            string pcontenttype = FileUpload1.PostedFile.ContentType;
            byte[] bytes;
            using (BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream))
            {
                bytes = br.ReadBytes(FileUpload1.PostedFile.ContentLength);
            }

            //Display the Picture in Image control.
           Image1.ImageUrl = "~/photo/" + Path.GetFileName(FileUpload1.FileName);

            /*string photo = FileUpload1.FileName; 
            if (FileUpload1.HasFile)
            {
                fn1 = Server.MapPath(photo);
                FileUpload1.SaveAs(fn1);
            }*/

            //Image1.ImageUrl = bytes ;
            Class1 cs = new Class1();
            string emailmsg = cs.checkemail(email);
            if (emailmsg == "exist")
            {
                TextBox11.Text = "email id is already exist";
            }
            else
            {
                try
                {
                    con.Open();
                    string qr = "insert into StudentRegistration(FisrtName,MiddleName,LastName,mobile,emailid,gender,Date_of_birth,address,city,state,pin_code,course,stream,photoname,pcontenttype,photo)" +
                        "values(@fn,@mn,@ln,@mob,@em,@gen,@dob,@add,@ct,@st,@pin,@cr,@str,@phn,@pct,@ph)";
                    using (SqlCommand cmd = new SqlCommand(qr, con))
                    {
                        cmd.Parameters.AddWithValue("@fn", fname);
                        cmd.Parameters.AddWithValue("@mn", mname);
                        cmd.Parameters.AddWithValue("@ln", lname);
                        cmd.Parameters.AddWithValue("@mob", mobile);
                        cmd.Parameters.AddWithValue("@em", email);
                        cmd.Parameters.AddWithValue("@gen", gender);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@add", coressAdd);
                        cmd.Parameters.AddWithValue("@ct", city);
                        cmd.Parameters.AddWithValue("@st", state);
                        cmd.Parameters.AddWithValue("@pin", pincode);
                        cmd.Parameters.AddWithValue("@cr", course);
                        cmd.Parameters.AddWithValue("@str", stream);
                        cmd.Parameters.AddWithValue("@phn", photoname);
                        cmd.Parameters.AddWithValue("@pct", pcontenttype);
                        cmd.Parameters.AddWithValue("@ph", bytes);
                        //con.Open();
                        cmd.ExecuteNonQuery();
                        // Response.Write("Registration successful..!");

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

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Test", "alert('registration successful..');", true);
            }
        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

            /*if (CheckBox1.Checked)
            {
                TextBox8.Text = TextBox7.Text;
                // ParAdd = TextBox7.Text;
            }
            else
            {
                TextBox8.Text = string.Empty;
            }*/

        }
      
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            TextBox8.Text = TextBox7.Text;
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
            DateTime db = Convert.ToDateTime(TextBox5.Text);
            TextBox6.Text=Convert.ToString(get_age(db));


        }
        public int get_age(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Subtract(dob).Days;
            age = age / 365;
            return age;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("password.aspx");
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            /*string folderPath = Server.MapPath("~/photo/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);

            }
            Image1.ImageUrl = "~/photo/" + Path.GetFileName(FileUpload1.FileName);*/
        }
    }
}