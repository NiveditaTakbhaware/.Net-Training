using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

       sb.Append("Name:" + TextBox1.Text+"<br>");
        sb.Append("Address:" + TextBox2.Text + "<br>");
        sb.Append("Mobile:" + TextBox3.Text + "<br>");
        if (CheckBox1.Checked)
        {
            sb.Append("country:" + CheckBox1.Text + "<br>");
        }
        sb.Append("city:" + DropDownList1.Text + "<br>");
        sb.Append("source:" + DropDownList2.Text + "<br>");
        sb.Append("destination:" + DropDownList3.Text + "<br>");
        if (RadioButton2.Checked)
        {
            sb.Append("payment mode:" + RadioButton2.Text + "<br>");
        }
        else
        {
            sb.Append("payment mode:" + RadioButton3.Text + "<br>");
        }
            Label1.Text = sb.ToString();
    }
}