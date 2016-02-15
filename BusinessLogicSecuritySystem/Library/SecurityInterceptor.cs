using System;
using System.Security;
using Castle.DynamicProxy;

namespace BusinessLogicSecuritySystem.Library
{
    public class SecurityInterceptor : IInterceptor
    {
        private readonly User _user;

        public SecurityInterceptor(User user)
        {
            _user = user;
        }

        public void Intercept(IInvocation invocation)
        {
            var attribute = (SecurityCheckAttribute) Attribute.GetCustomAttribute(invocation.Method, typeof(SecurityCheckAttribute));

            if (attribute != null && _user.IsActionNotAllowed(attribute.Action))
                throw new SecurityException("Security alarm! Call not allowed!");

            invocation.Proceed();
        }
    }
}
