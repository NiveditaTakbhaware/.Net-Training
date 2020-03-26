using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dropdownlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            DropDownList1.Items.Add("java");
            DropDownList1.Items.Add("c");
            DropDownList1.Items.Add("c++");
            DropDownList1.Items.Add(".net");
        }
    }
}