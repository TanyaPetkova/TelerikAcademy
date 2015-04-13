namespace _03.Animals
{
    using System;

    public abstract class Cat : Animal
    {
        public Cat(int age, string name, bool isMale)
            : base(age, name, isMale)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Myaau!");
        }
    }
}
