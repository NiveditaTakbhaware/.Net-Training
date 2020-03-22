using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class objectiveQues : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double ans = 0;
       
        if(RadioButton1.Checked)
        {
            ans = ans -1;
        }
        else if(RadioButton2.Checked)
        {
            ans = ans + 1;
        }
        if(RadioButton3.Checked)
        {
            ans = ans + 1;
        }
        else if(RadioButton4.Checked)
        {
            ans = ans - 1;
        }
        if(RadioButton5.Checked)
        {
            ans = ans -1;
        }
        else if(RadioButton6.Checked)
        {
            ans = ans + 1;
        }
        TextBox1.Text = "result=" + ans;
    }
}