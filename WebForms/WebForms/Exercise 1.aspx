<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercise 1.aspx.cs" Inherits="WebForms.Exercise_1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h3 style="font-family: Arimo; color: #00FFFF;">Thomas E. Herman Jr.'s Hometown</h3>
            <p style="font-family: 'Bodoni MT'; font-size: large; color: #FFFFFF">Sarasota, FL is a wonderful place full of fascinating people, beautiful beaches, and plenty of sunshine.</p>
            <p>
                <asp:Button ID="btnDetails" runat="server" OnClick="btnDetails_Click" Text="Details" CssClass="btn-info" />
            </p>
        </div>
        <asp:Label ID="lblDetails" runat="server" BackColor="#66FFFF" CssClass="alert-success"></asp:Label>
        <br />
</asp:Content>
