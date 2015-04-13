namespace _01.School
{
    using System;

    class Test
    {
        static void Main()
        {
            School school = new School();
            SchoolClass schoolClass = new SchoolClass("A");
            school.AddClass(schoolClass);
            Console.WriteLine(schoolClass);

            Teacher teacher = new Teacher("Ivan Ivanov");
            teacher.AddDiscipline(new Discipline("Literature", 4, 4));
            schoolClass.AddTeacher(teacher);

            teacher = new Teacher("Petko Petkov");
            teacher.AddComment("Cool!");
            teacher.AddComment("Nice guy!");
            teacher.AddDiscipline(new Discipline("Music", 20, 10));
            schoolClass.AddTeacher(teacher);
            Console.WriteLine(schoolClass.GetTeachers());
            Student student = new Student("Jon", 7);
         
        }
    }
}
