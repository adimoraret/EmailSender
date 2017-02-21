using System;
using System.Configuration;
using System.Net.Mail;

namespace EmailSender.Resource
{
    public class SmtpConfiguration : ISmtpConfiguration
    {
        public bool GetEnableSsl()
        {
            return Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
        }

        public bool GetUseDefaultCredentials()
        {
            return Convert.ToBoolean(ConfigurationManager.AppSettings["UseDefaultCredentials"]);
        }

        public string GetHost()
        {
            return ConfigurationManager.AppSettings["Host"];
        }

        public string GetFromAddress()
        {
            return ConfigurationManager.AppSettings["FromAddress"];
        }

        public string GetFromPassword()
        {
            return ConfigurationManager.AppSettings["FromPassword"];
        }

        public int GetPort()
        {
            return Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);
        }

        public SmtpDeliveryMethod GetDeliveryMethod()
        {
            var method = ConfigurationManager.AppSettings["DeliveryMethod"];
            return (SmtpDeliveryMethod) Enum.Parse(typeof(SmtpDeliveryMethod), method);
        }
    }
}