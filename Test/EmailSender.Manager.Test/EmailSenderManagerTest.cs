using EmailSender.Resource;
using Infrastructure;
using Moq;
using NUnit.Framework;

namespace EmailSender.Manager.Test
{
    [TestFixture]
    public class EmailSenderManagerTest
    {
        private IEmailSenderManager _sut;
        private Mock<IEmailHandler> _emailHandler;

        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            _emailHandler = new Mock<IEmailHandler>(MockBehavior.Strict);
            ContaineResolver.Register(() => _emailHandler.Object);
        }

        [SetUp]
        public void SetUp()
        {
            _sut = new EmailSenderManager();
        }

        [Test]
        public void ShouldSendEmail()
        {
            _emailHandler
                .Setup(x => x.SendEmail());

            _sut.SendEmail();
        }

        [TearDown]
        public void TearDown()
        {
            _emailHandler.VerifyAll();
        }
    }
}