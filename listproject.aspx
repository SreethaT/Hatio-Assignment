<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="listproject.aspx.cs" Inherits="Todo.listproject" %>
<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <table style="width: 98%; font-family: 'Times New Roman', Times, serif; font-size: large; color: #000000;">
    <tr>
        <td style="height: 35px; width: 393px; text-align: right;">
            Select Project:</td>
        <td style="height: 35px">
            <asp:DropDownList ID="ddltype" runat="server" 
                style="font-family: 'Times New Roman', Times, serif; font-size: large" 
                AutoPostBack="True" onselectedindexchanged="ddltype_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="height: 32px; width: 393px; text-align: right;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Title:</td>
        <td style="height: 32px">
            <asp:TextBox ID="txttitle" runat="server" style="font-size: large" 
                ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="height: 36px; width: 393px; text-align: right">
            Created Date:</td>
        <td style="height: 36px">
            <asp:TextBox ID="txtdate" runat="server" style="font-size: large" 
                ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 393px; text-align: right; height: 40px;">
            Todo:</td>
        <td style="height: 40px">
            <asp:DropDownList ID="ddltodo" runat="server" AutoPostBack="True" 
                onselectedindexchanged="ddltodo_SelectedIndexChanged" 
                style="font-family: 'Times New Roman', Times, serif; font-size: large">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="text-align: right" colspan="2">
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                <div style="text-align: justify; height: 35px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Add new Todo
                    <asp:TextBox ID="txtadd" runat="server" style="font-size: large"></asp:TextBox>
                </div>
            </asp:Panel>
        </td>
    </tr>
   
    <tr>
        <td style="text-align: right">
            Description:</td>
        <td style="text-align: left">
                    <asp:TextBox ID="txtdes" runat="server" style="font-size: large"></asp:TextBox>
        </td>
    </tr>
   
    <tr>
        <td style="text-align: right; height: 26px;">
            Status</td>
        <td style="height: 26px;">
                            <asp:CheckBox ID="ch1" runat="server" Text="Completed" />
        </td>
    </tr>
   
    <tr>
        <td style="text-align: right; height: 31px;">
            Updated Date:</td>
        <td style="text-align: left; height: 31px;">
                    <asp:TextBox ID="txtupdate" runat="server" style="font-size: large"></asp:TextBox>
        </td>
    </tr>
   
    <tr>
        <td style="text-align: right">
            &nbsp;</td>
        <td style="text-align: right">
            &nbsp;</td>
    </tr>
   
    <tr>
        <td style="text-align: right">
            &nbsp;</td>
        <td style="text-align: right">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="height: 21px; width: 393px">
            &nbsp;</td>
        <td style="height: 21px">
            <asp:Button ID="btnadd" runat="server" 
                style="font-size: large; font-family: 'Times New Roman', Times, serif" 
                Text="Add new Todo" onclick="btnadd_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnupdate" runat="server" 
                style="font-family: 'Times New Roman', Times, serif; font-size: large" 
                Text="Click here to Edit" onclick="btnupdate_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btndlt" runat="server" onclick="btn_Click" 
                style="font-family: 'Times New Roman', Times, serif; font-size: large" 
                Text="Delete" />
        </td>
    </tr>
    <tr>
        <td style="width: 393px; height: 41px;">
            </td>
        <td style="height: 41px">
            <asp:Button ID="btnsave" runat="server" 
                style="font-family: 'Times New Roman', Times, serif; font-size: large" 
                Text="Save changes" onclick="btnsave_Click" />
        </td>
    </tr>
    <tr>
        <td style="width: 393px; height: 39px;">
            </td>
        <td style="height: 39px">
            <asp:Button ID="btn" runat="server" onclick="btn_Click" 
                style="font-family: 'Times New Roman', Times, serif; font-size: large" 
                Text="Home" />
        </td>
    </tr>
    <tr>
        <td style="width: 393px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 393px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

