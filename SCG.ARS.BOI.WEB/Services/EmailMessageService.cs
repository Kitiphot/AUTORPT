using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NLog;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Helpers;

namespace SCG.ARS.BOI.WEB.Services
{
    public class EmailMessageService : IEmailMessageService
    {
        static Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IConfiguration _configuration;
        private static SmtpSetting _config;
        private static SmtpClientEx _smtpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private bool SendMailCompleted = true;
        public EmailMessageService(IConfiguration configuration,
            IOptions<SmtpSetting> config,
            SmtpClientEx smtpClient,
            IHttpContextAccessor httpContextAccessor
            )
        {
            _configuration = configuration;
            _config = config.Value;
            _smtpClient = smtpClient;
            _httpContextAccessor = httpContextAccessor;
        }

        public bool SendMailMessage(MailMessage MailMessage)
        {
            return Send(MailMessage);
        }

        public bool SendMailMessage(string[] Tos, string Subject, string Message, string[] CCs = null, string[] BCCs = null)
        {
            var result = false;
            try
            {
                var mail = new MailMessage()
                {
                    From = new MailAddress(_config.From),

                    Subject = Subject,
                    Body = Message
                };

                if (Tos != null)
                    foreach (var to in Tos)
                        mail.To.Add(to);

                if (CCs != null)
                    foreach (var cc in CCs)
                        mail.CC.Add(cc);

                if (BCCs != null)
                    foreach (var bcc in BCCs)
                        mail.Bcc.Add(bcc);

                result = Send(mail);
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Exception on SendMailMessage");
            }
            return result;
        }

        public bool SendMailMessage(string[] Tos, string Subject, string Message, List<Attachment> Attachments, string[] CCs = null, string[] BCCs = null)
        {
            var result = false;
            try
            {
                var mail = new MailMessage()
                {
                    From = new MailAddress(_config.From),

                    Subject = Subject,
                    Body = Message
                };

                if (Tos != null)
                    foreach (var to in Tos)
                        mail.To.Add(to);

                if (CCs != null)
                    foreach (var cc in CCs)
                        mail.CC.Add(cc);

                if (BCCs != null)
                    foreach (var bcc in BCCs)
                        mail.Bcc.Add(bcc);

                if (Attachments != null)
                    foreach (var attachment in Attachments)
                        mail.Attachments.Add(attachment);

                result = Send(mail);
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Exception on SendMailMessage");
            }
            return result;
        }

        public bool SendMailMessageAsync(MailMessage MailMessage)
        {
            return SendMailAsync(MailMessage);
        }

        public bool SendMailMessageAsync(string[] Tos, string Subject, string Message, string[] CCs = null, string[] BCCs = null)
        {
            var result = false;
            try
            {
                var mail = new MailMessage()
                {
                    From = new MailAddress(_config.From),

                    Subject = Subject,
                    Body = Message
                };

                if (Tos != null)
                    foreach (var to in Tos)
                        mail.To.Add(to);

                if (CCs != null)
                    foreach (var cc in CCs)
                        mail.CC.Add(cc);

                if (BCCs != null)
                    foreach (var bcc in BCCs)
                        mail.Bcc.Add(bcc);

                result = SendMailAsync(mail);
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Exception on SendMailMessageAsync");
            }
            return result;
        }

        public bool SendMailMessageAsync(string[] Tos, string Subject, string Message, List<Attachment> Attachments, string[] CCs = null, string[] BCCs = null)
        {
            var result = false;
            try
            {
                var mail = new MailMessage()
                {
                    From = new MailAddress(_config.From),

                    Subject = Subject,
                    Body = Message
                };

                if (Tos != null)
                    foreach (var to in Tos)
                        mail.To.Add(to);

                if (CCs != null)
                    foreach (var cc in CCs)
                        mail.CC.Add(cc);

                if (BCCs != null)
                    foreach (var bcc in BCCs)
                        mail.Bcc.Add(bcc);

                if (Attachments != null)
                    foreach (var attachment in Attachments)
                        mail.Attachments.Add(attachment);

                result = SendMailAsync(mail);
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Exception on SendMailMessageAsync");
            }
            return result;
        }
        private bool Send(MailMessage MailMessage)
        {
            var result = false;
            try
            {

                _smtpClient.Send(MailMessage);
                result = true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Exception on internal method Send.");
            }
            return result;
        }
        private bool SendMailAsync(MailMessage MailMessage)
        {
            Task task = null;
            var result = false;
            try
            {
                _smtpClient.SendCompleted += (sender, e) =>
                {
                    var completeSource = (TaskCompletionSource<object>)e.UserState;

                    if (e.Cancelled)
                        logger.Warn("E-mail Cancelled.");
                    else if (e.Error != null)
                        logger.Error(e.Error, "E-mail Error.");
                    else
                    {
                        logger.Info("E-mail Sent.");
                        result = true;
                    }
                    SendMailCompleted = true;
                };

                if (SendMailCompleted)
                {
                    task = _smtpClient.SendMailAsync(MailMessage);
                    SendMailCompleted = false;
                    Console.WriteLine($"{DateTime.Now}: send email started.");
                }
                else
                    Console.WriteLine($"{DateTime.Now}: send email processing.");
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Exception on internal method SendMailAsync.");
            }
            return result;
        }
    }
}