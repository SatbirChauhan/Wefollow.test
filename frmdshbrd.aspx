<%@ Page Title="" Language="C#" MasterPageFile="~/emp/MasterPage.master" AutoEventWireup="true" CodeFile="frmdshbrd.aspx.cs" Inherits="emp_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <div class="empstatusdiv">
       <div class="statusicon">
           <span><i></i>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Update Status</span>
       </div>
       <div class="writestatus">
           <asp:TextBox ID="TextBox1" runat="server" CssClass="innerwrap" placeholder="Whats In Your Mind?" TextMode="MultiLine"></asp:TextBox>
       &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator></div>
   </div>
    <div class="divbutt">
    <div class="innerbuttup">
    </div>&nbsp;&nbsp;&nbsp;
    <asp:FileUpload ID="FileUpload1" runat="server" Height="20px" CssClass="stsfileupl" />
    <div class="postdiv">
        <asp:Button ID="Button1" CssClass="postbutt" runat="server" OnClick="Button1_Click" Text="Post" />
    </div>
        </div>
       
    <div class="strtdiv">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" DataKeyNames="updcod,updempcod" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <table class="empstatusdiv">
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>Posted: <asp:Label ID="Label1" runat="server" Text='<%#gettxt(Convert.ToDateTime(Eval("upddat")))%>'></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2"><%#Eval("upddsc") %></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>Posted By: <%#Eval("empnam") %>(<%#Eval("empjobtit") %>)</td>
                                        <td><%#getsrc(Convert.ToInt32(Eval("updcod")),Convert.ToString(Eval("updfil")))%><asp:LinkButton ID="lkbtn" runat="server" CausesValidation="false" Text="delete" CssClass="lkbtnn" CommandName="delete"></asp:LinkButton></td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>

                </asp:GridView>
             <br />
             
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="dspupd" TypeName="nsfollow.clsupd">
                    <SelectParameters>
                        <asp:SessionParameter Name="empcod" SessionField="cod" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
    </div>
</asp:Content>

