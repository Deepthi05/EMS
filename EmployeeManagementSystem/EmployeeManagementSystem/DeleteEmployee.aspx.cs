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
    public partial class DeleteEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bool radioUnClicked=true;
             //   TokenCodeDO tokenCodeDO = new TokenCodeDO();
                foreach (GridViewRow token in GridViewTokenCodeDetails.Rows)
                {

                    RadioButton tkn = (RadioButton)token.FindControl("tknCdeRadioButton");
                   if (tkn.Checked)
                   {
             int Id = Convert.ToInt32(GridViewTokenCodeDetails.DataKeys[token.RowIndex].Values["EmpId"]);
            EmpBusiness ea = new EmpBusiness();
                       ea.deleteEmp(Id);
                       Button1_Click(sender,e);
            
                   }
                }

                if (!radioUnClicked)
                {
     
                }
                else
                {
             
                }
                }
    

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmpBusiness eq=new EmpBusiness();
            List<Employee> eList = new List<Employee>();
            eList=eq.getEmp(TextBox14.Text);
            GridViewTokenCodeDetails.DataSource=eList;
            GridViewTokenCodeDetails.DataBind();
          
        }
        
    }
}