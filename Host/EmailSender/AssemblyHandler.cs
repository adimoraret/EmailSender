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
        }
    }
}