using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using MimeKit; 

namespace MOEN_ERP.API.Services.Repository
{
    public interface IMailService
    {
        bool SendMail(MailData mailData);
    }

    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(IOptions<MailSettings> mailSettingsOptions)
        {
            _mailSettings = mailSettingsOptions.Value;
        }
        public bool SendMail(MailData mailData)
        {
            try
            {
                using (MimeMessage emailMessage = new MimeMessage())
                {
                    MailboxAddress emailFrom = new MailboxAddress(_mailSettings.SenderName, _mailSettings.SenderEmail);
                    emailMessage.From.Add(emailFrom);
                    MailboxAddress emailTo = new MailboxAddress(mailData.EmailToName, mailData.EmailToId);
                    emailMessage.To.Add(emailTo);

                    //emailMessage.Cc.Add(new MailboxAddress("Cc Receiver", "cc@example.com"));
                    //emailMessage.Bcc.Add(new MailboxAddress("Bcc Receiver", "bcc@example.com"));

                    emailMessage.Subject = mailData.EmailSubject;

                    BodyBuilder emailBodyBuilder = new BodyBuilder();
                    if (mailData.IsHtml == true)
                        emailBodyBuilder.HtmlBody = mailData.EmailBody;
                    else
                        emailBodyBuilder.TextBody = mailData.EmailBody;

                    if (mailData.Attachment != null && mailData.Attachment.Count > 0)
                    {
                        foreach (var att in mailData.Attachment)
                        {
                            emailBodyBuilder.Attachments.Add(att.Filename, att.FileData);
                        }
                    }                     

                    emailMessage.Body = emailBodyBuilder.ToMessageBody(); 

                    //this is the SmtpClient from the Mailkit.Net.Smtp namespace, not the System.Net.Mail one
                    using (SmtpClient mailClient = new SmtpClient())
                    {                        
                        mailClient.ServerCertificateValidationCallback = (s, c, h, e) => true;
                        mailClient.CheckCertificateRevocation = false;
                        mailClient.Connect(_mailSettings.Server, _mailSettings.Port, MailKit.Security.SecureSocketOptions.StartTlsWhenAvailable);
                        if (_mailSettings.NeedAuthen) mailClient.Authenticate(_mailSettings.UserName, _mailSettings.Password);
                        mailClient.Send(emailMessage);
                        mailClient.Disconnect(true);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                // Exception Details
                return false;
            }
        }
    }
    public class MailSettings
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool NeedAuthen { get; set; } = true;
    }
    public class MailData
    {
        public MailData()
        { 
            IsHtml = false;
        }

        public string EmailToId { get; set; }
        public string EmailToName { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public bool IsHtml { get; set; }
        public List<MailAttach> Attachment { get; set; }
    }

    public class MailAttach
    {
        public string Filename { get; set; }
        public byte[] FileData { get; set; }
    }
}


