using Infrastructure.Test.Services;
using NUnit.Framework;

namespace Infrastructure.Test
{
    [TestFixture]
    public class ContainerResolverTest
    {
        [OneTimeSetUp]
        public void OnTimeSetUp()
        {
           ContaineResolver.Register<IService1, Service1>();
           ContaineResolver.Register<IService2>(() => new Service2());
        }

        [Test]
        public void ShouldGetService1Instance()
        {
            var instance = ContaineResolver.GetInstance<IService1>();
            Assert.That(instance, Is.TypeOf<Service1>());
        }

        [Test]
        public void ShouldGetService2Instance()
        {
            var instance = ContaineResolver.GetInstance<IService2>();
            Assert.That(instance, Is.TypeOf<Service2>());
        }
    }
}