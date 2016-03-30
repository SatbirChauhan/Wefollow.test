using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //protected void Button1_Click(object sender, EventArgs e)
    //{
    //    

    //}

    private void clearpln()
    {
        txtplnnam.Text = String.Empty;
        txtplncst.Text = String.Empty;
        txtplnnoe.Text = String.Empty;
        txtplndsc.Text = String.Empty;
    }
    //protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    //{
    //  
    //}
    //protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    //{
   
     
    //}
    //protected void Button2_Click(object sender, EventArgs e)
    //{
    //
    //}

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsfollow.clspln obj = new nsfollow.clspln();
        nsfollow.clsplnprp objprp = new nsfollow.clsplnprp();
        objprp.p_plnnam = txtplnnam.Text;
        objprp.p_plnprc = Convert.ToSingle(txtplncst.Text);
        objprp.p_plnnoe = Convert.ToInt32(txtplnnoe.Text);
        objprp.p_plndsc = txtplndsc.Text;
        if (Button1.Text == "Submit")
        {
            obj.savepln_rec(objprp);
        }
        else
        {
            objprp.p_plncod = Convert.ToInt32(ViewState["cod"]);
            obj.updpln_rec(objprp);
            Button1.Text = "Submit";
        }
        clearpln();
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        nsfollow.clspln obj = new nsfollow.clspln();
        nsfollow.clsplnprp objprp = new nsfollow.clsplnprp();
        List<nsfollow.clsplnprp> k = obj.findpln_rec(a);
        txtplnnam.Text = k[0].p_plnnam;
        txtplnnoe.Text = k[0].p_plnnoe.ToString();
        txtplncst.Text = k[0].p_plnprc.ToString();
        txtplndsc.Text = k[0].p_plndsc;
        Button1.Text = "Update";
        ViewState["cod"] = a;
        e.Cancel = true;
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsfollow.clspln obj = new nsfollow.clspln();
        nsfollow.clsplnprp objprp = new nsfollow.clsplnprp();
        objprp.p_plncod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.delpln_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        clearpln();
        Button1.Text = "Submit";
    }
}