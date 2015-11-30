using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmpEntity;

namespace EmpBL
{
    public interface IEmpBusiness
    {
        bool insertNewEmployee(Employee e);
        bool deleteEmp(int id);
        bool updateEmp(Employee e);
        List<EmpEntity.Employee> getEmp(string Name);
     //   string getAuthen(string u, string p);
        Employee getEmpOnId(int id);
         int getEmpLeave(int id);
        bool insertEmpLeave(EmpLeave ee);
        int getsetAttendance(int EId,DateTime d);
        decimal getSalaryPerHour(int Eid);
        int getSalaryForDays(int Eid, int month);
        decimal calcSalary(int Eid, int month);
    }
}
