<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewEmployee.aspx.cs" Inherits="EmployeeManagementSystem.ViewEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .style2
        {
            width: 389px;
            font-weight: bold;
        }
        .style1
        {
            text-align: right;
            width: 389px;
            font-weight: bold;
        }
        .style3
        {
            width: 51px;
            height: 46px;
        }
        .style4
        {
            font-size: large;
        }
        .style5
    {
        text-align: right;
        width: 265px;
        font-weight: bold;
        height: 19px;
    }
    .style6
    {
        height: 19px;
    }
    .style7
    {
        text-align: right;
        width: 265px;
        font-weight: bold;
        height: 18px;
    }
    .style8
    {
        height: 18px;
    }
    .style9
    {
        text-align: right;
        width: 265px;
        font-weight: bold;
        height: 15px;
    }
    .style10
    {
        height: 15px;
    }
    .style11
    {
        text-align: right;
        width: 265px;
        font-weight: bold;
        height: 11px;
    }
    .style12
    {
        height: 11px;
    }
    .style13
    {
        text-align: right;
        width: 265px;
        font-weight: bold;
        height: 5px;
    }
    .style14
    {
        height: 5px;
    }
    .style15
    {
        text-align: right;
        width: 83px;
        font-weight: bold;
        height: 13px;
    }
    .style16
    {
        height: 13px;
    }
    .style17
    {
        text-align: right;
        width: 265px;
        font-weight: bold;
        height: 8px;
    }
    .style18
    {
        height: 8px;
    }
    .style19
    {
        text-align: right;
        width: 265px;
        font-weight: bold;
        height: 4px;
    }
    .style20
    {
        height: 4px;
    }
    .style21
    {
        text-align: right;
        width: 265px;
        font-weight: bold;
        height: 9px;
    }
    .style22
    {
        height: 9px;
    }
    .style23
    {
        text-align: right;
        width: 265px;
        font-weight: bold;
        height: 14px;
    }
    .style24
    {
        height: 14px;
    }
    .style27
    {
        text-align: right;
        width: 265px;
        font-weight: bold;
    }
    .style25
    {
        text-align: right;
        width: 83px;
        font-weight: bold;
        height: 7px;
    }
    .style26
    {
        height: 7px;
    }
    .style29
    {
        text-align: right;
        width: 265px;
        font-weight: bold;
        height: 13px;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <strong><span class="style4">View Info&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
        <img alt="" class="style3" src="images/viewEmp.jpg" /></strong><br />
    </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
                ID="Label17" runat="server" ForeColor="#FF3300" Text="Label"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="White" ForeColor="Black" 
                onclick="Button1_Click" Text="Search" />
    <p>
                                     <asp:GridView ID="GridViewTokenCodeDetails" runat="server" 
                                            Width="87%" AutoGenerateColumns="False" ShowFooter="True" 
                                            DataKeyNames="FirstName,Department,EmpId" >
                                            <Columns>
<asp:TemplateField>
        <ItemTemplate>
          <asp:RadioButton  ID="tknCdeRadioButton" runat="server"  GroupName="tokenCodes"
                   Width="10px" Style="text-align: center" onclick="toggleSelection(this);" ></asp:RadioButton>
        </ItemTemplate>
   </asp:TemplateField>                                            

  <asp:BoundField DataField="FirstName" visible="true" HeaderText="Name" />
<%--   <asp:TemplateField>
   <ItemTemplate>
        <asp:Label ID="lblProName" runat="server" ToolTip='<%#Server.HtmlDecode(Eval("TokenCodePromoName").ToString()) %>' Text='<%#Eval("TokenCodeDispPromoName").ToString() %>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>--%>
                         <asp:BoundField DataField="Department" Visible="true" HeaderText="Department" />    
                                <asp:BoundField DataField="EmpId" Visible="true" HeaderText="EmpId" />
                            </Columns>
                                        </asp:GridView> 
                                     <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="View" 
                                         Visible="False" />
                                     &nbsp;<asp:Panel ID="Panel1" runat="server" style="margin-left: 131px">
    <table style="width:70%; margin-right: 2px; margin-left: 1px;" border="2">
        <tr>
            <td class="style5" style="text-align: right">
                EmployeeId:</td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                FirstName</td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style5">
                MiddleName:</td>
            <td class="style6">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7">
                LastName:</td>
            <td class="style8">
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style9">
                Address</td>
            <td class="style10">
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style11">
                City</td>
            <td class="style12">
                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style13">
                State:</td>
            <td class="style14">
                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style29">
                ZipCode:</td>
            <td class="style16">
                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style17">
                PhoneNumber:</td>
            <td class="style18">
                <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style19">
                EmailId:</td>
            <td class="style20">
                <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style21">
                Department:</td>
            <td class="style22">
                <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style23">
                Picture:</td>
            <td class="style24">
                <asp:Label ID="Label13" runat="server" Text="Label" Visible="False"></asp:Label>
                &nbsp;<asp:Image ID="Image1" runat="server" Height="88px" 
                    ImageUrl="~/images/addEmp.jpg" Width="95px" />
            </td>
        </tr>
        <tr>
            <td class="style27">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
    <asp:Panel ID="Panel2" runat="server">
        <table border="2" style="width: 70%; margin-right: 2px; margin-left: 1px;">
            <tr>
                <td class="style25">
                    Salary:</td>
                <td class="style26">
                    <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style15">
                    Leaves:</td>
                <td class="style16">
                    <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
    </asp:Panel>
    <br />
</asp:Panel>
</p>
    <script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
        <script src="<%= ResolveUrl("~/Scripts/Validate.js?v=1") %>" type="text/javascript"></script>
</asp:Content>
