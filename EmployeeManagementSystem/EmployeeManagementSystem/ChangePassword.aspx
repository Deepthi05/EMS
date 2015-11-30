<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="EmployeeManagementSystem.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
<p>
    Current Password:
    <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
</p>
<p>
    New Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
    <asp:Label ID="Label1" runat="server" ForeColor="Lime" Text="Password Changed" 
        Visible="False"></asp:Label>
</p>
</asp:Content>
