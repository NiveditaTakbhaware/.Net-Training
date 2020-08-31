using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MachineRound3NIVI
{
    public partial class login : System.Web.UI.Page
    {
        DBmethods d = new DBmethods();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string pass = d.encryptpass(txtpwd.Text);
            string msg = d.userlogin(email,pass);
            if(msg=="exist")
            {
                Response.Redirect("dashboard.aspx?email="+email);
            }
            else
            {
                Response.Write("inavlid credentials");
            }
        }
    }
}