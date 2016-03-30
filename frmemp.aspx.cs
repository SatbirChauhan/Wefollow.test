using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class company_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
                ArrayList ar = new ArrayList();

            for (Int32 i=65;i<91;i++)
            {
                ar.Add(Convert.ToChar(i)); 
            }
            DataList1.DataSource = ar;
            DataList1.DataBind();
        }
        bind("%");

    }
    private void bind(string s)
    {
        nsfollow.clsemp obj = new nsfollow.clsemp();
        GridView1.DataSource = obj.srcempfol(Convert.ToInt32(Session["ccod"]), s,Convert.ToInt32(Session["cod"]));
        GridView1.DataBind();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][1]);
        nsfollow.clsfol obj = new nsfollow.clsfol();
        nsfollow.clsfolprp objprp = new nsfollow.clsfolprp();
        if(a==0)
        {
            objprp.p_folempcod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
            objprp.p_folfolempcod = Convert.ToInt32(Session["cod"]);
            obj.savefol_rec(objprp);
        }
        else
        {
            objprp.p_folempcod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
            objprp.p_folfolempcod = Convert.ToInt32(Session["cod"]);
            obj.delfol_rec(objprp);
        }
        bind("%");

    }

    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        bind(e.CommandArgument.ToString() + "%");
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow) {
            LinkButton lk = (LinkButton)(e.Row.FindControl("lk"));
            Int32 sts = Convert.ToInt32(GridView1.DataKeys[e.Row.RowIndex][1]);
            if (sts == 0)
                lk.Text = "Follow";
            else
                lk.Text = "Unfollow";  
        }

    }
}