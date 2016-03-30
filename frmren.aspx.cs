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
        Session["pcod"] = DropDownList1.SelectedValue;
        Session["amt"] = DetailsView1.DataKey[0];
        Response.Redirect("frmpay.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}