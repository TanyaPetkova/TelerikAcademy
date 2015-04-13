namespace _03.Animals
{
    using System;
    using System.Linq;

    public abstract class Animal : ISound
    {
        public int Age { get; private set; }
        public string Name { get; private set; }
        public bool IsMale { get;  private set; }

        public Animal(int age, string name, bool isMale)
        {
            this.Age = age;
            this.Name = name;
            this.IsMale = isMale;
        }

        public abstract void ProduceSound();

        public static void CalcAverageAge(Animal[] animals)
        {
            var groupedAnimals = animals.GroupBy(x => x.GetType());

            foreach (var animal in groupedAnimals)
            {
                Console.WriteLine("{0} - {1}", animal.Key.Name, animal.Average(x => x.Age));
            }
        }
    }
}
