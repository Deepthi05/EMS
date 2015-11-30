using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpEntity;
using EmpBL;
using EMP_DAL;

namespace EmployeeManagementSystem
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Auths a = new Auths();
            if (TextBox1.Text ==string.Empty || TextBox2.Text==string.Empty)
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                Label1.Visible = true;
                Response.Redirect(Request.Url.AbsoluteUri);
            }
            string uname= a.getAuthen(TextBox1.Text, TextBox2.Text);
            if (uname != null && uname != string.Empty)
            {
                Session["username"] = uname;

                bool stat = a.getIsAdmin(TextBox1.Text, TextBox2.Text);
                if (stat)
                {
                    Session["admin"] = "true";
                }
                else
                {
                    Session["admin"] = "false";
                }
                Response.Redirect("ViewEmployee.aspx");

            }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                Label1.Visible = true;
            }
        }
    }
}
