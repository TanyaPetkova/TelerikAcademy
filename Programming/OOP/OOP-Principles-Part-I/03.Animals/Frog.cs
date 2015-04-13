namespace _03.Animals
{
    using System;

    class Frog : Animal
    {
        public Frog(int age, string name, bool isMale)
            : base(age, name, isMale)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Quack!");
        }
    }
}
