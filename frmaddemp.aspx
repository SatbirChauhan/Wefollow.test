<%@ Page Title="" Language="C#" MasterPageFile="~/company/MasterPage2.master" AutoEventWireup="true" CodeFile="frmaddemp.aspx.cs" Inherits="company_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<form action="frmaddemp.aspx" runat="server" id="addform">--%>
        <div class="login-form">
                <div class="left-part">
            <label class="planlabel">Name of Employee</label>
              <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Name"></asp:TextBox>
                 &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator></div>
             <div class="right-part">
                 <label class="planlabel">
                 Email</label>
                           <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Email" ></asp:TextBox>
                 &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator></div>
          <div class="clearfix"></div>
               <div class="left-part">
            <label class="planlabel">Browse Picture</label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
                 &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="FileUpload1"></asp:RequiredFieldValidator></div>
             <div class="right-part">
                 <label class="planlabel">
                 Job Title</label>
                             <asp:TextBox ID="TextBox3" runat="server" placeholder="Enter Job Title" ></asp:TextBox>
                 &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBox3"></asp:RequiredFieldValidator></div>
          <div class="clearfix"></div>
        
            <asp:Button ID="Button1" CssClass="indexbutton" runat="server" Text="Submit" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" CssClass="indexbutton" Text="Cancel" OnClick="Button2_Click" CausesValidation="false" />
         <div>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div> 
             </div>
        
        <%--</form>--%>
</asp:Content>

