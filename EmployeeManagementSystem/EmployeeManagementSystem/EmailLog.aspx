<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmailLog.aspx.cs" Inherits="EmployeeManagementSystem.EmailLog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
<p>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" Height="105px" Width="473px">
        <Columns>
            <asp:BoundField DataField="mailMsg" HeaderText="mailMsg" 
                SortExpression="mailMsg" />
            <asp:BoundField DataField="DateofLog" HeaderText="DateofLog" 
                SortExpression="DateofLog" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:EmployeeConnectionString %>" 
        SelectCommand="SELECT * FROM [EmailLog]"></asp:SqlDataSource>
</p>
<p>
</p>
</asp:Content>
