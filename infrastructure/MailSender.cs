using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using skyshopCore.Models;
using MimeKit;
using MailKit.Net.Smtp;



namespace skyshopCore.infrastructure{

public class EmailSender:IEmailSender
{
        private readonly EmailSettings _emailSettings;
        // private readonly IHostingEnvironment _env;

    public EmailSender(
        IOptions<EmailSettings> emailSettings)
    {
        _emailSettings = emailSettings.Value;
        // _env=env;
    }

    public async Task SendEmailAsync(string email, string subject, string message)
    {
        try
        {
            var mimeMessage = new MimeMessage();

            mimeMessage.From.Add(new MailboxAddress(_emailSettings.SenderName, _emailSettings.Sender));

            mimeMessage.To.Add(new MailboxAddress(email));

            mimeMessage.Subject = subject;

            mimeMessage.Body = new TextPart("html")
            {
                Text = message
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                
                    await client.ConnectAsync(_emailSettings.MailServer, _emailSettings.MailPort, true);

                await client.AuthenticateAsync(_emailSettings.Sender, _emailSettings.Password);

                await client.SendAsync(mimeMessage);

                await client.DisconnectAsync(true);
            }

        }
        catch (Exception ex)
        {
           
            throw new InvalidOperationException(ex.Message);
        }
    }
}

}