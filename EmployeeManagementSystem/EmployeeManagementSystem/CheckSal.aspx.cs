using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpBL;
using EMP_DAL;

namespace EmployeeManagementSystem
{
    public partial class CheckSal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Label5.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                EmpBusiness eb = new EmpBusiness();
      //   int   EmpId = Convert.ToInt32(Session["username"]);
        //=eb.getEmpOnId(EmpId);
         Auths a = new Auths();
    EmpEntity.Employee ee=      a.getEmpOName(TextBox2.Text);
    if (ee.EmpId == 0)
    {
        Label5.Visible = true;

    }
    else
    {
        int month = Convert.ToInt32(ddlMonth.SelectedValue);
        Label4.Text = Convert.ToString(eb.calcuSalary(ee.EmpId, month));
        //Label3.Text = ee.Position;
        Label2.Text = ee.Department;
        Label1.Text = ee.EmpId.ToString();
        Panel1.Visible = true;
    }
        }
    }
}