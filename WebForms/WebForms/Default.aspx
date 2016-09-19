<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-4 col-md-offset-4">
            <h2>Exercises</h2>
            <a runat="server" href="~/Exercise 1" class="btn btn-default">Exercise 1</a>
            <a runat="server" href="~/Exercise 3" class="btn btn-default">Exercise 3</a>
            <a runat="server" href="~/Exercise 4" class="btn btn-default">Exercise 4</a>
            <a runat="server" href="~/Exercise 7" class="btn btn-default">Exercise 7</a>
            <a runat="server" href="~/Exercise 8" class="btn btn-default">Exercise 8</a>
        </div>
    </div>

</asp:Content>
