<%@ Page Title="" Language="C#" MasterPageFile="~/emp/MasterPage.master" AutoEventWireup="true" CodeFile="frmgrp.aspx.cs" Inherits="emp_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="grpbanner">
       <img src="../images/group-icon.jpg" class="grpbannerimg" />
    </div>
    <div class="crtgrp">
        <i></i>
        <asp:LinkButton ID="lkbtn" runat="server" CssClass="lkbtnn">Create New Group</asp:LinkButton>
        
        <asp:ModalPopupExtender ID="lkbtn_ModalPopupExtender" runat="server" DynamicServicePath="" Enabled="True" PopupControlID="Panel1" TargetControlID="lkbtn">
        </asp:ModalPopupExtender>
        
    </div>
    <div class="divgrps">GROUPS</div>
    <div><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="grpcod" DataSourceID="ObjectDataSource2">
                    <Columns>
                        <asp:TemplateField HeaderText="Group Name">
                            <ItemTemplate>
                                <a href="frmgrpdet.aspx?gcod=<%#Eval("grpcod") %>" ><%#Eval("grpnam") %></a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="grpcrtdat" DataFormatString="{0:d}" HeaderText="Created Date" />
                        
                        <asp:BoundField DataField="empnam" HeaderText="Owned By" />
                        <asp:BoundField DataField="nom" HeaderText="No of Emp" />
                        <asp:BoundField DataField="nod" HeaderText="No of Doc" />
                    </Columns>
                    </asp:GridView></div>
    
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="dspgrps" TypeName="nsfollow.clsgrp">
            <SelectParameters>
                <asp:SessionParameter Name="empcod" SessionField="cod" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    <div>
    <asp:Panel ID="Panel1" runat="server">
        <div class="boxgrps">
            <div class="boxgrpslabel">
                <h3>Create New Group</h3>
            </div>
            <div class="boxcontent">
                <table class="boxtable">
                    <tbody>
                        <tr>
                            <th>Group Name</th>
                           <td><asp:TextBox ID="TextBox1" runat="server" Width="288px" ></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBox1"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <th>Group Description</th>
                            <td><asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="288px" ></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator></td>
                            </tr>
                    </tbody>
                </table></div>
            <div class="boxbuttdiv">
                <asp:Button ID="Button1" runat="server" Text="Create" OnClick="Button1_Click" CssClass="boxbutt" />
            &nbsp<asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="boxcan" OnClick="Button2_Click" CausesValidation="false"  />
            </div>
        </div>
        </asp:Panel>
        </div>
    </asp:Content>

