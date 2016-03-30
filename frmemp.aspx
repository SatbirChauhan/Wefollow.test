<%@ Page Title="" Language="C#" MasterPageFile="~/emp/MasterPage.master" AutoEventWireup="true" CodeFile="frmemp.aspx.cs" Inherits="company_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<form action="frmemp.aspx" runat="server" id="empform">--%>
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
    <div class="strtdivgrpdet">
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="empcod,sts" OnRowDataBound="GridView1_RowDataBound">
              <Columns>
                  <asp:TemplateField HeaderText="Search Results">
                      <ItemTemplate>
                          <table class="wrapper">
                              <tr>
                                  <td rowspan="5"><img src="../emppics/<%#Eval("empusrcod") %><%#Eval("emppic") %>" height="150" width="100" /></td>
                                  <td><h3><%#Eval("empnam") %></h3></td>
                              </tr>
                              <tr>
                                  <td><b><i><%#Eval("empjobtit") %></i></b></td>
                              </tr>
                              <tr>
                                  <td><%#Eval("usreml") %></td>
                              </tr>
                              <tr>
                                  <td><%#Eval("usrcrtdat","{0,1}") %></td>
                              </tr>
                              <tr>
                                  <td><asp:LinkButton ID="lk" runat="server" CssClass="empgvlk" CommandName="delete"></asp:LinkButton></td>
                              </tr>
                          </table>
                      </ItemTemplate>
                  </asp:TemplateField>
              </Columns>
                    
                   
                </asp:GridView>
        
        <br />
        
        <div> </div>
        
    </div>
        <%--</form>--%>
</asp:Content>

