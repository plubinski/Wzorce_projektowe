using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SendEmail("michal.wereski@sagitum.pl", "<b>AAAAAA</b>");
        }

        public static void SendEmail(string toEmail, string htmlBodyText)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("robot@sagitum.com.pl"));
                email.To.Add(MailboxAddress.Parse(toEmail));
                email.Subject = "TEST";
                email.Bcc.Add(MailboxAddress.Parse("robot@sagitum.com.pl"));

                var body = new TextPart(MimeKit.Text.TextFormat.Html)
                {
                    Text = string.Format(htmlBodyText)
                };

                var multipart = new Multipart("mixed");
                multipart.Add(body);

                email.Body = multipart;

                using (var smtp = new SmtpClient())
                {
                    smtp.Connect("sagitum.com.pl", 587, SecureSocketOptions.None);
                    smtp.Authenticate("robot@sagitum.com.pl", "hWUo2gvM111129@");

                    smtp.Send(email);
                    smtp.Disconnect(true);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            // Credentials are necessary if the server requires the client
            // to authenticate before it will send email on the client's behalf.
            // client.UseDefaultCredentials = true;
        }
    }
}
