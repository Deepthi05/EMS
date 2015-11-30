using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace EmployeeManagementSystem
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showh();
        }


        public void showh()
        {

            if (Path.GetFileNameWithoutExtension(Request.Path)=="Default")
            {
                Button1.Visible = false;
            }
            if (Session["admin"] == "true")
            {
                NavigationMenu.Visible = true;
                NavigationMenu0.Visible = false;
            }
            else if(Session["admin"]=="false")
            {
                NavigationMenu.Visible = false;
                NavigationMenu0.Visible = true;
            }
            if (Session["admin"]=="")
            { NavigationMenu.Visible = false;
            NavigationMenu0.Visible = false;
                
            }
         
        }
        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["admin"] = "";
            NavigationMenu.Visible = false;
            NavigationMenu0.Visible = false;
            Response.Redirect("Default.aspx");
        }
    }
}
