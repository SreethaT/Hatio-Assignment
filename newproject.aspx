<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="newproject.aspx.cs" Inherits="Todo.newproject" %>
<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <table style="width: 100%; font-size: large; color: #000000;">
        <tr style="font-family: 'Times New Roman', Times, serif; font-size: large">
            <td style="width: 310px">
                Create your Project</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 310px; text-align: right; font-family: 'Times New Roman', Times, serif; font-size: large; height: 37px;">
                Title:</td>
            <td style="height: 37px">
                <asp:TextBox ID="txttitle" runat="server" 
                    style="font-family: 'Times New Roman', Times, serif; font-size: large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 310px; text-align: right; font-family: 'Times New Roman', Times, serif; font-size: large; height: 59px;">
                Created
                Date:</td>
            <td style="height: 59px">
                <asp:TextBox ID="txtdate" runat="server" 
                    style="font-family: 'Times New Roman', Times, serif; font-size: large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 310px; text-align: right; font-family: 'Times New Roman', Times, serif; font-size: large; height: 5px;">
                Todo</td>
            <td style="height: 5px">
                <asp:TextBox ID="txtdo" runat="server" 
                    style="font-family: 'Times New Roman', Times, serif; font-size: large"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr style="font-family: 'Times New Roman', Times, serif; font-size: large">
            <td style="width: 310px; height: 29px; text-align: right;">
                Desription:</td>
            <td style="height: 29px">
                <asp:TextBox ID="txtdes" runat="server" 
                    style="font-family: 'Times New Roman', Times, serif; font-size: large" 
                    TextMode="MultiLine"></asp:TextBox>
            &nbsp;&nbsp;
            </td>
        </tr>
        <tr style="font-family: 'Times New Roman', Times, serif; font-size: large">
            <td style="width: 310px; text-align: right;">
                Updated&nbsp; Date:</td>
            <td>
                <asp:TextBox ID="txtupdate" runat="server" 
                    style="font-family: 'Times New Roman', Times, serif; font-size: large"></asp:TextBox>
                </td>
        </tr>
        <tr style="font-family: 'Times New Roman', Times, serif; font-size: large">
            <td style="width: 310px">
                &nbsp;</td>
            <td>
                <asp:Button ID="btn" runat="server" onclick="btn_Click" 
                    style="font-size: large; font-family: 'Times New Roman', Times, serif" 
                    Text="Save" />
            </td>
        </tr>
        <tr style="font-family: 'Times New Roman', Times, serif; font-size: large">
            <td style="width: 310px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr style="font-family: 'Times New Roman', Times, serif; font-size: large">
            <td style="width: 310px">
                &nbsp;</td>
            <td>
                <asp:Button ID="btn1" runat="server" onclick="btn1_Click" 
                    style="font-family: 'Times New Roman', Times, serif; font-size: large" 
                    Text="Home" />
            </td>
        </tr>
        <tr style="font-family: 'Times New Roman', Times, serif; font-size: large">
            <td style="width: 310px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

