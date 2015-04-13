namespace _03.Animals
{
    using System;

    class Kitten : Cat
    {
        public Kitten(int age, string name, bool isMale)
            : base(age, name, isMale)
        {
            if (isMale == true)
            {
                throw new ArgumentException("Wrong sex. Kitten can be only female.");
            }
        }
    }
}
