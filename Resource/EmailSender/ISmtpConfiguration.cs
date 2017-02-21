using System.Net.Mail;

namespace EmailSender.Resource
{
    public interface ISmtpConfiguration
    {
        bool GetEnableSsl();
        bool GetUseDefaultCredentials();
        string GetHost();
        string GetFromAddress();
        string GetFromPassword();
        int GetPort();
        SmtpDeliveryMethod GetDeliveryMethod();
    }
}