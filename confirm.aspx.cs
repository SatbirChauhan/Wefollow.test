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
        if (Session["pcod"] != null)
        {
            nsfollow.clscmppln obj = new nsfollow.clscmppln();
            nsfollow.clscmpplnprp objprp = new nsfollow.clscmpplnprp();
            objprp.p_cmpplncmpcod = Convert.ToInt32(Session["ccod"]);
            objprp.p_cmpplndat = DateTime.Now;
            objprp.p_cmpplnplncod = Convert.ToInt32(Session["pcod"]);
            obj.savecmppln_rec(objprp);
            Session["pcod"] = null;
            Session["amt"] = null;
            string s="Plan has been purchased successfully"+ "<a href=frmemp.aspx >Click here to continue usage</a>";
            Literal1.Text = s;
            
        }
    }
}