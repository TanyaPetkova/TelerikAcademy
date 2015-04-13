namespace Person
{
    using System;

    class Test
    {
        static void Main()
        {
            Person person = new Person("Pesho");
            Console.WriteLine(person);
            Console.WriteLine();

            person.Age = 20;
            Console.WriteLine(person);
        }
    }
}
