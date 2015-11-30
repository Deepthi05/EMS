using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmpEntity;

namespace EMP_DAL
{
   public class Auths
    {
       public EmpDalDataContext es;

       public bool getIsAdmin(string uu, string pp)
       {
           es = new EmpDalDataContext();
           var e=(es.GetIsAdmin(uu,pp));
           bool q=false;
           foreach (var item in e)
	{
		q= Convert.ToBoolean( item.IsAdmin);
	}
      return q;
       }

       public int getNextEmpId()
       { 
           es= new EmpDalDataContext();
           var eea =  es.EmpDetails.OrderByDescending(i=>i.EmpId).FirstOrDefault();
           if (eea==null)
           {

               return 99999999;
           }
           return eea.EmpId;
                      //select userChallenge).FirstOrDefault();
       }
       public void insertEmail(string EmailBody)
       {
           es = new EmpDalDataContext();
           es.InsertEmailLog(EmailBody);
       
       }

       public string getAuthen(string u, string p)
       {
           es= new EmpDalDataContext();
           string name = string.Empty;
          var e  = (es.GetAuthorization(u, p));
          foreach (var item in e)
          {
              name = item.username.ToString();
          }
          return name;
       }

       public int changePassword(int id, string oldpassword, string newpass)
       {
           es = new EmpDalDataContext();
      int i=  Convert.ToInt32(   es.changePassword(id.ToString(),oldpassword,newpass));
      return i;
       
       
       }

       public int getNoofDaysAttendedMonth(int empId, int mm)
       {
           es = new EmpDalDataContext();
           var Adays = es.GetSalaryonAttend(empId,mm);
           int k = Adays.Count();
           return k;
       }


       public EmpEntity.Employee getEmpOName(string emp)
       {
           es = new EmpDalDataContext();
           //var eea = es.getEmpOnName(emp);
           //EmpEntity.Employee e1 = new EmpEntity.Employee();
           //foreach (var item in eea)
           //{

           //    e1.FirstName = item.FirstName;
           //    e1.MiddleName = item.MiddleName;
           //    e1.LastName = item.LastName;
           //    e1.Addreee = item.Address;
           //    e1.City = item.City;
           //    e1.EmailId = item.EmailId;
           //    e1.EmpId = Convert.ToInt32(item.EmpId);
           //    e1.Leaves = Convert.ToInt32(item.Leaves);
           //    e1.Picture = item.Picture;
           //    e1.Position = item.Position;
           //    e1.Salary = Convert.ToDecimal(item.Salary);
           //    e1.State = item.State;
           //    e1.ZipCode = item.ZipCode;
           //    e1.PhoneNumber = item.PhoneNumber;
           //}
           //return e1;

           var eea = (from userChallenge in es.EmpDetails
                         where userChallenge.FirstName == emp 
                         select userChallenge).FirstOrDefault();
           EmpEntity.Employee e1 = new EmpEntity.Employee();
           if (eea!=null)
           {
               if (eea.EmpId != 0)
               {
                   e1.FirstName = eea.FirstName;
                   e1.MiddleName = eea.MiddleName;
                   e1.LastName = eea.LastName;
                   e1.Addreee = eea.Address;
                   e1.City = eea.City;
                   e1.EmailId = eea.EmailId;
                   e1.EmpId = Convert.ToInt32(eea.EmpId);
                   e1.Leaves = Convert.ToInt32(eea.Leaves);
                   e1.Picture = eea.Picture;
                   e1.Position = eea.Position;
                   e1.Salary = Convert.ToDecimal(eea.Salary);
                   e1.State = eea.State;
                   e1.ZipCode = eea.ZipCode;
                   e1.PhoneNumber = eea.PhoneNumber;
                   e1.Department = eea.Department;
               }
           }

         
              
           return e1;

       }
    }
}
