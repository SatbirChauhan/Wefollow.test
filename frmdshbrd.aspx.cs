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
        nsfollow.clsupd obj = new nsfollow.clsupd();
        nsfollow.clsupdprp objprp = new nsfollow.clsupdprp();
        objprp.p_upddat = DateTime.Now;
        objprp.p_upddsc = TextBox1.Text;
        objprp.p_updempcod = Convert.ToInt32(Session["cod"]);
        string s = FileUpload1.PostedFile.FileName;
        if (s != "")
            s = s.Substring(s.LastIndexOf('.'));
        objprp.p_updfil = s;
        Int32 a = obj.saveupd_rec(objprp);
        if (s != "")
            FileUpload1.PostedFile.SaveAs(Server.MapPath("../updfil") + "//" + a.ToString() + s);
        TextBox1.Text = String.Empty;
        GridView1.DataBind();

    }
    public string gettxt(DateTime d)
    {
        TimeSpan ts = DateTime.Now.Subtract(d);
        if (ts.Days > 0)
            return ts.Days + "Days ago";
        else if (ts.Minutes > 0)
            return ts.Minutes + "Minutes ago";
        else if (ts.Hours > 0)
            return ts.Hours + "Hours ago";
        else
            return "Now";
    }
    public String getsrc(Int32 updcod,String updfil)
    {
        if (updfil == "")
            return "";
        else
        {
        return "<a href=../updfil/"+updcod.ToString()+updfil+" class=lkbtnn>viewfile&nbsp;</a>";

        }
    }



    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lk = (LinkButton)(e.Row.FindControl("lkbtn"));
            Int32 a = Convert.ToInt32(GridView1.DataKeys[e.Row.RowIndex][1]);
            if (a == Convert.ToInt32(Session["cod"]))
                lk.Visible = true;
            else
                lk.Visible = false;

        }
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsfollow.clsupd obj = new nsfollow.clsupd();
        nsfollow.clsupdprp objprp = new nsfollow.clsupdprp();
        objprp.p_updcod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.delupd_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }
}