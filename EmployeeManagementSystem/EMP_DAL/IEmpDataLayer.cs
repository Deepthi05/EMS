using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmpEntity;

namespace EMP_DAL
{
    public interface IEmpDataLayer
    {
         bool insertNewEmployee(Employee e);
         bool deleteEmp(int id);
         bool updateEmp(Employee e);
         List<EmpEntity.Employee> getEmp(string Name);
         string getAuthen(string u, string p);
         Employee getEmpOnId(int id);
         bool insertLeave(EmpLeave el);
         List<EmpLeave> getLeavesTaken(int id);
         int getsetAttendance(int EId, DateTime d);
         decimal getSalaryPerHour(int Eid);
         int getSalaryForDays(int Eid, int month);

    }
}
