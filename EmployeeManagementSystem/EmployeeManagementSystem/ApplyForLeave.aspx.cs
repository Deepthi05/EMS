            
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpBL;
using EmpEntity;
namespace EmployeeManagementSystem
{
    public partial class ApplyForLeave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmpBusiness ebb = new EmpBusiness();
            int l =ebb.getEmpLeave(Convert.ToInt32(Session["username"]));
             EmpBusiness ebbb = new EmpBusiness();
             Employee  p = ebbb.getEmpOnId(Convert.ToInt32(Session["username"]));
            
            TimeSpan ts = Calendar2.SelectedDate-Calendar1.SelectedDate;
            int leavLeft = p.Leaves - l - ts.Days;
            if (leavLeft>0)
            {
                EmpLeave el = new EmpLeave();
                el.EmpId = Convert.ToInt32(Session["username"]);
                el.FromDate = Calendar1.SelectedDate;
                el.ToDate = Calendar2.SelectedDate;
                el.Descr = TextBox1.Text;
                ebb.insertEmpLeave(el);
                string body = "Emp Id with" + el.EmpId + "has applied leave from " + el.FromDate + " to " + el.ToDate + " for the particular reason " + el.Descr;
                Email s = new Email();
                s.SendEmail(body);
                Response.Redirect(Request.Url.AbsoluteUri);
            }

            else
                Label1.Visible = true;

            }
            //Response.Redirect(Request.Url.AbsoluteUri);
           
        }
    }
