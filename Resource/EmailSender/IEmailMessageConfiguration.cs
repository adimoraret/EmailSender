using System.Collections.Generic;
using System.Net.Mail;

namespace EmailSender.Resource
{
    public interface IEmailMessageConfiguration
    {
        string GetContent();
        string GetSubject();
        bool GetIsHtml();
        IEnumerable<string> GetTo();
        IEnumerable<string> GetCc();
        IEnumerable<string> GetBcc();
        MailAddress GetFromAddress();
    }
}