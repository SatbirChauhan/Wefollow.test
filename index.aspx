<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <div class="login-form">
          <div class="left-part">
            <label>Company Name </label>
             <asp:TextBox ID="TextBox1" runat="server" placeholder="Fill Company Name"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
          </div>
          <div class="right-part">
            <label>Category</label>
              <asp:DropDownList ID="DropDownList1" CssClass="dropdown" runat="server" >
                  <asp:ListItem>Software</asp:ListItem>
                  <asp:ListItem>Finance</asp:ListItem>
                  <asp:ListItem>Hardware Manufacturer</asp:ListItem>
                  <asp:ListItem>Textile</asp:ListItem>
                  <asp:ListItem>Electronics</asp:ListItem>
              </asp:DropDownList>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="DropDownList1" ForeColor="Red"></asp:RequiredFieldValidator></div>
          <div class="clearfix"></div>
          <div class="left-part">
            <label>Url</label>
              <asp:TextBox ID="TextBox3" runat="server" placeholder="Fill Url"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator></div>
          <div class="right-part">
            <label>Email</label>
              <asp:TextBox ID="TextBox4" runat="server" placeholder="Fill Email"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator></div>
          <div class="clearfix"></div>
          <div class="left-part">
            <label>Description</label><asp:TextBox ID="TextBox5" CssClass="descip" runat="server" placeholder="Fill Description" TextMode="MultiLine"></asp:TextBox>
              
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="TextBox5" ForeColor="Red"></asp:RequiredFieldValidator></div>
          <div class="right-part">
            <label>Logo</label>
              <asp:FileUpload ID="FileUpload1" CssClass="fileupload" runat="server" />
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ControlToValidate="FileUpload1" ForeColor="Red"></asp:RequiredFieldValidator></div>
          <div class="clearfix"></div>
          <asp:Button ID="Button1" CssClass="indexbutton" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
&nbsp;</div>
        <div>
            <asp:Label ID="Label1" CssClass="indexlabel" runat="server"></asp:Label>
            
        </div>
        <div>

            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Email is not valid" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

        </div>
</form>
</asp:Content>

