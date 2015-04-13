namespace _01.School
{
    using System.Collections.Generic;

    public class Student : Human
    {
        public int ClassNumber { get; private set; }
      
        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

    }
}
