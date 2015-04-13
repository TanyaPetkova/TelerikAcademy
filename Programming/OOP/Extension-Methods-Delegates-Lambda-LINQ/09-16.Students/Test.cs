namespace _09_16_18_19.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        private const byte GroupNumber = 2;
        private const string Domain = "@abv.bg";
        private const string SofiaPhoneCode = "02/";

        static void Main()
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Ivan", "Georgiev", "123405", "02/23456", "ivan.georgiev@abv.bg", new List<int>() { 2, 3, 4 }, 1, new Group(1, "Biology")));
            listOfStudents.Add(new Student("Georgi", "Ivanov", "234506", "052/234567", "georgi.ivanov@abv.bg", new List<int>() { 3, 4, 5 }, 3, new Group(3, "Informatics")));
            listOfStudents.Add(new Student("Hristo", "Georgiev", "345607", "032/345678", "hristo.georgiev@gmail.com", new List<int>() { 4, 5, 6 }, 2, new Group(2, "Mathematics")));
            listOfStudents.Add(new Student("Hristo", "Petrov", "456708", "052/456789", "hristo.petrov@gmail.com", new List<int>() { 2, 3, 6 }, 4, new Group(4, "Physics")));
            listOfStudents.Add(new Student("Petar", "Hristov", "567809", "02/567890", "petar.hristov@abv.bg", new List<int>() { 2, 3, 2 }, 2, new Group(2, "Mathematics")));

            Console.WriteLine("List of all students that are from group number 2, ordered by first name:");

            //using LINQ query
            var query9 =
                from Student in listOfStudents
                where Student.GroupNumber == GroupNumber
                orderby Student.FirstName
                select new { Student.FirstName, Student.LastName, Student.GroupNumber };

            Console.WriteLine(string.Join("\n", query9));
            Console.WriteLine();

            //using lamba expression
            Console.WriteLine(string.Join("\n", listOfStudents.Where(x => x.GroupNumber == GroupNumber).OrderBy(x => x.FirstName).Select(x => new { x.FirstName, x.LastName, x.GroupNumber })));
            Console.WriteLine();

            Console.WriteLine("List of all students, that have e-mail in abv.bg:");

            //using LINQ query
            var query11 =
                from Student in listOfStudents
                where Student.Email.EndsWith(Domain)
                select new { Student.FirstName, Student.LastName, Student.Email };

            Console.WriteLine(string.Join("\n", query11));
            Console.WriteLine();

            //using lamba expression
            Console.WriteLine(string.Join("\n", listOfStudents.Where(x => x.Email.EndsWith(Domain)).Select(x => new { x.FirstName, x.LastName, x.Email })));
            Console.WriteLine();

            Console.WriteLine("List of all students with phones in Sofia:");

            //using LINQ query
            var query12 =
                from Student in listOfStudents
                where Student.TelephoneNumber.StartsWith(SofiaPhoneCode)
                select new { Student.FirstName, Student.LastName, Student.TelephoneNumber };

            Console.WriteLine(string.Join("\n", query12));
            Console.WriteLine();

            //using lamba expression
            Console.WriteLine(string.Join("\n", listOfStudents.Where(x => x.TelephoneNumber.StartsWith(SofiaPhoneCode)).Select(x => new { x.FirstName, x.LastName, x.TelephoneNumber })));
            Console.WriteLine();

            Console.WriteLine("List of all students that have at least one mark Excellent (6) with their full name and marks:");

            //using LINQ query
            var query13 =
                from Student in listOfStudents
                where Student.Marks.Contains(6)
                select new { Student.FirstName, Student.LastName, Marks = Student.GetMarks() };

            Console.WriteLine(string.Join("\n", query13));
            Console.WriteLine();

            //using lamba expression
            Console.WriteLine(string.Join("\n", listOfStudents.Where(x => x.Marks.Contains(6)).Select(x => new { x.FirstName, x.LastName, Marks = x.GetMarks() })));
            Console.WriteLine();

            Console.WriteLine("List of all students with exactly two marks '2':");

            //using LINQ query
            var query14 =
                from Student in listOfStudents
                where Student.Marks.Count(x => x == 2) == 2
                select new { Student.FirstName, Student.LastName, Marks = Student.GetMarks() };

            Console.WriteLine(string.Join("\n", query14));
            Console.WriteLine();

            //using lamba expression
            Console.WriteLine(string.Join("\n", listOfStudents.Where(x => x.Marks.Count(y => y == 2) == 2).Select(x => new { x.FirstName, x.LastName, Marks = x.GetMarks() })));
            Console.WriteLine();

            Console.WriteLine("List of all мarks of the students that enrolled in 2006.:");

            //using LINQ query
            var query15 =
                from Student in listOfStudents
                where Student.FacultyNumber[4] == '0' && Student.FacultyNumber[5] == '6'
                select new { Student.FirstName, Student.LastName, Student.FacultyNumber };

            Console.WriteLine(string.Join("\n", query15));
            Console.WriteLine();

            //using lamba expression
            Console.WriteLine(string.Join("\n", listOfStudents.Where(x => x.FacultyNumber[4] == '0' && x.FacultyNumber[5] == '6').Select(x => new { x.FirstName, x.LastName, x.FacultyNumber })));
            Console.WriteLine();

            Console.WriteLine("List of all students from 'Mathematics' department:");

            Group[] groups = new Group[] 
            {
                new Group(1, "Biology"),
                new Group(2, "Mathematics"),
                new Group(3, "Informatics"),
                new Group(4, "Physics"),
            };

            //using LINQ query
            var query16 =
                from Student in listOfStudents
                join element in groups
                  on Student.Group.DepartmentName equals element.DepartmentName
                  where element.DepartmentName == "Mathematics"
                select new { FirsName  = Student.FirstName, LastName = Student.LastName, DepartmenttName = element.DepartmentName };

            Console.WriteLine(string.Join("\n", query16));
            Console.WriteLine();

            //using lamba expression
            Console.WriteLine(string.Join("\n", listOfStudents.Join(groups, x => x.Group.DepartmentName, y => y.DepartmentName, (x, y) => new { x.FirstName, x.LastName, y.DepartmentName }).Where(y => y.DepartmentName == "Mathematics")));
            Console.WriteLine();

            Console.WriteLine("List of all students grouped by group name:");

            //using LINQ query
            var query18 =
                from Student in listOfStudents
                orderby Student.Group.GroupNumber
                select new { Student.FirstName, Student.LastName, Student.Group.GroupNumber };

            Console.WriteLine(string.Join("\n", query18));
            Console.WriteLine();

            //using lamba expression
            Console.WriteLine(string.Join("\n", listOfStudents.OrderBy(x => x.Group.GroupNumber).Select(x => new { x.FirstName, x.LastName, x.Group.GroupNumber })));
            Console.WriteLine();
        }
    }
}
