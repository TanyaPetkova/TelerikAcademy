namespace _02.Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Georgi", "Ivanov", 5));
            students.Add(new Student("Ivan", "Georgiev", 2));
            students.Add(new Student("Hristo", "Petrov", 4));
            students.Add(new Student("Petar", "Hristov", 6));
            students.Add(new Student("Georgi", "Hristov", 3));
            students.Add(new Student("Ivan", "Hristov", 5));
            students.Add(new Student("Hristo", "Georgiev", 3));
            students.Add(new Student("Petar", "Ivanov", 2));
            students.Add(new Student("Georgi", "Petrov", 6));
            students.Add(new Student("Ivan", "Petrov", 4));

            Console.WriteLine("List of all students, sorted by grade in ascending order:");

            //using LINQ query
            var studentsQuery =
                from Student in students
                orderby Student.Grade
                select new { Student.FirstName, Student.LastName, Student.Grade };

            Console.WriteLine(string.Join("\n", studentsQuery));
            Console.WriteLine();

            //using lamba expression
            //Console.WriteLine(string.Join("\n", students.OrderBy(x => x.Grade).Select(x => new { x.FirstName, x.LastName, x.Grade })));
            //Console.WriteLine();

            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Aleksandar", "Petkov", 400, 8));
            workers.Add(new Worker("Petko", "Aleksandrov", 400, 6));
            workers.Add(new Worker("Stoyan", "Rumenov", 300, 8));
            workers.Add(new Worker("Rumen", "Stoyanov", 300, 6));
            workers.Add(new Worker("Aleksandar", "Stoyanov", 500, 8));
            workers.Add(new Worker("Stoyan", "Aleksandrov", 500, 6));
            workers.Add(new Worker("Petko", "Rumenov", 450, 8));
            workers.Add(new Worker("Rumen", "Petkov", 450, 6));
            workers.Add(new Worker("Aleksandar", "Rumenov", 350, 8));
            workers.Add(new Worker("Rumen", "Aleksandrov", 350, 6));

            Console.WriteLine("List of all workers, sorted by money per hour in descending order:");

            //using LINQ query
            var workersQuery =
                from Worker in workers
                orderby Worker.MoneyPerHour()
                select new { Worker.FirstName, Worker.LastName, Money = Worker.MoneyPerHour() };

            Console.WriteLine(string.Join("\n", workersQuery));
            Console.WriteLine();

            //using lamba expression
            //Console.WriteLine(string.Join("\n", workers.OrderBy(x => x.MoneyPerHour()).Select(x => new { x.FirstName, x.LastName, Money = x.MoneyPerHour() })));
            //Console.WriteLine();

            Console.WriteLine("List of both students and workers, sorted by first name and last name:");

            List<Human> humans = new List<Human>();

            humans.AddRange(students);
            humans.AddRange(workers);

            //using LINQ query
            var humansQuery =
                from Human in humans
                orderby Human.FirstName, Human.LastName                
                select new { Human.FirstName, Human.LastName};

            Console.WriteLine(string.Join("\n", humansQuery));
            Console.WriteLine();

            //using lamba expression
            //Console.WriteLine(string.Join("\n", humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).Select(x => new { x.FirstName, x.LastName})));
        }
    }
}
