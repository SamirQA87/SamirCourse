using System;
using System.IO;
using System.Net.Mail;

namespace SamirCourse
{
    public class Functions
    {
        public static string SendEmailAttachment(string subject, string body)
        {
            string message = "";

            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.mail.yahoo.com");
                mail.From = new MailAddress("samir.rizvanovic@yahoo.com");
                mail.To.Add("samir.rizvanovic@yahoo.com");
                mail.Subject = subject;
                mail.Body = body;

                //System.Net.Mail.Attachment attachment;
                //attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
                //mail.Attachments.Add(attachment);

                DirectoryInfo d = new DirectoryInfo(@"C:/Screenshot/");
                FileInfo[] Files = d.GetFiles("*.jpeg", SearchOption.AllDirectories);


                SmtpServer.Port = 446;
                SmtpServer.Credentials = new System.Net.NetworkCredential("samir.rizvanovic@yahoo.com", "fiatunoturbo13.8");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception e)
            {
                message += "Error!!!" + e.Message;
            }

            return message;
        }
        public static void WriteInto(string readText)
        {
            string filePath = @"C:\TestConfiguration\LogFile.txt";

            File.AppendAllText(filePath, readText  + Environment.NewLine);
        }

        public static void TakeScreenShot(string readText)
        {
            string filePath = @"C:\TestConfiguration\LogFile.txt";

            File.AppendAllText(filePath, readText + Environment.NewLine);
        }

    }
}
