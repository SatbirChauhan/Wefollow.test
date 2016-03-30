using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        nsfollow.clsusr obj = new nsfollow.clsusr();
        Char rol;
        Int32 cmpcod, empcod,ucod;
        rol = obj.logincheck(TextBox1.Text, TextBox2.Text, out cmpcod, out empcod,out ucod);
        if (rol == 'N')
        {
            Label1.Text = "Email/Password Wrong";
        }
        else {
            FormsAuthenticationTicket tk = new FormsAuthenticationTicket(1, TextBox1.Text, DateTime.Now, DateTime.Now.AddHours(2), false, rol.ToString());
            string s = FormsAuthentication.Encrypt(tk);
            HttpCookie ck = new HttpCookie(FormsAuthentication.FormsCookieName, s);
            Response.Cookies.Add(ck);
         if (rol == 'A')
        {
                Session["usrcod"] = ucod;
            Response.Redirect("admin/frmpln.aspx");
        }
        else if (rol == 'C')
        {
            Session["ccod"] = cmpcod;
                Session["usrcod"] = ucod;
            Response.Redirect("company/frmemp.aspx");
        }
        else
        {
            Session["ccod"] = cmpcod;
            Session["cod"] = empcod;
            Response.Redirect("emp/frmdshbrd.aspx");
        }
        }
    }
}