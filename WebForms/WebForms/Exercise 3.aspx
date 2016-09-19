<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Exercise 3.aspx.cs" Inherits="WebForms.Exercise_3" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="color: #FFFFFF; font-weight: bold">

        <br />
        <asp:ListBox ID="lstStuff" runat="server" Width="282px"></asp:ListBox>
        <asp:Panel ID="Panel1" runat="server" Height="33px" Width="284px">
            <asp:TextBox ID="txtThing" runat="server" Width="160px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn-primary" OnClick="btnAdd_Click" />
            <asp:Button ID="Button1" runat="server" CssClass="btn-success" OnClick="Button1_Click" Text="Select" />
        </asp:Panel>
        You selected:<br />
        <asp:Label ID="Label1" runat="server" CssClass="alert-info" Text="Selected Item"></asp:Label>

    </div>
</asp:Content>
