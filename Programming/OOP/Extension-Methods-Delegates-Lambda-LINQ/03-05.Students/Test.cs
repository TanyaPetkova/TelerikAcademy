namespace _03_05.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Ivan", "Georgiev", 20));
            listOfStudents.Add(new Student("Georgi", "Ivanov", 21));
            listOfStudents.Add(new Student("Hristo", "Georgiev", 22));
            listOfStudents.Add(new Student("Hristo", "Petrov", 23));
            listOfStudents.Add(new Student("Petar", "Hristov", 25));

            Console.WriteLine("List of all students whose first name is before its last name alphabetically:");

            //using LINQ query
            var query3 =
                from Student in listOfStudents
                where string.Compare(Student.FirstName, Student.LastName) < 0
                select Student;

            Console.WriteLine(string.Join("\n", query3));
            Console.WriteLine();

            //using lamba expression
            Console.WriteLine(string.Join("\n", listOfStudents.FindAll(x => string.Compare(x.FirstName, x.LastName) < 0)));
            Console.WriteLine();

            Console.WriteLine("List of all students with age between 18 and 24:");

            //using LINQ query
            var query4 =
                from Student in listOfStudents
                where Student.Age >= 18 && Student.Age <= 24
                select new { Student.FirstName, Student.LastName };

            Console.WriteLine(string.Join("\n", query4));
            Console.WriteLine();

            //using lamba expression
            Console.WriteLine(string.Join("\n", listOfStudents.FindAll(x => x.Age >= 18 && x.Age <= 24).Select(x => new { x.FirstName, x.LastName })));
            Console.WriteLine();

            Console.WriteLine("List of students, sorted by first name and last name in descending order");

            //using LINQ query
            var query5 =
                from Student in listOfStudents
                orderby Student.FirstName descending, Student.LastName descending
                select Student;

            Console.WriteLine(string.Join("\n", query5));
            Console.WriteLine();
                
            //using lamba expression
            Console.WriteLine(string.Join("\n", listOfStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName)));
        }
    }
}
