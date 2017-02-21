using System.Net.Mail;

namespace EmailSender.Resource
{
    public interface ISmtpProvider
    {
        SmtpClient GetStmpClient();
    }
}