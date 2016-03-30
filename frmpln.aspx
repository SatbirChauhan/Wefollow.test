<%@ Page Title="Plan" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmpln.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
         <div class="login-form">
             <div class="plan">
                 <h2>add plans</h2>
             </div>
               <div class="left-part">
            <label class="planlabel">Plan Name</label>
<asp:TextBox ID="txtplnnam" runat="server" placeholder="Enter Plan Name"></asp:TextBox>
                 &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="txtplnnam"></asp:RequiredFieldValidator></div>
             <div class="right-part">
                 <label class="planlabel">
                 No. of Employees</label>
                 <asp:TextBox ID="txtplnnoe" runat="server" placeholder="Enter No of Employees"></asp:TextBox>
                 &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="txtplnnoe"></asp:RequiredFieldValidator></div>
          <div class="clearfix"></div>
               <div class="left-part">
            <label class="planlabel">Plan Cost</label>
<asp:TextBox ID="txtplncst" runat="server" placeholder="Enter Cost of Plan"></asp:TextBox>
                 &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="txtplncst"></asp:RequiredFieldValidator></div>
             <div class="right-part">
                 <label class="planlabel">
                 Plan Description</label>
                 <asp:TextBox ID="txtplndsc" CssClass="multi" runat="server" placeholder="Enter Description of Plan" TextMode="MultiLine"></asp:TextBox>
                 &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="txtplndsc"></asp:RequiredFieldValidator></div>
          <div class="clearfix"></div>
        

             </div>
        <div>  <asp:Button ID="Button1" CssClass="plnbutton" runat="server" Text="Submit " OnClick="Button1_Click" />
          <asp:Button ID="Button2" CssClass="plnbutton" runat="server" Text="Cancel" OnClick="Button2_Click" CausesValidation="false" /></div>
        <div class="plndetail">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" DataKeyNames="p_plncod">
                <Columns>
                    <asp:BoundField DataField="p_plnnam" HeaderText="Plan Name " SortExpression=" p_plnnam" />
                    <asp:BoundField DataField="p_plndsc" HeaderText="Plan Description " SortExpression="p_plndsc" />
                    <asp:BoundField DataField="p_plnnoe" HeaderText="Plan No of Employees " SortExpression="p_plnnoe" />
                    <asp:BoundField DataField="p_plnprc" HeaderText="Plan Cost " SortExpression="p_plnprc" />
                    <asp:CommandField ShowEditButton="True" EditText="Edit" CausesValidation="false" ControlStyle-CssClass="lkbtnn" />
                    <asp:CommandField ShowDeleteButton="True" CausesValidation="false" ControlStyle-CssClass="lkbtnn" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disppln_rec" TypeName="nsfollow.clspln"></asp:ObjectDataSource>
         </div>
</asp:Content>
