<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckSal.aspx.cs" Inherits="EmployeeManagementSystem.CheckSal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
        height: 70px;
    }
    .style2
    {
        height: 5px;
    }
        .style3
        {
            color: #FFFF66;
        }
        .style4
        {
            font-size: medium;
        }
        .style5
        {
            color: #FF9900;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <strong><span class="style3"><span class="style4">Salary</span>:</span></strong><br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="style1">
                    <strong><span class="style5">Name</span>:</strong></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Label ID="Label5" runat="server" ForeColor="#FF3300" 
                        Text=" Employee not found" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <strong><span class="style5">Month</span>:</strong></td>
                <td>
                    <asp:DropDownList ID="ddlMonth" runat="server">
                        <asp:ListItem Value="1">Jan</asp:ListItem>
                        <asp:ListItem Value="2">Feb</asp:ListItem>
                        <asp:ListItem Value="3">Mar</asp:ListItem>
                        <asp:ListItem Value="4">Apr</asp:ListItem>
                        <asp:ListItem Value="5">May</asp:ListItem>
                        <asp:ListItem Value="6">Jun</asp:ListItem>
                        <asp:ListItem Value="7">Jul</asp:ListItem>
                        <asp:ListItem Value="8">Aug</asp:ListItem>
                        <asp:ListItem Value="9">Sep</asp:ListItem>
                        <asp:ListItem Value="10">Oct</asp:ListItem>
                        <asp:ListItem Value="11">Nov</asp:ListItem>
                        <asp:ListItem Value="12">Dec</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    </td>
                <td class="style2">
                    <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" 
                        ForeColor="#FF9900" />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <asp:Panel ID="Panel1" runat="server" Height="207px">
        <table border="2" style="width: 59%; margin-left: 128px;">
            <tr>
                <td>
                    <b>EmpId</b></td>
                <td>
                    <b>Department</b></td>
                <td>
                    <b>Salary</b></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
</asp:Panel>
<p>
&nbsp;</p>
    <p>
    </p>
</asp:Content>
