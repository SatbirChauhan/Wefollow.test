using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //to store data to tbcmp
        nsfollow.clscmp obj = new nsfollow.clscmp();
        nsfollow.clscmpprp objprp = new nsfollow.clscmpprp();
        objprp.p_cmpnam = TextBox1.Text;
        objprp.p_cmpcat = DropDownList1.SelectedItem.Text;
        objprp.p_cmpurl = TextBox3.Text;
        objprp.p_cmpdsc = TextBox5.Text;
        string s = FileUpload1.PostedFile.FileName;
        if (s != "")
            s = s.Substring(s.LastIndexOf('.'));
        objprp.p_cmplog = s;
        Int32 a = obj.savecmp_rec(objprp);
        if (s != "")
            FileUpload1.PostedFile.SaveAs(Server.MapPath("cmppics") + "//" + a.ToString() + s);
        //to store data to tbusr
        nsfollow.clsusr obj1 = new nsfollow.clsusr();
        nsfollow.clsusrprp objprp1 = new nsfollow.clsusrprp();
        objprp1.p_usrcmpcod = a;
        objprp1.p_usrcrtdat = DateTime.Now;
        objprp1.p_usreml = TextBox4.Text;
        objprp1.p_usrrol = 'C';
        string pwd = Guid.NewGuid().ToString();
        pwd = pwd.Substring(0, 8);
        objprp1.p_usrpwd = pwd;
        obj1.saveusr_rec(objprp1);
        //to send email
        MailMessage mm = new MailMessage("satbirchauhann@gmail.com", TextBox4.Text, "Password Information", "Your Password is " + pwd+ " click to return  http://localhost:59623/login.aspx");
        SmtpClient c = new SmtpClient("smtp.gmail.com",587);
        c.Credentials = new System.Net.NetworkCredential("satbirchauhann@gmail.com", "Rockkst@rrRaj8");
        c.EnableSsl = true;
       
         //c.Send(mm);
        TextBox1.Text = String.Empty;
        TextBox3.Text = String.Empty;
        TextBox4.Text = String.Empty;
        TextBox5.Text = String.Empty;
        Label1.Text = "Your Password has been send to mail";
    }
    
}