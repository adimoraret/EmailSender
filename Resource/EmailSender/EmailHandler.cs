using Infrastructure;

namespace EmailSender.Resource
{
    public class EmailHandler : IEmailHandler
    {
        public void SendEmail()
        {
            var smtpProvider = ContaineResolver.GetInstance<ISmtpProvider>();
            var emailProvider = ContaineResolver.GetInstance<IEmailProvider>();
            var smtpClient = smtpProvider.GetStmpClient();
            var mailMessage = emailProvider.GetMailMessage();
            smtpClient.Send(mailMessage);
        }
    }
}