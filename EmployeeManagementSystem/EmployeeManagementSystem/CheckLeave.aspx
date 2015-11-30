<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckLeave.aspx.cs" Inherits="EmployeeManagementSystem.CheckLeave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 344px;
        }
    .style3
    {
        width: 381px;
        height: 59px;
    }
    .style5
    {
        width: 381px;
        height: 59px;
        text-align: right;
        color: #0000CC;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="style5">
                    <strong>Total Leaves: </strong></td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <strong>Leaves Remaining: </strong></td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
    </p>
</asp:Content>
