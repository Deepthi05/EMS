using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpBL;
using EmpEntity;
using EMP_DAL;

namespace EmployeeManagementSystem
{
    public partial class ViewEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label17.Visible = false;
            Panel1.Visible = false;
            if (Session["username"]!=null ||Session["username"]!=string.Empty)
            {
                if (Session["admin"]=="false")
                {
                    setlabels();
                    Panel1.Visible = true;
                    Panel2.Visible = false;
                }
               
                
            }
        }
        public void setlabels()
        {
            int ids = Convert.ToInt32(Session["username"]);
            EmpBusiness ebb = new EmpBusiness();
            Employee eq = new Employee();
            eq = ebb.getEmpOnId(ids);
            Label2.Text = eq.EmpId.ToString();
            Label3.Text = eq.FirstName;
            Label4.Text = eq.MiddleName;
            Label5.Text = eq.LastName;
            Label6.Text = eq.Addreee;
            Label7.Text = eq.City;
            Label8.Text = eq.State;
            string[] zip = eq.ZipCode.Split('-');
            Label9.Text = zip[0].ToString() +'-' +zip[1].ToString();
            //Label8.Text = 
            Label10.Text = eq.PhoneNumber;
            Label11.Text = eq.EmailId;
            Label12.Text = eq.Department;
            Label14.Text = Convert.ToString(eq.Salary);
            Label15.Text = eq.Leaves.ToString();
            Label16.Text = eq.Position;
            if (eq.Picture!=string.Empty)
            {
                Image1.ImageUrl = "images/" + eq.Picture;   
            }


            //if (Session["admin"] == "false")
            //{
            //    //   setlabels();
            //    Panel1.Visible = true;
            //    Panel2.Visible = false;
            //}
            //else
            //{
            //    Panel2.Visible = true;
            //    Panel1.Visible = true;
            //}
        }

        public void getClick(int id)
        {
            

            EmpBL.EmpBusiness eb = new EmpBL.EmpBusiness();
            Auths a = new Auths();
            Employee eq = eb.getEmpOnId(id);
            if (eq.EmpId == 0)
            {
                Label17.Text = "Employee not found";

                Label17.Visible = true;
            }
            else
            {
                Label2.Text = eq.EmpId.ToString();
                Label3.Text = eq.FirstName;
                Label4.Text = eq.MiddleName;
                Label5.Text = eq.LastName;
                Label6.Text = eq.Addreee;
                Label7.Text = eq.City;
                Label8.Text = eq.State;
                string[] zip = eq.ZipCode.Split('-');
                Label9.Text = zip[0].ToString() + '-' + zip[1].ToString();
                //Label8.Text = 
                Label10.Text = eq.PhoneNumber;
                Label11.Text = eq.EmailId;
                Label12.Text = eq.Department;
                //     Label13.Text = Convert.ToString(eq.Salary);
                //Label14.Text = eq.Leaves.ToString();
                //Label15.Text = eq.Position;

                Label14.Text = Convert.ToString(eq.Salary);
                Label15.Text = eq.Leaves.ToString();
                Label16.Text = eq.Position;
                if (eq.Picture != string.Empty)
                {
                    Image1.ImageUrl = "images/" + eq.Picture;
                }

                if (Session["admin"] == "true")
                {
                    //   setlabels();
                    Panel1.Visible = true;
                    Panel2.Visible = true;
                }
                //else
                //    Panel2.Visible = true;
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            EmpBusiness eq = new EmpBusiness();
            List<Employee> eList = new List<Employee>();
            eList = eq.getEmp(TextBox1.Text);
            GridViewTokenCodeDetails.DataSource = eList;
            GridViewTokenCodeDetails.DataBind();
            Button2.Visible = true;
            if (eList.Count==0)
            {
                  Label17.Text = "Employee not found";

                Label17.Visible = true;
                Button2.Visible = false;
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bool radioUnClicked = true;
            //   TokenCodeDO tokenCodeDO = new TokenCodeDO();
            foreach (GridViewRow token in GridViewTokenCodeDetails.Rows)
            {

                RadioButton tkn = (RadioButton)token.FindControl("tknCdeRadioButton");
                if (tkn.Checked)
                {
                    int Id = Convert.ToInt32(GridViewTokenCodeDetails.DataKeys[token.RowIndex].Values["EmpId"]);
                    EmpBusiness ea = new EmpBusiness();
                    getClick(Id);

                }
            }

            if (!radioUnClicked)
            {

            }
            else
            {

            }
     
        }
    }
}   