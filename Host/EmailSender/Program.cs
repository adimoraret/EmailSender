using EmailSender.Manager;
using Infrastructure;

namespace EmailSender.Host
{
    public class Program
    {
        public void Run()
        {
            var emailSenderManager = ContaineResolver.GetInstance<IEmailSenderManager>(); 
            emailSenderManager.SendEmail();
        }

        public static void Main(string[] args)
        {
            var assemblyHandler = new AssemblyHandler();
            assemblyHandler.RegisterAllAssemblies();

            var program = new Program();
            program.Run();
        }
    }
}