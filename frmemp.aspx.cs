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
            bind("%");

        }

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmaddemp.aspx");
    }
    private void bind(string s)
    {
        nsfollow.clsemp obj = new nsfollow.clsemp();
        GridView1.DataSource = obj.srcemp(Convert.ToInt32(Session["ccod"]), s);
        GridView1.DataBind();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsfollow.clsemp obj = new nsfollow.clsemp();
        nsfollow.clsempprp objprp = new nsfollow.clsempprp();
        objprp.p_empcod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.delemp_rec(objprp);
        bind("%");      


    }

    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        bind(e.CommandArgument.ToString() + "%");
    }
}