namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher : ITeacher
    {
        private string name;
        private IList<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.Courses = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public IList<ICourse> Courses
        {
            get
            {
                return this.courses;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The list of courses cannot be null");
                }

                this.courses = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.Courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            var courseNames = this.courses.Select(x => x.Name);

            output.AppendFormat("Teacher: Name={0} ", this.Name);

            if (this.courses.Count != 0)
            {
                output.AppendFormat("; Courses=[{0}] ", string.Join(", ", courseNames));
            }
        
            return output.ToString();
        }
    }
}
