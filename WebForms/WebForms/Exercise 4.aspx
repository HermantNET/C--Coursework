<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercise 4.aspx.cs" Inherits="WebForms.Exercise_4" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div style="color: #FFFFFF; font-weight: bold;" class="col-md-4 col-md-offset-4">

            <br />

            Number 1<br />
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            <br />
            Number 2<br />
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" Width="65px" OnClick="Add" />
            <asp:Button ID="btnSubtract" runat="server" Text="Subtract" OnClick="btnSubtract_Click" Width="65px" />
            <br />
            <asp:Button ID="btnDivide" runat="server" Text="Divide" OnClick="btnDivide_Click" Width="65px" />
            <asp:Button ID="btnModulus" runat="server" Text="Modulus" OnClick="btnModulus_Click" Width="65px" />

            <br />
            <br />
            <asp:Label ID="lblRes" runat="server" CssClass="alert-success" Text="Result" Font-Bold="True" Font-Size="Larger"></asp:Label>

        </div>
    </div>
</asp:Content>
