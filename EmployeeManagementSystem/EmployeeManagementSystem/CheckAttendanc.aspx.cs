using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMP_DAL;
using EmpEntity;

namespace EmployeeManagementSystem
{
    public partial class CheckAttendanc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Label6.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmpBL.EmpBusiness eb = new EmpBL.EmpBusiness();
            Auths a = new Auths();
            Employee ee= a.getEmpOName(TextBox2.Text);
            if (ee.EmpId == 0)
            {
                Label6.Visible = true;
            }
            else
            {
                int i = eb.getSalaryForDays(ee.EmpId, Convert.ToInt32(ddlMonth.SelectedValue));
                int totalDays = DateTime.DaysInMonth(2014, Convert.ToInt32(ddlMonth.SelectedValue));
                int leavesLeft = totalDays - i;
             int attendedDays=   a.getNoofDaysAttendedMonth(ee.EmpId, Convert.ToInt32(ddlMonth.SelectedValue));
                Panel1.Visible = true;
                //Label5.Visible = false;
                
              //  Label5.Text = totalDays.ToString();
                Label4.Text = attendedDays.ToString();
             //   Label3.Text = ee.Position;
                Label2.Text = ee.Department;
                Label1.Text = ee.EmpId.ToString();
            }

        }
    }
}