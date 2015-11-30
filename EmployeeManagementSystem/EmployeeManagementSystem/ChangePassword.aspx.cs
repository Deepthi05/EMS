using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMP_DAL;

namespace EmployeeManagementSystem
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Auths aa = new Auths();
            int j = aa.changePassword(Convert.ToInt32(Session["username"]),TextBox1.Text,TextBox2.Text);
            if (j == 2)
            {
                Label1.Visible = true;
            }
            else
            {
                Label1.Text = "Failed to change";
                Label1.Visible = true;
            }
            TextBox1.Text = "";
            TextBox2.Text = "";

        }
    }
}