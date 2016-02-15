using BusinessLogicSecuritySystem.Library;

namespace BusinessLogicSecuritySystem.Tests
{
    public class TestController
    {
        // ReSharper disable once EmptyConstructor
        public TestController()
        {
        }

        [SecurityCheck(Actions.TestControllerDoSmthAllowed)]
        public virtual void DoSmthAllowed()
        {
        }

        [SecurityCheck(Actions.TestControllerDoSmthNotAllowed)]
        public virtual void DoSmthNotAllowed()
        {
        }
    }
}