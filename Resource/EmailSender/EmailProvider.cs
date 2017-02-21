using System.Collections.Generic;
using System.Net.Mail;
using Infrastructure;

namespace EmailSender.Resource
{
    public class EmailProvider : IEmailProvider
    {
        public MailMessage GetMailMessage()
        {
            var configuration = ContaineResolver.GetInstance<IEmailMessageConfiguration>();
            var mailMessage = new MailMessage
            {
                From = configuration.GetFromAddress(),
                Body = configuration.GetContent(),
                Subject = configuration.GetSubject(),
                IsBodyHtml = configuration.GetIsHtml()
            };
            AddRecipients(mailMessage.To, configuration.GetTo());
            return mailMessage;
        }

        private static void AddRecipients(MailAddressCollection smptRecipients, IEnumerable<string> contractRecipients)
        {
            foreach (var contractRecipient in contractRecipients)
            {
                smptRecipients.Add(contractRecipient);
            }
        }
    }
}