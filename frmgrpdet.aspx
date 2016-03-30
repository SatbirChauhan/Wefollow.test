<%@ Page Title="" Language="C#" MasterPageFile="~/emp/MasterPage.master" AutoEventWireup="true" CodeFile="frmgrpdet.aspx.cs" Inherits="emp_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:DataList ID="DataList2" runat="server" DataSourceID="ObjectDataSource2">
            <ItemTemplate>
              
                Name of Group:
                <b><%#Eval("p_grpnam") %></b>
                <br />
                Group Description:
                <b><%#Eval("p_grpdsc") %></b>
                <br />
                Date Group Created:
                <b><%#Eval("p_grpcrtdat","{0:d}") %></b>
                <br />
                
<br />
            </ItemTemplate>
        </asp:DataList>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="findgrp_rec" TypeName="nsfollow.clsgrp">
            <SelectParameters>
                <asp:QueryStringParameter Name="grpcod" QueryStringField="gcod" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    <asp:Panel ID="Panel1" runat="server">
        <div class="search">
            Search Employees
            <asp:TextBox ID="TextBox1" runat="server" CssClass="searchtxt"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" CssClass="searchbutt" OnClick="Button1_Click" />
        </div>
        <div>
             <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="empcod" OnRowEditing="GridView2_RowEditing1">
                <Columns>
                    <asp:BoundField DataField="empnam" HeaderText="Emp Name" />
                    <asp:BoundField DataField="empjobtit" HeaderText="Job Title" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lkb" runat="server" CommandName="edit" Text="Add to Group" CssClass="lkbtnn"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        </asp:Panel>
    
    <div class="strtdivgrpdet">
        <div>
        <asp:DataList ID="DataList3" runat="server" DataSourceID="ObjectDataSource3" RepeatDirection="Horizontal" DataKeyField="grpmemcod" OnEditCommand="DataList3_EditCommand" OnItemDataBound="DataList3_ItemDataBound">
            <ItemTemplate>
                <table class="wrapper">
                    <tr>
                    <td>
                        <center>
        <img src="../emppics/<%#Eval("empcod") %><%#Eval("emppic") %>" height ="120px" width ="120px" border="1" /><br />
                            <b><%#Eval("empnam") %></b><br />
                            <i><%#Eval("empjobtit") %></i><br />
                            <asp:LinkButton ID="lk1" CommandName="edit" Text="remove form group" runat="server" CausesValidation="false"></asp:LinkButton>
                    
                        </center>

                    </td>
                        <td>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
            
        </asp:DataList>
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="dspgrpmem" TypeName="nsfollow.clsgrpmem">
            <SelectParameters>
                <asp:QueryStringParameter Name="grpcod" QueryStringField="gcod" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
            </div>
        <div class="divupddoc">
            <asp:Panel ID="Panel2" runat="server">
            Upload New Document<br />
            Title:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            Description:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            Downloadable: <asp:FileUpload ID="FileUpload1" runat="server" /><br />
            <asp:Button ID="Button2" runat="server" Text="Upload" OnClick="Button2_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Cancel" CausesValidation="false" />
        </asp:Panel>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource4" DataKeyNames="p_doccod,p_docdwnfil" OnRowEditing="GridView1_RowEditing">
            <Columns>
                <asp:TemplateField HeaderText="Document">
                    <ItemTemplate>
                        <table class="wrapper">
                            <tr>
                                <td><%#Eval("p_doctit") %></td>
                            </tr>
                            <tr>
                                <td><%#Eval("p_docdsc") %></td>
                            </tr>
                           
                            <tr>
                                <td>
                                    <asp:LinkButton ID="LinkButton1" CommandName="edit" CausesValidation="false" runat="server">Download</asp:LinkButton></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            
        </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="dispdoc_rec" TypeName="nsfollow.clsdoc">
            <SelectParameters>
                <asp:QueryStringParameter Name="grpcod" QueryStringField="gcod" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        </div>
    </div>
</asp:Content>

