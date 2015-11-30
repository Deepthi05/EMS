<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdEmp.aspx.cs" Inherits="EmployeeManagementSystem.UpdEmp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style3
        {
            width: 720px;
        }
        .style4
        {
            width: 64px;
            height: 64px;
        }
        .style5
        {
            font-family: "Times New Roman", Times, serif;
            font-size: large;
        }
        .style6
        {
            color: #0099FF;
        }
        .style8
        {
            color: #3366FF;
            font-family: "Malgun Gothic";
            font-size: larger;
        text-align: left;
    }
    .style9
    {
        width: 83px;
        height: 2px;
        color: #3366FF;
    }
    .style10
    {
        height: 2px;
    }
    .style11
    {
        width: 83px;
        color: #3366FF;
    }
    .style12
    {
        width: 83px;
        height: 10px;
        color: #3366FF;
    }
    .style13
    {
        height: 10px;
    }
    .style14
    {
        width: 83px;
        height: 18px;
        color: #3366FF;
    }
    .style15
    {
        height: 18px;
    }
    .style16
    {
        width: 83px;
        height: 3px;
        color: #3366FF;
    }
    .style17
    {
        height: 3px;
    }
    .style18
    {
        width: 83px;
        height: 16px;
        color: #3366FF;
    }
    .style19
    {
        height: 16px;
    }
    .style20
    {
        width: 83px;
        height: 42px;
        color: #3366FF;
    }
    .style21
    {
        height: 42px;
    }
    .style22
    {
        width: 83px;
        height: 5px;
        color: #3366FF;
    }
    .style23
    {
        height: 5px;
    }
    .style24
    {
        width: 83px;
        height: 23px;
    }
    .style25
    {
        height: 23px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p class="style3">
        <strong>&nbsp;<span class="style5">&nbsp; <span class="style6">Update Employee
        </span>&nbsp;</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
        <img alt="" class="style4" src="images/updEmp.jpg" /></p>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="style2" style="text-align: right">
                    EmployeeId:</td>
                <td>
                    <asp:TextBox ID="TextBox15" runat="server" ></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        Text="Details" />
                    <br />
                    <asp:Label ID="Label17" runat="server" ForeColor="#FF3300" Text="Label" Visible="false"></asp:Label>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="TextBox15" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8">
                    FirstName:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    MiddleName:</td>
                <td class="style10">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    LastName:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    Address</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style12">
                    City</td>
                <td class="style13">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    State:</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14">
                    ZipCode:</td>
                <td class="style15">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style16">
                    PhoneNumber:</td>
                <td class="style17">
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style18">
                    EmailId:</td>
                <td class="style19">
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style20">
                    Department:</td>
                <td class="style21">
                    <asp:DropDownList ID="DropDownList1" runat="server" 
                        DataSourceID="SqlDataSource1" DataTextField="deptName" 
                        DataValueField="deptName">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:EmployeeConnectionString %>" 
                        SelectCommand="SELECT [deptName] FROM [Dept]"></asp:SqlDataSource>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style22">
                    Picture:</td>
                <td class="style23">
                    <asp:FileUpload ID="picUpload" runat="server" />
                &nbsp;<asp:Image ID="Image1" runat="server" Height="77px" Width="86px" />
                </td>
            </tr>
            <tr>
                <td class="style11">
                    Salary:</td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style16">
                    Leaves:</td>
                <td class="style17">
                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    Position:</td>
                <td>
                    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style24">
                    </td>
                <td class="style25">
                    <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" 
                        BackColor="White" Font-Bold="True" ForeColor="#6666FF" />
                </td>
            </tr>
        </table>
</p>
    <p>
    <br />
</p>
</asp:Content>
