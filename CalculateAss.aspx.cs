using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CalculateAss : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int num1 = Convert.ToInt32(TextBox1.Text);
        int num2 = Convert.ToInt32(TextBox2.Text);
        if (RadioButton1.Checked)
        {
            int sum = num1 + num2;
            TextBox3.Text = "addition=" + sum;
        }
        else if (RadioButton2.Checked)
        {
                       
                int sub = num1 - num2;
                TextBox3.Text = "subtraction=" + sub;

        }
        else if (RadioButton3.Checked)
        {
            int mul = num1 * num2;
            TextBox3.Text = "multiplication=" + mul;
        }
        else if (RadioButton4.Checked)
        {
            if (num1 > num2)
            {
                int div = num1 / num2;
                TextBox3.Text = "division=" + div;
            }
            else
            {
                TextBox3.Text="division is not possible";
            }
            }
    }
}