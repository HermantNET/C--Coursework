<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Exercise 7.aspx.cs" Inherits="WebForms.Exercise_7" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; color: #00FFFF">
    
        <br />
        First Name:<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Last Name:<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <table style="width:100%;">
            <tr>
                <td style="width: 98px">
                    <asp:CheckBox ID="chkS" runat="server" OnCheckedChanged="chkS_CheckedChanged" Text="Small" />
                </td>
                <td style="width: 1157px">
                    <asp:TextBox ID="txtS" runat="server" Height="20px" Width="60px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 98px">
                    <asp:CheckBox ID="chkM" runat="server" OnCheckedChanged="chkM_CheckedChanged" Text="Medium" />
                </td>
                <td style="width: 1157px">
                    <asp:TextBox ID="txtM" runat="server" Height="20px" Width="60px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 98px">
                    <asp:CheckBox ID="chkL" runat="server" OnCheckedChanged="chkL_CheckedChanged" Text="Large" />
                </td>
                <td style="width: 1157px">
                    <asp:TextBox ID="txtL" runat="server" Height="20px" Width="60px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 98px">
                    <asp:CheckBox ID="chkXL" runat="server" OnCheckedChanged="chkXL_CheckedChanged" Text="XLarge" />
                </td>
                <td style="width: 1157px">
                    <asp:TextBox ID="txtXL" runat="server" Height="20px" Width="60px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 98px">
                    <asp:CheckBox ID="chkXXL" runat="server" OnCheckedChanged="chkXXL_CheckedChanged" Text="XXLarge" />
                </td>
                <td style="width: 1157px">
                    <asp:TextBox ID="txtXXL" runat="server" Height="20px" Width="60px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblCost" runat="server" Text="Cost"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnCalcCost" runat="server" OnClick="btnCalcCost_Click" Text="Calculate" />
    
    </div>
</asp:Content>