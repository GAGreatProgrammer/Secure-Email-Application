using MimeKit;
using System.IO;
using System.Collections.Generic;

namespace Secure_Email_Application.Class
{
    public static class GetEmail
    {
        public static string EmailID = null;
        public static string From = null;
        public static string Subject = null;
        public static string Body = null;
        public static string DateTime = null;

        public static List<string> EmailAttachmentsFileNames = null;

        public static void GetEmailAttachments(string EmailFile, string AttachmentsPath)
        {
            var message = MimeMessage.Load(EmailFile);

            foreach (var attachment in message.Attachments)
            {
                var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;

                using (var stream = File.Create(AttachmentsPath + fileName))
                {
                    if (attachment is MessagePart)
                    {
                        var rfc822 = (MessagePart)attachment;

                        rfc822.Message.WriteTo(stream);
                    }
                    else
                    {
                        var part = (MimePart)attachment;

                        part.Content.DecodeTo(stream);
                    }
                }
            }
        }


        public static void GetEmailAttachmentsFileName(string EmailFile)
        {
            var message = MimeMessage.Load(EmailFile);
            EmailAttachmentsFileNames = new List<string>();

            foreach (var attachment in message.Attachments)
            {
                var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;
                EmailAttachmentsFileNames.Add(fileName);
            }
        }

        public static void GetEmailText(string EmailFile)
        {
            var message = MimeMessage.Load(EmailFile);

            EmailID = message.MessageId;
            From = message.From.ToString();
            Subject = message.Subject;
            Body = message.TextBody;
            DateTime = message.Date.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
