using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpBL;
using EmpEntity;
using System.IO;

namespace EmployeeManagementSystem
{
    public partial class UpdEmp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    
        protected void Button2_Click(object sender, EventArgs e)
        {
            int ids = 0;
            ids = Convert.ToInt32(TextBox15.Text);
            EmpBusiness ebb = new EmpBusiness();
            Employee eq = new Employee();
            eq = ebb.getEmpOnId(ids);
            if (eq.EmpId != 0)
            {
                TextBox1.Text = eq.FirstName;
                TextBox2.Text = eq.MiddleName;
                TextBox3.Text = eq.LastName;
                TextBox4.Text = eq.Addreee;
                TextBox5.Text = eq.City;
                TextBox6.Text = eq.State;
                string[] zip = eq.ZipCode.Split('-');
                TextBox7.Text = zip[0].ToString();
                TextBox8.Text = zip[1].ToString();
                TextBox9.Text = eq.PhoneNumber;
                TextBox10.Text = eq.EmailId;
                TextBox11.Text = Convert.ToString(eq.Salary);
                TextBox12.Text = eq.Leaves.ToString();
                TextBox14.Text = eq.Position;
                Label1.Text = eq.Department.ToString();
                DropDownList1.SelectedItem.Text = eq.Department.ToString();
                if (eq.Picture != string.Empty)
                {
                    Image1.ImageUrl = "images/" + eq.Picture;
                }

            }
            else
            {
                Label17.Text = "Employee Not Found";
                Label17.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmpBusiness ebb = new EmpBusiness();
            Employee eq = new Employee();
            eq.EmpId =Convert.ToInt32(TextBox15.Text);
            eq.FirstName = TextBox1.Text;
            eq.MiddleName = TextBox2.Text;
            eq.LastName = TextBox3.Text;
            eq.Addreee = TextBox4.Text;
            eq.City = TextBox5.Text;
            eq.State = TextBox6.Text;
            eq.ZipCode = TextBox7.Text + "-" + TextBox8.Text;
            eq.Department = DropDownList1.SelectedItem.Text;
            eq.PhoneNumber = TextBox9.Text;
            eq.EmailId = TextBox10.Text;
            eq.Salary = Convert.ToDecimal(TextBox11.Text);
            eq.Leaves = Convert.ToInt32(TextBox12.Text);
            eq.Position = TextBox14.Text.ToString();

            if (picUpload.HasFile)
            {
                string fileName = Path.GetFileName(picUpload.PostedFile.FileName);
                picUpload.PostedFile.SaveAs(Server.MapPath("Images/") + fileName);
                eq.Picture = fileName;
            }
            ebb.updateEmp(eq);
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }
}