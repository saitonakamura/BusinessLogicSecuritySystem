using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicSecuritySystem.Library
{
    public class User
    {
        public IEnumerable<Role> Roles { get; private set; }

        public User(IEnumerable<Role> roles)
        {
            Roles = roles;
        }

        public bool IsActionNotAllowed(Actions action)
        {
            return Roles.Any(x => x.IsActionAllowed(action)) == false;
        }
    }
}