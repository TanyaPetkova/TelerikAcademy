namespace Student
{
    using System;

    class Test
    {
        static void Main()
        {
            Student student1 = new Student("Ivan", "Ivanov", "Ivanov", "486939693", "Sofia", "088888888", "ivanivanovivanov@gmail.com", 
                "first", Enums.Specialty.ComputerScience, Enums.University.TechnicalUniversity, Enums.Faculty.FacultyOfComputerSystemsAndControl);
            Student student2 = new Student("Ivan", "Ivanov", "Ivanov", "486939693", "Sofia", "088888888", "ivanivanovivanov@gmail.com",
                "first", Enums.Specialty.ComputerScience, Enums.University.TechnicalUniversity, Enums.Faculty.FacultyOfComputerSystemsAndControl);
            Student student3 = new Student("Ivan", "Ivanov", "Ivanov", "484830703", "Sofia", "0888999999", "ivanivanovivanov@abv.bg",
                "first", Enums.Specialty.ComputerScience, Enums.University.TechnicalUniversity, Enums.Faculty.FacultyOfComputerSystemsAndControl);

            Console.WriteLine(student1.Equals(student2)); //True
            Console.WriteLine(student2.Equals(student3)); //False
            Console.WriteLine(student1 == student2); //True
            Console.WriteLine(student2 != student3); //True
            Console.WriteLine(student1.GetHashCode());
            Console.WriteLine(student2.GetHashCode());

            Student newStudent = student1.Clone() as Student;

            student1.FirstName = "Georgi";
            Console.WriteLine(student1);
            Console.WriteLine();
            Console.WriteLine(newStudent);
            Console.WriteLine(student1.CompareTo(student2)); //-1
            Console.WriteLine(student2.CompareTo(student3)); //1            
        }
    }
}
