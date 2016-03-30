<%@ Page Title="" Language="C#" MasterPageFile="~/company/MasterPage2.master" AutoEventWireup="true" CodeFile="frmemp.aspx.cs" Inherits="company_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<form action="frmemp.aspx" runat="server" id="empform">--%>
    <%--<div class="login-form">--%>
        <div>
            <h3>Search Employees</h3>
            </div>
    <br />
            <div class="full_view">
                <div class="left_side">
               <asp:DataList ID="DataList1" runat="server" RepeatColumns="26" RepeatDirection="Horizontal" OnEditCommand="DataList1_EditCommand">
        <ItemTemplate>
<asp:LinkButton ID="lk1" runat="server" CommandName="Edit"
    Text='<%#Container.DataItem %>'
     CommandArgument="<%#Container.DataItem %>" />
        </ItemTemplate>
            <SeparatorTemplate>
                | 
            </SeparatorTemplate>
        </asp:DataList>
                </div>
            </div>
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="empcod">
              <Columns>
                  <asp:TemplateField HeaderText="Search Results">
                      <ItemTemplate>
                          <table class="">
                              <tr>
                                  <td rowspan="5"><img src="../emppics/<%#Eval("empusrcod") %><%#Eval("emppic") %>" class="manpic" /></td>
                                  <td><h3 class="personname">Name:&nbsp;&nbsp;<%#Eval("empnam") %></h3></td>
                              </tr>
                              <tr>
                                  <td><b>Designation:<i><%#Eval("empjobtit") %></i></b></td>
                              </tr>
                              <tr>
                                  <td>Email:&nbsp;&nbsp;&nbsp;&nbsp;<%#Eval("usreml") %></td>
                              </tr>
                              <tr>
                                  <td>Create Date:&nbsp;&nbsp;<%#Eval("usrcrtdat","{0:d}") %></td>
                              </tr>
                              <tr>
                                  <td><asp:LinkButton ID="lk" runat="server" CssClass="empgvlk" Text="remove" CommandName="delete"></asp:LinkButton></td>
                              </tr>
                          </table>
                      </ItemTemplate>
                  </asp:TemplateField>
              </Columns>
                    
                   
                </asp:GridView>
        
        <br />
        
        <div><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Add New Employees</asp:LinkButton> </div>
      
   <%-- </div>--%>
        <%--</form>--%>
</asp:Content>

