using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Reflection;
using FluentEmail.Smtp;
using FluentEmail.Core;
using TrackerLibrary.Models;
using System.Net;

namespace TrackerLibrary
{
    public static class EmailLogic
    {


        public static void SendEmail(string sender,  List <string> to,List<string> bcc, string subject, TeamModel winners,decimal winnerPrize,TeamModel runnerUp,decimal runnerPrize)
        {
            string email = "delali.abdallah@gmail.com";
            string pw = "xcmh bmpo rnmv aivz";

            var client = new SmtpSender(() => new SmtpClient(host: "smtp.gmail.com")
            {

                EnableSsl = true,
                Credentials=new NetworkCredential(email,pw),
                Port = 587
            });

            StringBuilder body = new StringBuilder();

            body.AppendLine("<h1>we have a winner </h1>");
            body.AppendLine("<p>Congratiulations to our winner on a great tournament.</p>");
            body.AppendLine("<br />");

            if (winnerPrize > 0)
            {
                body.AppendLine($"<p> {winners.TeamName} will receive ${winnerPrize} </p>");
            }

            if (runnerPrize > 0)
            {
                body.AppendLine($"<p> {runnerUp.TeamName} will receive ${runnerPrize} </p>");
            }

            body.AppendLine("<p> Thanks for a great tournament everyone!</p>");
            body.AppendLine("~Tournament Tracker");
            Email.DefaultSender = client;
            var mail = Email
                  .From(emailAddress: sender);

            foreach (var toEmail in to)
            {
                mail = mail.To(emailAddress: toEmail);
            }

         
            foreach (var bccEmail in bcc)
            {
                mail = mail.BCC(emailAddress: bccEmail);
            }
            
            
            mail.Subject(subject)
                    .UsingTemplate(body.ToString(),new {Winners=winners.TeamName,WinnerPrize=winnerPrize,RunnerUp=runnerUp,RunnerPrize=runnerPrize})
                    .Send();
                  

        }

        public static void SendEmail(string sender, string to, string subject, string body)
        {
            string email = "delali.abdallah@gmail.com";
            string pw = "xcmh bmpo rnmv aivz";

            var client = new SmtpSender(() => new SmtpClient(host: "smtp.gmail.com")
            {

                EnableSsl = true,
                Credentials = new NetworkCredential(email, pw),
                Port = 587
            });
            Email.DefaultSender = client;
            var mail = Email
                  .From(emailAddress: sender)
                  .To(emailAddress: to)
                  .Subject(subject)
                    .Body(body)
                    .Send();
        }
    }
  
}
