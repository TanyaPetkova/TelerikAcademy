namespace _01.School
{
    using System.Collections.Generic;

    public class School
    {
        public List<SchoolClass> Classes { get; private set; }

        public School()
        {
            this.Classes = new List<SchoolClass>();
        }

        public void AddClass(SchoolClass shoolClass)
        {
            this.Classes.Add(shoolClass);
        }

        public void RemoveClass(SchoolClass schoolClass)
        {
            this.Classes.Remove(schoolClass);
        }
    }
}
