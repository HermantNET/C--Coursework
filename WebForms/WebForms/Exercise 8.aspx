<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercise 8.aspx.cs" Inherits="WebForms.Exercise_8" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="font-family: Candara; color: #00FFFF">
    
        <br />
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AutoGenerateEditButton="True" DataKeyNames="major_ID">
            <Columns>
                <asp:BoundField DataField="major_ID" HeaderText="major_ID" SortExpression="major_ID" InsertVisible="False" ReadOnly="True" Visible="False" />
                <asp:BoundField DataField="major_Name" HeaderText="Major Name" SortExpression="major_Name" />
                <asp:BoundField DataField="department_Chair" HeaderText="Department Chair" SortExpression="department_Chair" />
                <asp:BoundField DataField="number_Faculty" HeaderText="number_Faculty" SortExpression="number_Faculty" Visible="False" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Major] WHERE [major_ID] = ?" InsertCommand="INSERT INTO [Major] ([major_ID], [major_Name], [department_Chair], [number_Faculty]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Major]" UpdateCommand="UPDATE [Major] SET [major_Name] = ?, [department_Chair] = ?, [number_Faculty] = ? WHERE [major_ID] = ?">
            <DeleteParameters>
                <asp:Parameter Name="major_ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="major_ID" Type="Int32" />
                <asp:Parameter Name="major_Name" Type="String" />
                <asp:Parameter Name="department_Chair" Type="String" />
                <asp:Parameter Name="number_Faculty" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="major_Name" Type="String" />
                <asp:Parameter Name="department_Chair" Type="String" />
                <asp:Parameter Name="number_Faculty" Type="Int32" />
                <asp:Parameter Name="major_ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
</asp:Content>
