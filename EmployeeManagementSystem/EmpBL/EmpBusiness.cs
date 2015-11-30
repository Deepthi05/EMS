using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMP_DAL;
using EmpEntity;

namespace EmpBL
{
  public  class EmpBusiness:IEmpBusiness
    {
      EMP_DAL.EmpDalLayer ed;
      public bool insertNewEmployee(EmpEntity.Employee e)
        {
            ed = new EmpDalLayer();
            ed.insertNewEmployee(e);
            return true;

        }

        public bool deleteEmp(int id)
        {
            ed = new EmpDalLayer();
            ed.deleteEmp(id);
            return true;
           // throw new NotImplementedException();
        }

        public bool updateEmp(EmpEntity.Employee e)
        {
            ed = new EmpDalLayer();
            ed.updateEmp(e);
            return true;
            //throw new NotImplementedException();
        }

        public List<EmpEntity.Employee> getEmp(string Name)
        {
            ed = new EmpDalLayer();
            List<Employee> eListB = new List<Employee>();
           return eListB= ed.getEmp(Name);
           // throw new NotImplementedException();
        }

        public Employee getEmpOnId(int id)
        {
            ed = new EmpDalLayer();
          Employee  ew = ed.getEmpOnId(id);
          return ew;
        }

        public int getEmpLeave(int id)
        {
            ed = new EmpDalLayer();
            List<EmpLeave> el = new List<EmpLeave>();
            el = ed.getLeavesTaken(id);
            int leaves = 0;
            foreach (var item in el)
            {
                DateTime d1 = item.FromDate;
                DateTime d2 = item.ToDate;
                TimeSpan d3 = d2 - d1;
                leaves += d3.Days;
                
            }
            return leaves;
        }

        public bool insertEmpLeave(EmpLeave ee)
        {
            ed = new EmpDalLayer();
            ed.insertLeave(ee);
            return true;
        }

        public int getsetAttendance(int EId, DateTime d)
        {
            ed = new EmpDalLayer();
            int j=ed.getsetAttendance(EId, d);
            return j;
        }

        public decimal getSalaryPerHour(int Eid)
        {
            ed = new EmpDalLayer();
            decimal sa=ed.getSalaryPerHour(Eid);
            return sa;

        }
        public int getSalaryForDays(int Eid, int month)
        {
            ed = new EmpDalLayer();
            //int i = ed.getSalaryForDays(Eid,month);
            int i = ed.getSalaryForDays(Eid, month);
            return i;
        }

        public decimal calcSalary(int Eid, int month)
        {
            //ed = new EmpDalLayer();
            decimal i = getSalaryPerHour(Eid);
            int j = getSalaryForDays(Eid,month);
            decimal TotalSalary = i * 8 * (DateTime.DaysInMonth(2014,month)-j);
            return TotalSalary;
        }

        public decimal calcuSalary(int Eid, int month)
        {
            Auths aa = new Auths();
            int daysAttended=aa.getNoofDaysAttendedMonth(Eid,month);
            decimal i = getSalaryPerHour(Eid);
          //  int j = getSalaryForDays(Eid, month);
            decimal TotalSal = i * 8 * daysAttended;
            return TotalSal;
        }
    }
}
