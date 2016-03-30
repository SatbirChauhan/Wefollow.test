<%@ Page Title="" Language="C#" MasterPageFile="~/company/MasterPage.master" AutoEventWireup="true" CodeFile="frmren.aspx.cs" Inherits="company_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div class="content-left">
    <div>
                    <h3>
        Purchase Plan for continue to use of Website
    </h3>
         
                    </div>
       <div class="plncls">
           <table>
               <tr>
                   <td class="plnclstd">
                       Select Plan
                   </td>
                   <td><asp:DropDownList CssClass="plnclsddl" ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="p_plnnam" DataValueField="p_plncod"></asp:DropDownList></td>
               </tr>
               <tr>
                   <td class="plnclstd"></td>
                   <td><asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="288px" AutoGenerateRows="False" DataKeyNames="p_plnprc" DataSourceID="ObjectDataSource2">
                <Fields>
                    
                    <asp:BoundField DataField="p_plnnam" HeaderText="Plan Name" SortExpression="p_plnnam" />
                    <asp:BoundField DataField="p_plndsc" HeaderText="Plan Description" SortExpression="p_plndsc" />
                    <asp:BoundField DataField="p_plnnoe" HeaderText="No of Employee" SortExpression="p_plnnoe" />
                    <asp:BoundField DataField="p_plnprc" HeaderText="Cost of Plan" SortExpression="p_plnprc" />
                </Fields>
            </asp:DetailsView></td>
               </tr>
               <tr>
                   <td class="plnclstd"></td>
                   <td><asp:Button ID="Button1" runat="server" CssClass="plnbutt" Text="Pay Now" OnClick="Button1_Click" />
                       
                       <asp:Button ID="Button2" runat="server" CssClass="plnbutt" Text="cancel" CausesValidation="false" OnClick="Button2_Click" />
                   </td>
               </tr>
           </table>
           <div><asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disppln_rec" TypeName="nsfollow.clspln"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="findpln_rec" TypeName="nsfollow.clspln">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="plncod" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource></div>

       </div>
    </div>
    
</asp:Content>

