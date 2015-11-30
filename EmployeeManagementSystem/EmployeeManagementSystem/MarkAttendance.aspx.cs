using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpBL;


namespace EmployeeManagementSystem
{
    public partial class MarkAttendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(Session["username"]);
            EmpBusiness eb = new EmpBusiness();
       int exa =     eb.getsetAttendance(eid,DateTime.UtcNow);
       if (exa == 2)
       {
           Button1.Enabled = false;
       }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Button1.Enabled = false;

        }
    }
}