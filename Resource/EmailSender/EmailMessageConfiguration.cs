using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Mail;

namespace EmailSender.Resource
{
    public class EmailMessageConfiguration : IEmailMessageConfiguration
    {
        public string GetContent()
        {
            return ConfigurationManager.AppSettings["Content"];
        }

        public string GetSubject()
        {
            return ConfigurationManager.AppSettings["Subject"];
        }

        public bool GetIsHtml()
        {
            return Convert.ToBoolean(ConfigurationManager.AppSettings["IsHtml"]);
        }

        public IEnumerable<string> GetTo()
        {
            return ConfigurationManager.AppSettings["To"].Split(',');
        }

        public IEnumerable<string> GetCc()
        {
            return ConfigurationManager.AppSettings["Cc"].Split(',');
        }

        public IEnumerable<string> GetBcc()
        {
            return ConfigurationManager.AppSettings["Bcc"].Split(',');
        }

        public MailAddress GetFromAddress()
        {
            return new MailAddress(ConfigurationManager.AppSettings["FromAddress"]);
        }
    }
}