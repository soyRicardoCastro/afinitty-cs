using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Web;

namespace ReachSystem
{
    public class Timer
    {
        
        private System.Threading.Timer timer;
        private void SetUpTimer(TimeSpan alertTime)
        {
            DateTime current = DateTime.Now;
            TimeSpan timeToGo = alertTime - current.TimeOfDay;
            if (timeToGo < TimeSpan.Zero)
            {
                return;//time already passed
            }
            this.timer = new System.Threading.Timer(x =>
            {
                this.SomeMethodRunsAt1600();
            }, null, timeToGo, Timeout.InfiniteTimeSpan);
        }

        private void SomeMethodRunsAt1600()
        {
            SetUpTimer(new TimeSpan(08, 47, 00));
            string body = "<body>" +
                        "<h4>Dear: Oscar</h4>" +
                        "<h4>You have been approved as a user of the Tarrago Reach System.</h4>" +
                        "<h4>Remember that you can access with www.reach.tarrago.com</h4>" +
                        "<h4>Kind regards,</h4>" +
                        "<h4>Tarrago Brands International.</h4>" +
                        "<img  src='https://www.tarrago.com/wp-content/uploads/2019/07/logo-tarrago-web.png' />" +
                        "</body>";
            SmtpClient smtp = new SmtpClient();
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.tarragobrands.somee.com";
            smtp.Port = 26;
            smtp.Credentials = new NetworkCredential("noreply@tarragobrands.somee.com", "Otto.123");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;



            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("noreply@tarragobrands.somee.com", "Tarrago Brands International");
            mail.To.Add(new MailAddress("operezlugo@gmail.com"));
            mail.Subject = "Your Reach System Registration has been approved";
            mail.IsBodyHtml = true;
            mail.Body = body;

            smtp.Send(mail);


        }

    }
}