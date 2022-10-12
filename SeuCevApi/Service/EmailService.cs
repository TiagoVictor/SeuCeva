using Microsoft.Extensions.Options;
using SeuCevApi.Service.Interface;
using System.Net;
using System.Net.Mail;

namespace SeuCevApi.Service
{
    public class EmailService : IEmailService
    {
        public EmailSettings _emailSettings { get; }

        public EmailService(IOptions<EmailSettings> emailsettings)
        {
            _emailSettings = emailsettings.Value;
        }
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                await Execute(email, subject, message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Execute(string email, string subject, string message)
        {
            try
            {
                string toEmail = string.IsNullOrEmpty(email) ? _emailSettings.ToEmail : email;

                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(_emailSettings.UsernameEmail, "Panch Development")
                };

                mail.To.Add(new MailAddress(toEmail));

                mail.Subject = "Seu Ceva - " + subject;
                mail.Body = message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                if(1 == 2)
                {
                    // Quando houver anexo
                    mail.Attachments.Add(new Attachment("teste"));
                }

                using (SmtpClient smtp = new SmtpClient(_emailSettings.PrimaryDomain, _emailSettings.PrimaryPort))
                {
                    smtp.Credentials = new NetworkCredential(_emailSettings.UsernameEmail, _emailSettings.UsernamePassword);
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
