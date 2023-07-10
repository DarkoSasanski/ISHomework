using MailKit.Security;
using MimeKit;
using MovieTickets.Domain.Domain;
using MovieTickets.Domain;
using MovieTickets.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieTickets.Service.Implementations
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings settings;

        public EmailService(EmailSettings settings)
        {
            this.settings = settings;
        }

        public async Task SendEmails(List<EmailMessage> messages)
        {
            List<MimeMessage> emails = new List<MimeMessage>();
            foreach (var e in messages)
            {
                MimeMessage emailMessage = new MimeMessage();
                emailMessage.Sender = new MailboxAddress(settings.SenderName, settings.SmtpUserName);
                emailMessage.Subject = e.Subject;
                emailMessage.To.Add(new MailboxAddress(e.MailTo, e.MailTo));
                emailMessage.From.Add(new MailboxAddress(settings.SmtpDisplayName, settings.SmtpUserName));
                emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Plain) { Text = e.Body };
                emails.Add(emailMessage);
            }
            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                var socketOptions = settings.UseSsl ? SecureSocketOptions.StartTls : SecureSocketOptions.Auto;
                smtp.CheckCertificateRevocation = false;
                await smtp.ConnectAsync(settings.SmtpServer, settings.SmtpServerPort, socketOptions);
                smtp.AuthenticationMechanisms.Remove("XOAUTH2");
                if (!String.IsNullOrEmpty(settings.SmtpUserName))
                {
                    await smtp.AuthenticateAsync(settings.SmtpUserName, settings.SmtpPassword);
                }
                foreach (var item in emails)
                {
                    await smtp.SendAsync(item);
                }
                await smtp.DisconnectAsync(true);
            }
        }
    }
}
