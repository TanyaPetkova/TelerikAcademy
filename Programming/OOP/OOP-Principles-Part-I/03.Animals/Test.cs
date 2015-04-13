namespace _03.Animals
{
    using System;

    class Test
    {
        static void Main()
        {
            Animal[] animals =
            {
                new Dog(5, "Pesho", true),
                new Dog(3, "Ivan", true),
                new Frog(2, "Gosho", true),
                new Frog(1, "Sisi", false),
                new Kitten(1, "Mimi", false),
                new Kitten(6, "Gabi", false),
                new Tomcat(2, "Ivan", true),
                new Tomcat(4, "Toshko", true),
            };

            foreach (Animal animal in animals)
            {
                animal.ProduceSound();
            }

            Animal.CalcAverageAge(animals);
        }
    }
}
