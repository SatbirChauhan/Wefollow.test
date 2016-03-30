using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class company_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       nsfollow.clsusr obj = new nsfollow.clsusr();
        Int32 a = obj.chgpwd(Convert.ToInt32(Session["usrcod"]), TextBox1.Text,
                    TextBox2.Text, 'C');
        if (a == 0)
            Label2.Text = "Old Password Incorrect";
        else
            Label2.Text = "success";
    }
}