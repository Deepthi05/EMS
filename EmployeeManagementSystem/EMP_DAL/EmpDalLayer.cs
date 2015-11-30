using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmpEntity;

namespace EMP_DAL
{
    public class EmpDalLayer:IEmpDataLayer
    {
        public EmpDalDataContext eDataContext;
        public bool insertNewEmployee(EmpEntity.Employee e)
        {
            eDataContext = new EmpDalDataContext();
            eDataContext.insertEmployee(e.FirstName,e.MiddleName,e.LastName,e.Addreee,e.City,e.ZipCode,e.State,e.PhoneNumber,e.EmailId,e.Department,e.Picture,e.Salary,e.Leaves,e.Position);
            eDataContext.SubmitChanges();
            return true;
          //  throw new NotImplementedException();
        }

        public Employee getEmpOnId(int id)
        {
            eDataContext = new EmpDalDataContext();
            var q =eDataContext.getEmpOnId(id);
            EmpEntity.Employee e1 = new EmpEntity.Employee();
            foreach (var item in q)
            {
             
               e1.EmpId=Convert.ToInt32(item.EmpId);
               e1.FirstName=item.FirstName;
               e1.MiddleName=item.MiddleName;
               e1.LastName=item.LastName;
               e1.Addreee=item.Address;
               e1.City=item.City;
               e1.EmailId=item.EmailId;
               e1.Leaves=Convert.ToInt32(item.Leaves);
               e1.Picture=item.Picture;
               e1.Position=item.Position;
               e1.Salary=Convert.ToDecimal(item.Salary);
               e1.State=item.State;
               e1.ZipCode=item.ZipCode;
               e1.PhoneNumber = item.PhoneNumber;
               e1.Department = item.Department;
            }

            return e1;
        }

        public bool deleteEmp(int id)
        {
            eDataContext = new EmpDalDataContext();
            eDataContext.DeleteEmployee(id);
            eDataContext.SubmitChanges();
            return true;
            
            //   throw new NotImplementedException();
        }

        public bool updateEmp(EmpEntity.Employee e)
        {
            eDataContext = new EmpDalDataContext();
            eDataContext.UpdateEmp(e.EmpId,e.FirstName, e.MiddleName, e.LastName, e.Addreee, e.City, e.ZipCode, e.State, e.PhoneNumber, e.EmailId, e.Department, e.Picture, e.Salary, e.Leaves, e.Position);
            eDataContext.SubmitChanges();
            return true;
            //throw new NotImplementedException();
        }

        public List<EmpEntity.Employee> getEmp(string Name)
        {
            List<EmpEntity.Employee> eList = new List<EmpEntity.Employee>();
            eDataContext = new EmpDalDataContext();
           var e=  eDataContext.getEmp(Name);

           foreach (var item in e)
           {
               EmpEntity.Employee e1 = new EmpEntity.Employee();
               e1.EmpId=Convert.ToInt32(item.EmpId);
               e1.FirstName=item.FirstName;
               e1.MiddleName=item.MiddleName;
               e1.LastName=item.LastName;
               e1.Addreee=item.Address;
               e1.Department = item.Department;
               e1.City=item.City;
               e1.EmailId=item.EmailId;
               e1.Leaves=Convert.ToInt32(item.Leaves);
               e1.Picture=item.Picture;
               e1.Position=item.Position;
               e1.Salary=Convert.ToDecimal(item.Salary);
               e1.State=item.State;
               e1.ZipCode=item.ZipCode;
               e1.PhoneNumber = item.PhoneNumber;
               eList.Add(e1);
           }

           return eList;
         //   throw new NotImplementedException();
        }

        public  string getAuthen(string u, string p)
        {
            eDataContext = new EmpDalDataContext();
            string name= string.Empty;
          return name= Convert.ToString( eDataContext.GetAuthorization(u,p));
        }

        public bool insertLeave(EmpLeave el)
        {
            eDataContext = new EmpDalDataContext();

            eDataContext.InsertLeave(el.EmpId,el.FromDate,el.ToDate,el.Descr);
            eDataContext.SubmitChanges();
            return true;
        }

        public List<EmpLeave> getLeavesTaken(int id)
        {
            eDataContext = new EmpDalDataContext();
            List<EmpLeave> eList = new List<EmpLeave>();
            var w= eDataContext.getLeaves(id);
            foreach (var item in w)
            {
                EmpLeave ea = new EmpLeave();
                ea.EmpId = Convert.ToInt32(item.EmpId);
                ea.FromDate =Convert.ToDateTime( item.FromDate);
                ea.ToDate =Convert.ToDateTime( item.ToDate);
                ea.Descr = item.Reason.ToString();
                eList.Add(ea);
            }
            return eList;
        }
        public int getsetAttendance(int EId, DateTime d)
        {
            eDataContext = new EmpDalDataContext();
            int i = eDataContext.getIsPresent(EId, d);
            return i;
        }

        public decimal getSalaryPerHour(int Eid)
        {
            eDataContext = new EmpDalDataContext();
            var we = eDataContext.GetSalary(Eid);
            
            decimal s = Convert.ToDecimal(we.First().Salary);
            return s;
        }
        public int getSalaryForDays(int Eid, int month)
        {
            eDataContext = new EmpDalDataContext();
            List<EmpSal> esalList = new List<EmpSal>();
            var s = eDataContext.GetLeavesApplied(Eid,month);
           // TimeSpan t;
            int Leaves = 0;
            foreach (var item in s)
            {
                DateTime d1 = Convert.ToDateTime(item.FromDate);
                DateTime d2 =Convert.ToDateTime( item.ToDate);
                TimeSpan d3 = d2 - d1;
                Leaves += d3.Days;
                
            }
            return Leaves;
        }
    }
}
