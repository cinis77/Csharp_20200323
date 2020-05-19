using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace _20200519_MailServisas
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("username", "password")
            };

            MailMessage message = new MailMessage();
            message.From = new MailAddress("username");
            message.To.Add("dominykas.rentelis@gmail.com");
            message.Subject = "Testas";
            message.Body = "Mano tekstas kuri as noriu siusti per cia";

            message.Attachments.Add(new Attachment("Kelias iki failo"));

            smtp.Send(message);
        }
    }
}
