using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicSecuritySystem.Library
{
    public class Role
    {
        public IEnumerable<Actions> Actions { get; private set; }

        public Role(IEnumerable<Actions> actions)
        {
            Actions = actions;
        }

        public bool IsActionAllowed(Actions action)
        {
            return Actions.Contains(action);
        }
    }
}