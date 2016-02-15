using Autofac;
using Autofac.Extras.DynamicProxy2;
using BusinessLogicSecuritySystem.Library;

namespace BusinessLogicSecuritySystem.Tests
{
    public class TestModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var testRole = new Role(new[] { Actions.TestControllerDoSmthAllowed, });

            builder.Register(x => new User(new[] { testRole }));

            builder.RegisterType<SecurityInterceptor>();

            builder.RegisterType<TestController>()
                .EnableClassInterceptors()
                .InterceptedBy(typeof(SecurityInterceptor));
        }
    }
}