using System.Net.Mail;

namespace EmailSender.Resource
{
    public interface IEmailProvider
    {
        MailMessage GetMailMessage();
    }
}