using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpBL;

namespace EmployeeManagementSystem
{
    public partial class CheckLeave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpBusiness eb = new EmpBusiness();
            int s = Convert.ToInt32(Session["username"]);
           EmpEntity.Employee ew= eb.getEmpOnId(s);
           Label3.Text = ew.Leaves.ToString();
         int leavesTaken=  eb.getEmpLeave(s);
         Label4.Text = (ew.Leaves - leavesTaken).ToString();
        }
    }
}