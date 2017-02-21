using NUnit.Framework;

namespace Infrastructure.Test
{
    [TestFixture]
    public class ContainerResolverTest
    {
        [OneTimeSetUp]
        public void OnTimeSetUp()
        {
           ContaineResolver.Register<IService, Service>();
        }

        [Test]
        public void ShouldGetInstance()
        {
            var instance = ContaineResolver.GetInstance<IService>();
            Assert.That(instance, Is.TypeOf<Service>());
        }
    }
}