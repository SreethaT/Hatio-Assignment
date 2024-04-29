<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Todo.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <table style="width: 100%; font-family: 'Times New Roman', Times, serif; font-size: large">
        <tr>
            <td style="width: 434px; text-align: center">
                Login Here</td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 434px; font-family: 'Times New Roman', Times, serif; font-size: large; text-align: right">
                Username:</td>
            <td>
                <asp:TextBox ID="txtuser" runat="server" style="font-size: large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 434px; font-family: 'Times New Roman', Times, serif; font-size: large; text-align: right">
                Password:</td>
            <td>
                <asp:TextBox ID="txtpwd" runat="server" style="font-size: large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 434px">
                &nbsp;</td>
            <td>
                <asp:Button ID="btn" runat="server" 
                    style="font-size: large; font-family: 'Times New Roman', Times, serif" 
                    Text="Login" onclick="btn_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 434px; height: 24px">
            </td>
            <td style="height: 24px">
            </td>
        </tr>
        <tr>
            <td style="width: 434px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 434px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
