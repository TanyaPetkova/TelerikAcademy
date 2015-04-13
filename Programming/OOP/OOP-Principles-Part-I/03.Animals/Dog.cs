namespace _03.Animals
{
    using System;

    class Dog : Animal
    {
        public Dog(int age, string name, bool isMale)
            : base(age, name, isMale)
        {
   
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bau!"); ;
        }
    }
}
