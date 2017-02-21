using EmailSender.Resource;
using Infrastructure;

namespace EmailSender.Manager
{
    public class EmailSenderManager : IEmailSenderManager
    {
        public void SendEmail()
        {
            var emailHandler = ContaineResolver.GetInstance<IEmailHandler>();
            emailHandler.SendEmail();
        }
    }
}