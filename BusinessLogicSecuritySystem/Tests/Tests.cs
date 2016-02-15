using System.Security;
using Autofac;
using NUnit.Framework;

namespace BusinessLogicSecuritySystem.Tests
{
    [TestFixture]
    public class Tests
    {
        private IContainer _container;

        [TestFixtureSetUp]
        public void SetUp()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<TestModule>();
            _container = builder.Build();
        }

        [Test]
        public void TestAllowed()
        {
            var testController = _container.Resolve<TestController>();

            testController.DoSmthAllowed();
        }

        [Test]
        public void TestNotAllowed()
        {
            var testController = _container.Resolve<TestController>();

            Assert.Throws<SecurityException>(() => testController.DoSmthNotAllowed());
        }
    }
}