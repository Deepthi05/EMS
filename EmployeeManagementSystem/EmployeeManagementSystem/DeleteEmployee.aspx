<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteEmployee.aspx.cs" Inherits="EmployeeManagementSystem.DeleteEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            color: #FF0000;
            font-size: medium;
        }
        .style2
        {
            text-align: right;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%--<script type="text/javascript">
    function toggleSelection(source) {

        var isChecked = source.checked;
        $("#GridViewTokenCodeDetails input[id*='tknCdeRadioButton']").each(function (index) {
            $(this).attr('checked', false);
        });
        source.checked = isChecked;
    }
</script>
--%>    <p>
        <span class="style1"><strong>Delete Employee</strong></span><br />
    </p>
    <p>
        <table style="width:100%; height: 236px;">
            <tr>
                <td class="style2">
                    <strong>Name:</strong></td>
                <td>
                    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Search" onclick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
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
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Delete" onclick="Button2_Click" 
                        ForeColor="#FF3300" />
                </td>
            </tr>
        </table>
    </p>
    <script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
        <script src="<%= ResolveUrl("~/Scripts/Validate.js?v=1") %>" type="text/javascript"></script>
</asp:Content>
