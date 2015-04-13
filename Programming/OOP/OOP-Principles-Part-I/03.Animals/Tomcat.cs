namespace _03.Animals
{
    using System;

    class Tomcat : Cat
    {
        public Tomcat(int age, string name, bool isMale)
            : base(age, name, isMale)
        {
            if (isMale == false)
            {
                throw new ArgumentException("Wrong sex. Tomcats can be only male.");
            }
        }
    }
}
