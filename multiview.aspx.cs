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
        if(bus_pass.ActiveViewIndex==0)
        {
            bus_pass.ActiveViewIndex = 1;
        }
        else
        {
            bus_pass.ActiveViewIndex = 0;
        }
    }

    protected void bus_pass_ActiveViewChanged(object sender, EventArgs e)
    {

    }
}