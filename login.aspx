<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server" id="login">
    <div>
        <h2>Login Here!</h2>
    </div>
    <div class="login-form">
                <div class="left-part">
            <label>Email Id</label>
              <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Your Email"></asp:TextBox>
               &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>     </div>
        <div class="right-part">
            <label>Password</label>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Your Password" TextMode="Password" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;</div>
        <div class="clearfix"></div>
          <asp:Button ID="Button1" CssClass="indexbutton" runat="server" Text="Login" OnClick="Button1_Click" />
    <div class="clearfix"></div>
         <div>
            <asp:Label ID="Label1" CssClass="indexlabel" runat="server"></asp:Label>
        </div>   
    </div>
        <div>
           
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Valid Email Address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
            
            <br />
           
        </div>
        </form>
</asp:Content>

