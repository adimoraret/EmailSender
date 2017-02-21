using Infrastructure;
using NUnit.Framework;

namespace EmailSender.Resource.Test
{
    [TestFixture]
    [Explicit("Integration test. It will actually send emails")]
    public class EmailHandlerIntegrationTest
    {
        private IEmailHandler _sut;

        [OneTimeSetUp]
        public void OnTimeSetUp()
        {
            ContaineResolver.Register<IEmailMessageConfiguration, EmailMessageConfiguration>();
            ContaineResolver.Register<ISmtpConfiguration, SmtpConfiguration>();
            ContaineResolver.Register<ISmtpProvider, SmtpProvider>();
            ContaineResolver.Register<IEmailProvider, EmailProvider>();
        }

        [SetUp]
        public void SetUp()
        {
            _sut = new EmailHandler();
        }

        [Test]
        public void ShouldSendEmail()
        {
            _sut.SendEmail();
        }
    }
}
