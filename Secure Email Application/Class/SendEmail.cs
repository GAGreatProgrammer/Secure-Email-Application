using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Secure_Email_Application.Class
{
    public static class SendEmail
    {
        public static void Send(string _To, string _Subject, string _Body)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(Properties.Settings.Default.Email);
                message.To.Add(new MailAddress(_To));
                message.Subject = _Subject;
                message.Body = _Body;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(Properties.Settings.Default.Email, Properties.Settings.Default.EmailPassword);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                GlobalVariables.EmailSent = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GlobalVariables.EmailSent = false;
            }

        }

        public static void Send(string _To, string _Subject, string _Body, List<string> _Attachments)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(Properties.Settings.Default.Email);
                message.To.Add(new MailAddress(_To));
                message.Subject = _Subject;
                message.Body = _Body;

                Attachment Attachment = null;

                foreach (string attachment in _Attachments)
                {
                    Attachment = new Attachment(attachment);
                    message.Attachments.Add(Attachment);
                }

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(Properties.Settings.Default.Email, Properties.Settings.Default.EmailPassword);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                GlobalVariables.EmailSent = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GlobalVariables.EmailSent = false;
            }

        }

        public static void SendUserInfo(bool Login)
        {
            try
            {
                if (Properties.Settings.Default.SendEmail == true)
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();

                    string LoginBody = $"{Properties.Settings.Default.Username} " +
                                   $"({Properties.Settings.Default.FirstName} {Properties.Settings.Default.LastName}) " +
                                   $"Logged in at {DateTime.Now}";

                    string LogoutBody = $"{Properties.Settings.Default.Username} " +
                                   $"({Properties.Settings.Default.FirstName} {Properties.Settings.Default.LastName}) " +
                                   $"Logged out at {DateTime.Now}";

                    message.From = new MailAddress(Properties.Settings.Default.Email);
                    message.To.Add(new MailAddress(Properties.Settings.Default.Email));
                    message.Subject = "Secure Email user activity Log";

                    if (Login == true)
                        message.Body = LoginBody;
                    else if (Login == false)
                        message.Body = LogoutBody;

                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(Properties.Settings.Default.Email, Properties.Settings.Default.EmailPassword);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                }

                else
                {
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool CheckEmailAvailability(string Email, string Password)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(Email);
                message.To.Add(new MailAddress(Email));
                message.Subject = "Email availability check";
                message.Body = $"Email availability check. {DateTime.Now}";

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(Email, Password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

    }
}
