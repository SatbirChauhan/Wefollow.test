using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class emp_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsfollow.clsgrp obj = new nsfollow.clsgrp();
        nsfollow.clsgrpprp objprp = new nsfollow.clsgrpprp();
        objprp.p_grpnam = TextBox1.Text;
        objprp.p_grpdsc = TextBox2.Text;
        objprp.p_grpownempcod = Convert.ToInt32(Session["cod"]);
        objprp.p_grpcrtdat = DateTime.Now;
        obj.savegrp_rec(objprp);
        TextBox1.Text = String.Empty;
        TextBox2.Text = String.Empty;
        GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}