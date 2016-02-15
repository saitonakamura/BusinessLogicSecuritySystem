using System;

namespace BusinessLogicSecuritySystem.Library
{
    public class SecurityCheckAttribute : Attribute
    {
        public Actions Action { get; private set; }

        public SecurityCheckAttribute(Actions action)
        {
            Action = action;
        }
    }
}