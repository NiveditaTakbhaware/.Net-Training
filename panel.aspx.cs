using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class panel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string u = TextBox1.Text;
        string p = TextBox2.Text;
        if(u=="nivi" && p=="123")
        {
            Label2.Text = "welcome " + u;
        }
    }
}