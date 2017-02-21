using System.Net;
using System.Net.Mail;
using Infrastructure;

namespace EmailSender.Resource
{
    public class SmtpProvider : ISmtpProvider
    {
        public SmtpClient GetStmpClient()
        {
            var configuration = ContaineResolver.GetInstance<ISmtpConfiguration>();
            return new SmtpClient
            {
                Host = configuration.GetHost(),
                Port = configuration.GetPort(),
                EnableSsl = configuration.GetEnableSsl(),
                DeliveryMethod = configuration.GetDeliveryMethod(),
                UseDefaultCredentials = configuration.GetUseDefaultCredentials(),
                Credentials = new NetworkCredential(configuration.GetFromAddress(), configuration.GetFromPassword())
            };
        }
    }
}