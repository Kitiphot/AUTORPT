using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Services
{
    public interface IEmailMessageService
    {
        bool SendMailMessage(MailMessage MailMessage);
        bool SendMailMessage(string[] Tos, string Subject, string Message, string[] CCs = null, string[] BCCs = null);
        bool SendMailMessage(string[] Tos, string Subject, string Message, List<Attachment> Attachments, string[] CCs = null, string[] BCCs = null);
        bool SendMailMessageAsync(MailMessage MailMessage);
        bool SendMailMessageAsync(string[] Tos, string Subject, string Message, string[] CCs = null, string[] BCCs = null);
        bool SendMailMessageAsync(string[] Tos, string Subject, string Message, List<Attachment> Attachments, string[] CCs = null, string[] BCCs = null);
    }
}