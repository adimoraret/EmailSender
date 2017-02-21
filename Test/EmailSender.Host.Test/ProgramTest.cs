using EmailSender.Manager;
using Infrastructure;
using Moq;
using NUnit.Framework;

namespace EmailSender.Host.Test
{
    [TestFixture]
    public class ProgramTest
    {
        private Mock<IEmailSenderManager> _emailSenderManager;
        private Program _sut;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _emailSenderManager = new Mock<IEmailSenderManager>(MockBehavior.Strict);
            ContaineResolver.Register(() => _emailSenderManager.Object);
        }

        [SetUp]
        public void SetUp()
        {
            _sut = new Program();
        }

        [Test]
        public void ShouldRunProgramEntryClass()
        {
            _emailSenderManager
                .Setup(x => x.SendEmail());

            _sut.Run();
        }

        [TearDown]
        public void TearDown()
        {
            _emailSenderManager.VerifyAll();
        }
    }
}