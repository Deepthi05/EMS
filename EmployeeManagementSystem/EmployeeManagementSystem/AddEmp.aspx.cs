using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpEntity;
using EmpBL;
using System.IO;

namespace EmployeeManagementSystem
{
    public partial class AddEmp : System.Web.UI.Page
    {
        int x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshLabelEmpId();
        }

        public void refreshLabelEmpId()
        {
            EMP_DAL.Auths a = new EMP_DAL.Auths();
            int b = Convert.ToInt32(a.getNextEmpId());
            b = b + 1;
            Label1.Text = "EmpId: " + b;
            x = b;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            e1.FirstName = txtFname.Text;
            e1.MiddleName = txtMname.Text;
            e1.LastName = txtLname.Text;
            e1.Leaves = Convert.ToInt32(txtLeaves.Text);
            e1.PhoneNumber = txtPhoneNo.Text;
            e1.Position = txtPos.Text;
            e1.ZipCode = txtZip1.Text + "-" + txtZip2.Text;
            e1.State = txtState.Text;
            e1.Salary = Convert.ToDecimal(txtSal.Text);
            e1.Addreee = txtAdd.Text;
            e1.City = txtCity.Text;
            e1.Department = ddlDept.SelectedItem.Text;
            e1.EmailId = txtEmailId.Text;
            if (picUpload.HasFile)
            {
                string fileName = Path.GetFileName(picUpload.PostedFile.FileName);
                picUpload.PostedFile.SaveAs(Server.MapPath("Images/") + fileName);
                e1.Picture = fileName;
            }
            EmpBusiness eba = new EmpBusiness();
            eba.insertNewEmployee(e1);
            string text2disp = "Emp Id "+x+" created successfully";
           // string script = text2disp;
            Label2.Visible = true;
            Label2.Text = text2disp;
            clearst();
         
        }
        public void clearst()
        {
            txtAdd.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtEmailId.Text = string.Empty;
            txtFname.Text = string.Empty;
            txtLeaves.Text = string.Empty;
            txtLname.Text = string.Empty;
            txtMname.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtPos.Text = string.Empty;
            txtSal.Text = string.Empty;
            txtState.Text = string.Empty;
            txtZip1.Text = string.Empty;
            txtZip2.Text = string.Empty;
            refreshLabelEmpId();

        }

    }
}