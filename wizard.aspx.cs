using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wizard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("name:" + TextBox1.Text + "<br>");
        sb.Append("password:" + TextBox2.Text + "<br>");

        Label6.Text= sb.ToString();

    }
}