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

    protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = Calendar1.SelectedDate.ToLongDateString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("name:" + TextBox1.Text + "<br>");
        sb.Append("address:" + TextBox2.Text + "<br>");
        sb.Append("date:" + Calendar1.SelectedDate + "<br>");
        //sb.Append("bus type:" + CheckBoxList1.Items + "<br>");
        //sb.Append("gender:" + RadioButtonList1.Items + "<br>");
         foreach (ListItem li in CheckBoxList1.Items)
         {
             if (li.Selected)
             {
                 sb.Append("bus type:" + li.Value + "<br>");
             }
         }
         foreach (ListItem li in RadioButtonList1.Items)
         {
             if (li.Selected)
             {
                 sb.Append("gender:" + li.Value+ "<br>");
             }
         }

        Label2.Text = sb.ToString();
       
    }
}