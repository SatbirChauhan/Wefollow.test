using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Collections;

public partial class company_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        nsfollow.clscmppln obj = new nsfollow.clscmppln();
        Int32 a = obj.chkpln(Convert.ToInt32(Session["ccod"]));
        if (a <=0)
            Response.Redirect("frmren.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            nsfollow.clsusr obj = new nsfollow.clsusr();
            nsfollow.clsusrprp objprp = new nsfollow.clsusrprp();
            objprp.p_usreml = TextBox2.Text;
            objprp.p_usrrol = 'E';
            objprp.p_usrcrtdat = DateTime.Now;
            objprp.p_usrcmpcod = Convert.ToInt32(Session["ccod"]);
            string s = Guid.NewGuid().ToString();
            s = s.Substring(0, 8);
            objprp.p_usrpwd = s;
            Int32 a = obj.saveusr_rec(objprp);
            nsfollow.clsemp obj1 = new nsfollow.clsemp();
            nsfollow.clsempprp objprp1 = new nsfollow.clsempprp();
            string nam = TextBox1.Text;
            nam = nam.Substring(0, 1).ToUpper() + nam.Substring(1).ToLower();
            objprp1.p_empnam = nam;
            objprp1.p_empjobtit = TextBox3.Text;
            objprp1.p_empusrcod = a;
            string pic = FileUpload1.PostedFile.FileName;
            if (pic != "")
                pic = pic.Substring(pic.LastIndexOf('.'));
            objprp1.p_emppic = pic;
            obj1.saveemp_rec(objprp1);
            if (pic != "")
                FileUpload1.PostedFile.SaveAs(Server.MapPath("../emppics") + "//" + a.ToString() + pic);
            MailMessage mm = new MailMessage("satbirchauhann@gmail.com", TextBox2.Text, "Password Information", "Your password is " + s+ " click to return  http://localhost:59623/login.aspx");
            SmtpClient c = new SmtpClient("smtp.gmail.com", 587);
            c.Credentials = new System.Net.NetworkCredential("satbirchauhann@gmail.com", "Rockkst@rrRaj8");
            c.EnableSsl = true;
            //c.Send(mm);
            Response.Redirect("frmemp.aspx");
        }
        catch (Exception exp)
        {
            Label1.Text = "email id already exist";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}