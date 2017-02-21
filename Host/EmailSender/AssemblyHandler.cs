using EmailSender.Manager;
using EmailSender.Resource;
using Infrastructure;

namespace EmailSender.Host
{
    public class AssemblyHandler
    {
        public void RegisterAllAssemblies()
        {
            ContaineResolver.Register<IEmailSenderManager, EmailSenderManager>();
            ContaineResolver.Register<IEmailHandler, EmailHandler>();
            ContaineResolver.Register<ISmtpConfiguration, SmtpConfiguration>();
            ContaineResolver.Register<ISmtpProvider, SmtpProvider>();
            ContaineResolver.Register<IEmailMessageConfiguration, EmailMessageConfiguration>();
            ContaineResolver.Register<IEmailProvider, EmailProvider>();
        }
    }
}