using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Configuration;
using EMP_DAL;
namespace EmpBL
{
    public class Email
    {
        public void SendEmail(string body)
        {
            // Console.WriteLine("Mail To");
            string userName = System.Configuration.ConfigurationManager.AppSettings["adminEmailId"];
            MailAddress to = new MailAddress(userName);
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("employeemanager2014@gmail.com");
                mail.To.Add(userName);
                mail.Subject = "Leave Notification";
                mail.Body = "Leave Applied";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("employeemanager2014", "polly@123");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            
            }
            catch (Exception ex)
            {
                 Auths aa = new Auths();
                 aa.insertEmail(" " + body + " " + ex.Message);
                     
                                       
                    
                
        }
        
        }
     
    }
}
