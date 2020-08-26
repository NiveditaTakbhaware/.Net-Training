using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;

namespace MachineRound3NIVI
{
    public partial class signup : System.Web.UI.Page
    {
        DBmethods d = new DBmethods();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string fname = txtfname.Text;
            string mname = txtmname.Text;
            string lname = txtlname.Text;
            string mobile = txtmobile.Text;
            string email = txtemail.Text;
            string pwd = d.encryptpass(txtpwd.Text);
            string gender=null;
            if(rbtnmale.Checked)
            {
                gender = rbtnmale.Text;
            }
            if(rbtnfemale.Checked)
            {
                gender = rbtnfemale.Text;
            }
            DateTime dob =Convert.ToDateTime(txtdob.Text);
            int age = Convert.ToInt32(txtage.Text);
            string caddress = txtcaddress.Text;
            string paddress = txtpaddress.Text;
            string experience = ddexperience.Text;
            string department = null;
            foreach (ListItem d1 in rbtnlistdepartment.Items)
            {
                if (d1.Selected)
                {
                    department = d1.Value;
                }
            }
            string profile = txtprofile.Text;
            string knowledge = null;
            
            foreach (ListItem r1 in chblistknowledge.Items)
            {
                if (r1.Selected)
                {
                    knowledge = knowledge+" "+r1.Value;

                }
            }
            BinaryReader br = new BinaryReader(FileUploadphoto.PostedFile.InputStream);
              byte[] photo = br.ReadBytes(FileUploadphoto.PostedFile.ContentLength);
            Imagephoto.ImageUrl = "~/photo/" + Path.GetFileName(FileUploadphoto.FileName);

           
            string msg = d.insert(fname,mname,lname,mobile,email,pwd,gender,dob,age,caddress,paddress,experience,department,profile,knowledge,photo);
            ScriptManager.RegisterClientScriptBlock(this,this.GetType(),"Test",msg,true);
        }

        protected void chbPaddress_CheckedChanged(object sender, EventArgs e)
        {
            txtpaddress.Text = txtcaddress.Text;
        }
      
        protected void txtdob_TextChanged(object sender, EventArgs e)
        {
            
            DateTime dobt = Convert.ToDateTime(txtdob.Text);
            txtage.Text = Convert.ToString(d.getage(dobt));
        }
    }
}