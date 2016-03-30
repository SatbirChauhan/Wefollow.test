using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class emp_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Int32 a = Convert.ToInt32(Request.QueryString["gcod"]);
            nsfollow.clsgrp obj = new nsfollow.clsgrp();
            List<nsfollow.clsgrpprp> k = obj.findgrp_rec(a);
            if (k[0].p_grpownempcod == Convert.ToInt32(Session["cod"]))
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
            }
        }
    }
    public string getnam(Int32 empcod)
    {
        nsfollow.clsemp obj = new nsfollow.clsemp();
        List<nsfollow.clsempprp> k = obj.findemp_rec(empcod);
        return k[0].p_empnam;
    }

    //protected void Button1_Click(object sender, EventArgs e)
    //{

    //}


    //protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    //{

    //}

    protected void GridView2_RowEditing1(object sender, GridViewEditEventArgs e)
    {
        nsfollow.clsgrpmem obj = new nsfollow.clsgrpmem();
        nsfollow.clsgrpmemprp objprp = new nsfollow.clsgrpmemprp();
        objprp.p_grpmemgrpcod = Convert.ToInt32(Request.QueryString["gcod"]);
        objprp.p_grpmemempcod = Convert.ToInt32(GridView2.DataKeys[e.NewEditIndex][0]);
        obj.savegrpmem_rec(objprp);
        nsfollow.clsemp obj1 = new nsfollow.clsemp();
        GridView2.DataSource = obj1.srcempforgrp(Convert.ToInt32(Session["ccod"]), TextBox1.Text + "%", Convert.ToInt32(Request.QueryString["gcod"]));
        GridView2.DataBind();
        DataList3.DataBind();
    }





    protected void DataList3_EditCommand(object source, DataListCommandEventArgs e)
    {
        nsfollow.clsgrpmem obj = new nsfollow.clsgrpmem();
        nsfollow.clsgrpmemprp objprp = new nsfollow.clsgrpmemprp();
        objprp.p_grpmemcod = Convert.ToInt32(DataList3.DataKeys[e.Item.ItemIndex]);
        obj.delgrpmem_rec(objprp);
        DataList3.DataBind();
    }

    protected void DataList3_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            LinkButton lk = (LinkButton)(e.Item.FindControl("lk1"));
            if (Panel1.Visible == false)
            {
                lk.Visible = false;
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        nsfollow.clsdoc obj = new nsfollow.clsdoc();
        nsfollow.clsdocprp objprp = new nsfollow.clsdocprp();
        objprp.p_doctit = TextBox2.Text;
        objprp.p_docdsc = TextBox3.Text;
        objprp.p_docgrpcod = Convert.ToInt32(Request.QueryString["gcod"]);
        string s;
        s = FileUpload1.PostedFile.FileName;
        if (s != "")
            s = s.Substring(s.LastIndexOf('.'));
        objprp.p_docdwnfil = s;
        Int32 a = obj.savedoc_rec(objprp);
        if (s != "")
            FileUpload1.PostedFile.SaveAs(Server.MapPath("../docfil") + "//" + a.ToString() + s);
        TextBox2.Text = string.Empty;
        TextBox3.Text = string.Empty;
        GridView1.DataBind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string fn = Server.MapPath("../docfil") + "//" + GridView1.DataKeys[e.NewEditIndex][0] + GridView1.DataKeys[e.NewEditIndex][1];
        FileInfo fi = new FileInfo(fn);
        if (fi.Exists == true)
        {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "Attachment;Filename=" + fi.Name);
            Response.AddHeader("Content-Length", fi.Length.ToString());
            Response.ContentType = "Application/Octet-Stream";
            Response.WriteFile(fi.FullName);
            Response.End();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsfollow.clsemp obj = new nsfollow.clsemp();
        GridView2.DataSource = obj.srcempforgrp(Convert.ToInt32(Session["ccod"]), TextBox1.Text + "%", Convert.ToInt32(Request.QueryString["gcod"]));
        GridView2.DataBind();
    }
}