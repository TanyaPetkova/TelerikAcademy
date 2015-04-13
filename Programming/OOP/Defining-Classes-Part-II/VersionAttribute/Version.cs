namespace VersionAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | 
                    AttributeTargets.Class | 
                    AttributeTargets.Interface | 
                    AttributeTargets.Enum | 
                    AttributeTargets.Method)
    ]

    public class VersionAttribute : System.Attribute
    {
        private int major;
        private int minor;

        public VersionAttribute(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public override string ToString()
        {
            return this.major + "." + this.minor;
        }
    }
}
