<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="viewproject.aspx.cs" Inherits="Todo.viewproject" %>
<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <table style="width: 100%; font-family: 'Times New Roman', Times, serif; font-size: large; color: #000000">
        <tr>
            <td style="width: 187px; text-align: center">
                PROJECT1</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 187px; text-align: right">
                <b>Summary :</b></td>
            <td>
                <asp:Label ID="lbltodo" runat="server"></asp:Label>
                /<asp:Label ID="lbltotal" runat="server"></asp:Label>
            &nbsp;Todo Completed</td>
        </tr>
        <tr>
            <td style="width: 187px">
                <b>Pending</b></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 187px">
                <asp:CheckBoxList ID="check" runat="server">
                </asp:CheckBoxList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 187px">
                <b>Completed</b></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 187px">
                <asp:CheckBoxList ID="check1" runat="server" >
                    <asp:ListItem ></asp:ListItem>
                     <asp:ListItem ></asp:ListItem>
                     <asp:ListItem ></asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 21px; width: 187px">
            </td>
            <td style="height: 21px">
            </td>
        </tr>
        <tr>
            <td style="width: 187px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 187px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 187px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

